using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Label = System.Windows.Forms.Label;
using DataTable = System.Data.DataTable;
using System.Text.RegularExpressions;

namespace Dopamine
{
    public partial class FormAdminPanel : MaterialForm
    {
        public FormAdminPanel()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(0, 0);

            UpdateProducts();
            UpdateProfiles();
            UpdateTable();

            materialListView1.GridLines = true;

            materialTextBoxIP.Text = Properties.Settings.Default.IP;
            materialTextBoxLoginServer.Text = Properties.Settings.Default.Username;
            materialTextBoxPassServer.Text = Properties.Settings.Default.Password;
            materialTextBoxDatabase.Text = Properties.Settings.Default.Database;

            materialTextBoxLoginAdmin.Text = Properties.Settings.Default.AdminLogin;
            materialTextBoxPasswordAdmin.Text = Properties.Settings.Default.AdminPassword;
        }

        void UpdateProducts()
        {
            System.Data.DataTable productsDT = new System.Data.DataTable();
            Connection.OpenConnection();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Products` WHERE `Selled` = false", Connection.con);
            try
            {
                msda.Fill(productsDT);
            }
            catch
            {

            }
            Connection.CloseConnection();

            flowLayoutPanelProducts.Controls.Clear();

            for (int i = 0; i < productsDT.Rows.Count; i++)
            {
                MaterialCard materialCardProduct = new MaterialSkin.Controls.MaterialCard();
                MaterialCard materialCardProductPic = new MaterialSkin.Controls.MaterialCard();
                MaterialLabel materialLabelProductName = new MaterialSkin.Controls.MaterialLabel();
                MaterialButton materialButtonProductOpen = new MaterialSkin.Controls.MaterialButton();
                MaterialButton materialButtonProductDelete = new MaterialSkin.Controls.MaterialButton();
                PictureBox pictureBoxProductPic = new System.Windows.Forms.PictureBox();
                // 
                // materialCardProduct
                // 
                materialCardProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCardProduct.Controls.Add(materialButtonProductDelete);
                materialCardProduct.Controls.Add(materialButtonProductOpen);
                materialCardProduct.Controls.Add(materialLabelProductName);
                materialCardProduct.Controls.Add(materialCardProductPic);
                materialCardProduct.Depth = 0;
                materialCardProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCardProduct.Location = new System.Drawing.Point(471, 14);
                materialCardProduct.Margin = new System.Windows.Forms.Padding(14);
                materialCardProduct.MouseState = MaterialSkin.MouseState.HOVER;
                materialCardProduct.Name = "materialCardProduct";
                materialCardProduct.Padding = new System.Windows.Forms.Padding(14);
                materialCardProduct.Size = new System.Drawing.Size(719, 87);
                materialCardProduct.TabIndex = 1;
                // 
                // materialCardProductPic
                // 
                materialCardProductPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCardProductPic.Controls.Add(pictureBoxProductPic);
                materialCardProductPic.Depth = 0;
                materialCardProductPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCardProductPic.Location = new System.Drawing.Point(8, 8);
                materialCardProductPic.Margin = new System.Windows.Forms.Padding(14);
                materialCardProductPic.MouseState = MaterialSkin.MouseState.HOVER;
                materialCardProductPic.Name = "materialCardProductPic";
                materialCardProductPic.Padding = new System.Windows.Forms.Padding(14);
                materialCardProductPic.Size = new System.Drawing.Size(70, 70);
                materialCardProductPic.TabIndex = 2;
                // 
                // materialLabelProductName
                // 
                materialLabelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                materialLabelProductName.AutoEllipsis = true;
                materialLabelProductName.Depth = 0;
                materialLabelProductName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                materialLabelProductName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                materialLabelProductName.Location = new System.Drawing.Point(95, 31);
                materialLabelProductName.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabelProductName.Name = "materialLabelProductName";
                materialLabelProductName.Size = new System.Drawing.Size(479, 23);
                materialLabelProductName.TabIndex = 3;
                materialLabelProductName.Text = "Пипидастр";
                // 
                // materialButtonProductOpen
                // 
                materialButtonProductOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                materialButtonProductOpen.AutoSize = false;
                materialButtonProductOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonProductOpen.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonProductOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonProductOpen.Depth = 0;
                materialButtonProductOpen.HighEmphasis = true;
                materialButtonProductOpen.Icon = null;
                materialButtonProductOpen.Location = new System.Drawing.Point(594, 8);
                materialButtonProductOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonProductOpen.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonProductOpen.Name = "materialButtonProductOpen";
                materialButtonProductOpen.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonProductOpen.Size = new System.Drawing.Size(107, 31);
                materialButtonProductOpen.TabIndex = 4;
                materialButtonProductOpen.Text = "Перейти";
                materialButtonProductOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                materialButtonProductOpen.UseAccentColor = false;
                materialButtonProductOpen.UseVisualStyleBackColor = true;
                materialButtonProductOpen.Tag = productsDT.Rows[i][0].ToString();
                materialButtonProductOpen.Click += new EventHandler(buttonOpenProduct_Click);
                materialButtonProductOpen.Cursor = Cursors.Hand;
                // 
                // materialButtonProductDelete
                // 
                materialButtonProductDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                materialButtonProductDelete.AutoSize = false;
                materialButtonProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonProductDelete.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonProductDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonProductDelete.Depth = 0;
                materialButtonProductDelete.HighEmphasis = true;
                materialButtonProductDelete.Icon = null;
                materialButtonProductDelete.Location = new System.Drawing.Point(594, 47);
                materialButtonProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonProductDelete.Name = "materialButtonProductDelete";
                materialButtonProductDelete.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonProductDelete.Size = new System.Drawing.Size(107, 31);
                materialButtonProductDelete.TabIndex = 5;
                materialButtonProductDelete.Text = "Удалить";
                materialButtonProductDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
                materialButtonProductDelete.UseAccentColor = false;
                materialButtonProductDelete.UseVisualStyleBackColor = true;
                materialButtonProductDelete.Tag = productsDT.Rows[i][0].ToString();
                materialButtonProductDelete.Click += new EventHandler(buttonDeleteProduct_Click);
                materialButtonProductDelete.Cursor = Cursors.Hand;
                // 
                // pictureBoxProductPic
                // 
                pictureBoxProductPic.Location = new System.Drawing.Point(3, 3);
                pictureBoxProductPic.Name = "pictureBoxProductPic";
                pictureBoxProductPic.Size = new System.Drawing.Size(64, 64);
                pictureBoxProductPic.TabIndex = 0;
                pictureBoxProductPic.TabStop = false;
                pictureBoxProductPic.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxProductPic.BackColor = Color.White;

                flowLayoutPanelProducts.Controls.Add(materialCardProduct);

                try
                {
                    Connection.OpenConnection();

                    MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + (int)productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);
                    System.Data.DataTable matcher_query = new System.Data.DataTable();
                    msda2.Fill(matcher_query);
                    Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);
                    pictureBoxProductPic.Image = picture;
                }
                catch
                {
                }

                MySqlCommand com = new MySqlCommand($"SELECT Name FROM Products WHERE `Code product` = {(int)productsDT.Rows[i][0]}", Connection.con);
                materialLabelProductName.Text = (string)com.ExecuteScalar();

            }
        }

        void UpdateProfiles()
        {
            DataTable profilesDT = new DataTable();
            Connection.OpenConnection();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Users` WHERE `Code user` <> " + Account.id, Connection.con);
            try
            {
                msda.Fill(profilesDT);
            }
            catch
            {

            }
            Connection.CloseConnection();


            flowLayoutPanelProfiles.Controls.Clear();

            for (int i = 0; i < profilesDT.Rows.Count; i++)
            {
                MaterialCard materialCardProduct = new MaterialSkin.Controls.MaterialCard();
                MaterialCard materialCardProductPic = new MaterialSkin.Controls.MaterialCard();
                MaterialLabel materialLabelProductName = new MaterialSkin.Controls.MaterialLabel();
                MaterialButton materialButtonProductOpen = new MaterialSkin.Controls.MaterialButton();
                MaterialButton materialButtonProductDelete = new MaterialSkin.Controls.MaterialButton();
                PictureBox pictureBoxProductPic = new System.Windows.Forms.PictureBox();
                // 
                // materialCardProduct
                // 
                materialCardProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCardProduct.Controls.Add(materialButtonProductDelete);
                materialCardProduct.Controls.Add(materialButtonProductOpen);
                materialCardProduct.Controls.Add(materialLabelProductName);
                materialCardProduct.Controls.Add(materialCardProductPic);
                materialCardProduct.Depth = 0;
                materialCardProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCardProduct.Location = new System.Drawing.Point(471, 14);
                materialCardProduct.Margin = new System.Windows.Forms.Padding(14);
                materialCardProduct.MouseState = MaterialSkin.MouseState.HOVER;
                materialCardProduct.Name = "materialCardProfile";
                materialCardProduct.Padding = new System.Windows.Forms.Padding(14);
                materialCardProduct.Size = new System.Drawing.Size(719, 87);
                materialCardProduct.TabIndex = 1;
                // 
                // materialCardProductPic
                // 
                materialCardProductPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCardProductPic.Controls.Add(pictureBoxProductPic);
                materialCardProductPic.Depth = 0;
                materialCardProductPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCardProductPic.Location = new System.Drawing.Point(8, 8);
                materialCardProductPic.Margin = new System.Windows.Forms.Padding(14);
                materialCardProductPic.MouseState = MaterialSkin.MouseState.HOVER;
                materialCardProductPic.Name = "materialCardProfilePic";
                materialCardProductPic.Padding = new System.Windows.Forms.Padding(14);
                materialCardProductPic.Size = new System.Drawing.Size(70, 70);
                materialCardProductPic.TabIndex = 2;
                // 
                // materialLabelProductName
                // 
                materialLabelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                materialLabelProductName.AutoEllipsis = true;
                materialLabelProductName.Depth = 0;
                materialLabelProductName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                materialLabelProductName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                materialLabelProductName.Location = new System.Drawing.Point(95, 31);
                materialLabelProductName.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabelProductName.Name = "materialLabelProfileName";
                materialLabelProductName.Size = new System.Drawing.Size(479, 23);
                materialLabelProductName.TabIndex = 3;
                materialLabelProductName.Text = "Пипидастр";
                // 
                // materialButtonProductOpen
                // 
                materialButtonProductOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                materialButtonProductOpen.AutoSize = false;
                materialButtonProductOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonProductOpen.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonProductOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonProductOpen.Depth = 0;
                materialButtonProductOpen.HighEmphasis = true;
                materialButtonProductOpen.Icon = null;
                materialButtonProductOpen.Location = new System.Drawing.Point(594, 8);
                materialButtonProductOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonProductOpen.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonProductOpen.Name = "materialButtonProfileOpen";
                materialButtonProductOpen.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonProductOpen.Size = new System.Drawing.Size(107, 31);
                materialButtonProductOpen.TabIndex = 4;
                materialButtonProductOpen.Text = "Заблокировать";
                materialButtonProductOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                materialButtonProductOpen.UseAccentColor = false;
                materialButtonProductOpen.UseVisualStyleBackColor = true;
                materialButtonProductOpen.Tag = profilesDT.Rows[i][0].ToString();
                materialButtonProductOpen.Click += new EventHandler(buttonBlockUser_Click);
                materialButtonProductOpen.Cursor = Cursors.Hand;
                // 
                // materialButtonProductDelete
                // 
                materialButtonProductDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                materialButtonProductDelete.AutoSize = false;
                materialButtonProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonProductDelete.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonProductDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonProductDelete.Depth = 0;
                materialButtonProductDelete.HighEmphasis = true;
                materialButtonProductDelete.Icon = null;
                materialButtonProductDelete.Location = new System.Drawing.Point(594, 47);
                materialButtonProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonProductDelete.Name = "materialButtonProfileDelete";
                materialButtonProductDelete.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonProductDelete.Size = new System.Drawing.Size(107, 31);
                materialButtonProductDelete.TabIndex = 5;
                materialButtonProductDelete.Text = "Удалить";
                materialButtonProductDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
                materialButtonProductDelete.UseAccentColor = false;
                materialButtonProductDelete.UseVisualStyleBackColor = true;
                materialButtonProductDelete.Tag = profilesDT.Rows[i][0].ToString();
                materialButtonProductDelete.Click += new EventHandler(buttonDeleteProfile_Click);
                materialButtonProductDelete.Cursor = Cursors.Hand;
                // 
                // pictureBoxProductPic
                // 
                pictureBoxProductPic.Location = new System.Drawing.Point(3, 3);
                pictureBoxProductPic.Name = "pictureBoxProfilePic";
                pictureBoxProductPic.Size = new System.Drawing.Size(64, 64);
                pictureBoxProductPic.TabIndex = 0;
                pictureBoxProductPic.TabStop = false;
                pictureBoxProductPic.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxProductPic.BackColor = Color.White;

                flowLayoutPanelProfiles.Controls.Add(materialCardProduct);

                if (profilesDT.Rows[i][6].ToString() == "True")
                {
                    materialButtonProductOpen.Text = "Разблок.";
                    materialButtonProductOpen.Click += new EventHandler(buttonUnblockUser_Click);
                    materialButtonProductOpen.Click -= new EventHandler(buttonBlockUser_Click);
                }

                try
                {
                    Connection.OpenConnection();

                    MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Profile pictures` WHERE `Code user` = " + (int)profilesDT.Rows[i][0], Connection.con);
                    DataTable matcher_query = new DataTable();
                    msda2.Fill(matcher_query);
                    Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);
                    pictureBoxProductPic.Image = picture;
                }
                catch
                {
                }

                MySqlCommand com = new MySqlCommand($"SELECT Name FROM Users WHERE `Code user` = {(int)profilesDT.Rows[i][0]}", Connection.con);
                materialLabelProductName.Text = (string)com.ExecuteScalar();

            }
        }

        private void buttonBlockUser_Click(object sender, EventArgs e)
        {


            BlackOutFormReason bfrm2 = new BlackOutFormReason(this.Width, this.Height, this.Location.X, this.Location.Y);
            bfrm2.ShowDialog();
            int tag = Convert.ToInt32(((MaterialButton)sender).Tag);

            if (DialogBoxResultcs.result == true)
            {
                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand($"UPDATE `Users` SET `Banned` = 1, `Reason` = '{Reason.reason}' WHERE `Code user` = " + tag, Connection.con);
                com.ExecuteNonQuery();

                Connection.CloseConnection();

                UpdateProfiles();
            }

        }
        private void buttonUnblockUser_Click(object sender, EventArgs e)
        {


            BlackOutForm2 bfrm2 = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Разблокировка", "Разблокировать пользователя?", 2);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                int tag = Convert.ToInt32(((MaterialButton)sender).Tag);

                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand($"UPDATE `Users` SET `Banned` = 0, `Reason` = '{Reason.reason}' WHERE `Code user` = " + tag, Connection.con);
                com.ExecuteNonQuery();

                Connection.CloseConnection();

                UpdateProfiles();
            }
        }

        private void materialButtonUpdateProducts_Click(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        private void buttonDeleteProfile_Click(object sender, EventArgs e)
        {
            BlackOutForm2 bfrm2 = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Удаление", "Удалить профиль?", 2);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                int tag = Convert.ToInt32(((MaterialButton)sender).Tag);

                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand("DELETE FROM `Users` WHERE `Code user` = " + tag, Connection.con);
                com.ExecuteNonQuery();

                Connection.CloseConnection();

                UpdateProfiles();
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            BlackOutForm2 bfrm2 = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Удаление", "Удалить объявление?", 2);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                int tag = Convert.ToInt32(((MaterialButton)sender).Tag);

                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand("DELETE FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                com.ExecuteNonQuery();

                Connection.CloseConnection();

                UpdateProducts();
            }
        }

        private void buttonOpenProduct_Click(object sender, EventArgs e)
        {

            int tag = Convert.ToInt32(((MaterialButton)sender).Tag);

            CreateTabProduct(tag);

            materialTabControl.SelectedIndex = materialTabControl.TabPages.Count - 1;

        }

        private void FormAdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            FormMain frm = new FormMain();
            frm.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //panelPopUp.Visible = true;
            //timer1.Enabled = true;
            int index = 0;

            if (materialTabControl.SelectedIndex != materialTabControl.TabPages.Count - 1)
            {
                index = materialTabControl.SelectedIndex;
            }
            else if (materialTabControl.SelectedIndex == materialTabControl.TabPages.Count - 1 && materialTabControl.TabPages.Count != 4)
            {
                index = materialTabControl.SelectedIndex - 1;
            }
            else if (materialTabControl.SelectedIndex == materialTabControl.TabPages.Count - 1 && materialTabControl.TabPages.Count == 4)
            {
                index = 0;
            }

            materialTabControl.TabPages.Remove((TabPage)((MaterialFloatingActionButton)sender).Parent);


            materialTabControl.SelectedIndex = index;



        }

        public void CreateTabProduct(int tag)
        {

            bool isNoRepeat = true;

            Connection.OpenConnection();

            MySqlCommand comName = new MySqlCommand("SELECT `Name` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
            string name = Convert.ToString(comName.ExecuteScalar());

            Connection.CloseConnection();

            for (int i = 0; i < materialTabControl.TabPages.Count; i++)
            {
                if (materialTabControl.TabPages[i].Text == name)
                {
                    isNoRepeat = false;
                }
            }

            if (isNoRepeat == true)
            {
                TabPage tabPageProduct;
                Label label2;
                Label labelStatus;
                Label labelCategory = new Label();
                Label labelProductInfo;
                Label label3;
                Label labelAdress;
                Label label4;
                Label labelUserName;
                Label labelProductCost;
                PictureBox pictureBoxPreview;
                Label labelProductName;
                MaterialButton materialButtonShowPhone;
                MaterialButton materialButtonConnect;
                MaterialCard materialCardInfo;
                MaterialCard materialCardAddress;
                MaterialCard materialCardPictures;
                MaterialCard materialCardPicturePreview;
                MaterialFloatingActionButton materialFloatingActionButtonClose;
                FlowLayoutPanel flowLayoutPanelPictures;
                MaterialCard materialCard2;
                PictureBox pictureBoxCarts;
                PictureBox pictureBoxViews;
                MaterialLabel materialLabelViews;
                MaterialLabel materialLabelCarts;

                tabPageProduct = new System.Windows.Forms.TabPage();
                label2 = new System.Windows.Forms.Label();
                labelStatus = new System.Windows.Forms.Label();
                labelProductInfo = new System.Windows.Forms.Label();
                label3 = new System.Windows.Forms.Label();
                labelAdress = new System.Windows.Forms.Label();
                label4 = new System.Windows.Forms.Label();
                labelUserName = new System.Windows.Forms.Label();
                labelProductCost = new System.Windows.Forms.Label();
                labelProductName = new System.Windows.Forms.Label();
                materialButtonShowPhone = new MaterialSkin.Controls.MaterialButton();
                materialButtonConnect = new MaterialSkin.Controls.MaterialButton();
                materialCardInfo = new MaterialSkin.Controls.MaterialCard();
                materialCardAddress = new MaterialSkin.Controls.MaterialCard();
                materialCardPicturePreview = new MaterialSkin.Controls.MaterialCard();
                materialFloatingActionButtonClose = new MaterialSkin.Controls.MaterialFloatingActionButton();
                pictureBoxPreview = new System.Windows.Forms.PictureBox();
                materialCardPictures = new MaterialCard();
                flowLayoutPanelPictures = new FlowLayoutPanel();
                materialCard2 = new MaterialSkin.Controls.MaterialCard();
                pictureBoxCarts = new System.Windows.Forms.PictureBox();
                pictureBoxViews = new System.Windows.Forms.PictureBox();
                materialLabelViews = new MaterialSkin.Controls.MaterialLabel();
                materialLabelCarts = new MaterialSkin.Controls.MaterialLabel();
                // 
                // materialCard2
                // 
                materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCard2.Controls.Add(materialLabelCarts);
                materialCard2.Controls.Add(materialLabelViews);
                materialCard2.Controls.Add(pictureBoxCarts);
                materialCard2.Controls.Add(pictureBoxViews);
                materialCard2.Depth = 0;
                materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCard2.Location = new System.Drawing.Point(655, 350);
                materialCard2.Margin = new System.Windows.Forms.Padding(14);
                materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
                materialCard2.Name = "materialCard2";
                materialCard2.Padding = new System.Windows.Forms.Padding(14);
                materialCard2.Size = new System.Drawing.Size(210, 67);
                materialCard2.TabIndex = 42;
                // 
                // pictureBoxCarts
                // 
                pictureBoxCarts.Image = global::Dopamine.Properties.Resources.icons8_cart_48;
                pictureBoxCarts.Location = new System.Drawing.Point(110, 21);
                pictureBoxCarts.Name = "pictureBoxCarts";
                pictureBoxCarts.Size = new System.Drawing.Size(25, 25);
                pictureBoxCarts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxCarts.TabIndex = 1;
                pictureBoxCarts.TabStop = false;
                // 
                // pictureBoxViews
                // 
                pictureBoxViews.Image = global::Dopamine.Properties.Resources.icons8_eye_48;
                pictureBoxViews.Location = new System.Drawing.Point(18, 21);
                pictureBoxViews.Name = "pictureBoxViews";
                pictureBoxViews.Size = new System.Drawing.Size(25, 25);
                pictureBoxViews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxViews.TabIndex = 0;
                pictureBoxViews.TabStop = false;
                // 
                // materialLabelViews
                // 
                materialLabelViews.AutoEllipsis = true;
                materialLabelViews.Depth = 0;
                materialLabelViews.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                materialLabelViews.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                materialLabelViews.Location = new System.Drawing.Point(53, 21);
                materialLabelViews.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabelViews.Name = "materialLabelViews";
                materialLabelViews.Size = new System.Drawing.Size(40, 20);
                materialLabelViews.TabIndex = 35;
                materialLabelViews.Text = "0";
                // 
                // materialLabelCarts
                // 
                materialLabelCarts.AutoEllipsis = true;
                materialLabelCarts.Depth = 0;
                materialLabelCarts.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                materialLabelCarts.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                materialLabelCarts.Location = new System.Drawing.Point(145, 21);
                materialLabelCarts.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabelCarts.Name = "materialLabelCarts";
                materialLabelCarts.Size = new System.Drawing.Size(73, 20);
                materialLabelCarts.TabIndex = 36;
                materialLabelCarts.Text = "0";
                // 
                // flowLayoutPanelPictures
                // 
                flowLayoutPanelPictures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
                flowLayoutPanelPictures.AutoScroll = true;
                flowLayoutPanelPictures.BackColor = System.Drawing.Color.White;
                flowLayoutPanelPictures.Location = new System.Drawing.Point(25, 423);
                flowLayoutPanelPictures.Name = "flowLayoutPanelPictures";
                flowLayoutPanelPictures.Size = new System.Drawing.Size(245, 90);
                flowLayoutPanelPictures.TabIndex = 0;
                //flowLayoutPanelPictures.BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanelPictures.BringToFront();
                // 
                // materialCardPictures
                // 
                materialCardPictures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
                materialCardPictures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCardPictures.Controls.Add(flowLayoutPanelPictures);
                materialCardPictures.Depth = 0;
                materialCardPictures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCardPictures.Location = new System.Drawing.Point(20, 418);
                materialCardPictures.Margin = new System.Windows.Forms.Padding(14);
                materialCardPictures.MouseState = MaterialSkin.MouseState.HOVER;
                materialCardPictures.Name = "materialCardInfo";
                materialCardPictures.Padding = new System.Windows.Forms.Padding(14);
                materialCardPictures.Size = new System.Drawing.Size(255, 100);
                materialCardPictures.TabIndex = 40;

                // 
                // tabPageProduct
                // 
                tabPageProduct.AutoScroll = true;
                tabPageProduct.BackColor = System.Drawing.SystemColors.Control;
                tabPageProduct.Controls.Add(materialFloatingActionButtonClose);
                tabPageProduct.Controls.Add(materialCardPicturePreview);
                tabPageProduct.Controls.Add(materialCardAddress);
                tabPageProduct.Controls.Add(materialCardInfo);
                tabPageProduct.Controls.Add(materialButtonConnect);
                tabPageProduct.Controls.Add(labelCategory);
                //tabPageProduct.Controls.Add(materialButtonShowPhone);
                //tabPageProduct.Controls.Add(label2);
                tabPageProduct.Controls.Add(labelStatus);
                tabPageProduct.Controls.Add(label3);
                tabPageProduct.Controls.Add(label4);
                //tabPageProduct.Controls.Add(labelUserName);
                tabPageProduct.Controls.Add(labelProductCost);
                tabPageProduct.Controls.Add(labelProductName);
                //tabPageProduct.Controls.Add(materialCard2);
                //tabPageProduct.Controls.Add(flowLayoutPanelPictures);
                //tabPageProduct.Controls.Add(materialCardPictures);
                tabPageProduct.Controls.Add(labelProductName);
                //tabPageProduct.ImageKey = "icons8-big-parcel-48.png";
                tabPageProduct.Location = new System.Drawing.Point(4, 31);
                tabPageProduct.Name = "tabPageProduct";
                tabPageProduct.Size = new System.Drawing.Size(973, 497);
                tabPageProduct.TabIndex = 5;
                tabPageProduct.Text = "ProductName";
                // 
                // label2
                // 
                label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                label2.AutoSize = true;
                label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label2.Location = new System.Drawing.Point(733, 275);
                label2.Name = "label2";
                label2.Size = new System.Drawing.Size(67, 15);
                label2.TabIndex = 37;
                label2.Text = "Продавец";
                // 
                // labelStatus
                // 
                labelStatus.AutoSize = true;
                labelStatus.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelStatus.Location = new System.Drawing.Point(16, 130);
                labelStatus.Name = "labelStatus";
                labelStatus.Size = new System.Drawing.Size(65, 23);
                labelStatus.TabIndex = 35;
                labelStatus.Text = "Status";
                // 
                // labelCategory
                // 
                labelCategory.AutoSize = true;
                labelCategory.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelCategory.Location = new System.Drawing.Point(16, 96);
                labelCategory.Name = "labelCategory";
                labelCategory.Size = new System.Drawing.Size(65, 23);
                labelCategory.TabIndex = 35;
                labelCategory.Text = "Category";
                // 
                // labelProductInfo
                // 
                labelProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
                labelProductInfo.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelProductInfo.Location = new System.Drawing.Point(16, 14);
                labelProductInfo.Name = "labelProductInfo";
                labelProductInfo.Size = new System.Drawing.Size(276, 114);
                labelProductInfo.TabIndex = 34;
                labelProductInfo.Text = "Info";
                labelProductInfo.AutoSize = false;
                // 
                // label3
                // 
                label3.AutoSize = true;
                label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
                label3.Location = new System.Drawing.Point(304, 207);
                label3.Name = "label3";
                label3.Size = new System.Drawing.Size(97, 23);
                label3.TabIndex = 33;
                label3.Text = "Описание";
                // 
                // labelAdress
                // 
                labelAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
                labelAdress.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelAdress.Location = new System.Drawing.Point(16, 14);
                labelAdress.Name = "labelAdress";
                labelAdress.Size = new System.Drawing.Size(276, 33);
                labelAdress.TabIndex = 32;
                labelAdress.Text = "Adress";
                labelAdress.AutoEllipsis = true;
                // 
                // label4
                // 
                label4.AutoSize = true;
                label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
                label4.Location = new System.Drawing.Point(304, 94);
                label4.Name = "label4";
                label4.Size = new System.Drawing.Size(66, 23);
                label4.TabIndex = 31;
                label4.Text = "Адрес";
                // 
                // labelUserName
                // 
                labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                labelUserName.Cursor = System.Windows.Forms.Cursors.Hand;
                labelUserName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelUserName.Location = new System.Drawing.Point(733, 302);
                labelUserName.Name = "labelUserName";
                labelUserName.Size = new System.Drawing.Size(213, 45);
                labelUserName.TabIndex = 30;
                labelUserName.Text = "UserName";
                //labelUserName.MouseEnter += new EventHandler(labelUserName_MouseEnter);
                //labelUserName.MouseLeave += new EventHandler(labelUserName_MouseLeave);
                //labelUserName.Click += new EventHandler(labelUserName_Click);
                // 
                // labelProductCost
                // 
                labelProductCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                labelProductCost.AutoSize = true;
                labelProductCost.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelProductCost.Location = new System.Drawing.Point(730, 53);
                labelProductCost.Name = "labelProductCost";
                labelProductCost.Size = new System.Drawing.Size(91, 33);
                labelProductCost.TabIndex = 28;
                labelProductCost.Text = "999 ₽";
                // 
                // labelProductName
                // 
                labelProductName.AutoSize = true;
                labelProductName.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelProductName.Location = new System.Drawing.Point(14, 53);
                labelProductName.Name = "labelProductName";
                labelProductName.Size = new System.Drawing.Size(193, 33);
                labelProductName.TabIndex = 26;
                labelProductName.Text = "ProductName";
                // 
                // materialButtonShowPhone
                // 
                materialButtonShowPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                materialButtonShowPhone.AutoSize = false;
                materialButtonShowPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonShowPhone.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonShowPhone.Cursor = System.Windows.Forms.Cursors.Hand;
                materialButtonShowPhone.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonShowPhone.Depth = 0;
                materialButtonShowPhone.HighEmphasis = true;
                materialButtonShowPhone.Icon = null;
                materialButtonShowPhone.Location = new System.Drawing.Point(736, 141);
                materialButtonShowPhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonShowPhone.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonShowPhone.Name = "materialButtonShowPhone";
                materialButtonShowPhone.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonShowPhone.Size = new System.Drawing.Size(210, 47);
                materialButtonShowPhone.TabIndex = 38;
                materialButtonShowPhone.Text = "Показать телефон";
                materialButtonShowPhone.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                materialButtonShowPhone.UseAccentColor = false;
                materialButtonShowPhone.UseVisualStyleBackColor = true;
                //materialButtonShowPhone.Click += new EventHandler(buttonShowPhone_click);

                // 
                // materialButtonConnect
                // 
                materialButtonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                materialButtonConnect.AutoSize = false;
                materialButtonConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonConnect.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
                materialButtonConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonConnect.Depth = 0;
                materialButtonConnect.HighEmphasis = true;
                materialButtonConnect.Icon = null;
                materialButtonConnect.Location = new System.Drawing.Point(736, 141);
                materialButtonConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonConnect.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonConnect.Name = "materialButtonConnect";
                materialButtonConnect.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonConnect.Size = new System.Drawing.Size(210, 47);
                materialButtonConnect.TabIndex = 39;
                materialButtonConnect.Text = "Удалить объявление";
                materialButtonConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                materialButtonConnect.UseAccentColor = true;
                materialButtonConnect.UseVisualStyleBackColor = true;
                materialButtonConnect.Click += new EventHandler(buttonDeleteProduct_Click);

                // 
                // materialCardInfo
                // 
                materialCardInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCardInfo.Controls.Add(labelProductInfo);
                materialCardInfo.Depth = 0;
                materialCardInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCardInfo.Location = new System.Drawing.Point(310, 244);
                materialCardInfo.Margin = new System.Windows.Forms.Padding(14);
                materialCardInfo.MouseState = MaterialSkin.MouseState.HOVER;
                materialCardInfo.Name = "materialCardInfo";
                materialCardInfo.Padding = new System.Windows.Forms.Padding(14);
                materialCardInfo.Size = new System.Drawing.Size(309, 200);
                materialCardInfo.TabIndex = 40;
                materialCardInfo.AutoScroll = true;
                // 
                // materialCardAddress
                // 
                materialCardAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCardAddress.Controls.Add(labelAdress);
                materialCardAddress.Depth = 0;
                materialCardAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCardAddress.Location = new System.Drawing.Point(310, 131);
                materialCardAddress.Margin = new System.Windows.Forms.Padding(14);
                materialCardAddress.MouseState = MaterialSkin.MouseState.HOVER;
                materialCardAddress.Name = "materialCardAddress";
                materialCardAddress.Padding = new System.Windows.Forms.Padding(14);
                materialCardAddress.Size = new System.Drawing.Size(309, 50);
                materialCardAddress.TabIndex = 41;
                // 
                // materialCardPicturePreview
                // 
                materialCardPicturePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCardPicturePreview.Controls.Add(pictureBoxPreview);
                materialCardPicturePreview.Depth = 0;
                materialCardPicturePreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCardPicturePreview.Location = new System.Drawing.Point(20, 161);
                materialCardPicturePreview.Margin = new System.Windows.Forms.Padding(14);
                materialCardPicturePreview.MouseState = MaterialSkin.MouseState.HOVER;
                materialCardPicturePreview.Name = "materialCardPicturePreview";
                materialCardPicturePreview.Padding = new System.Windows.Forms.Padding(14);
                materialCardPicturePreview.Size = new System.Drawing.Size(255, 255);
                materialCardPicturePreview.TabIndex = 42;
                // 
                // materialFloatingActionButtonClose
                // 
                materialFloatingActionButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                materialFloatingActionButtonClose.Depth = 0;
                materialFloatingActionButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                materialFloatingActionButtonClose.Icon = global::Dopamine.Properties.Resources.icons8_close_48__1_;
                materialFloatingActionButtonClose.ImageKey = "(отсутствует)";
                materialFloatingActionButtonClose.Location = new System.Drawing.Point(930, 3);
                materialFloatingActionButtonClose.Mini = true;
                materialFloatingActionButtonClose.MouseState = MaterialSkin.MouseState.HOVER;
                materialFloatingActionButtonClose.Name = "materialFloatingActionButtonClose";
                materialFloatingActionButtonClose.Size = new System.Drawing.Size(40, 40);
                materialFloatingActionButtonClose.TabIndex = 43;
                materialFloatingActionButtonClose.Text = "Закрыть";
                materialFloatingActionButtonClose.UseVisualStyleBackColor = true;
                materialFloatingActionButtonClose.Cursor = Cursors.Hand;
                materialFloatingActionButtonClose.Click += new EventHandler(buttonClose_Click);
                // 
                // pictureBoxPreview
                // 
                pictureBoxPreview.BackColor = System.Drawing.Color.White;
                pictureBoxPreview.Location = new System.Drawing.Point(3, 3);
                pictureBoxPreview.Name = "pictureBoxPreview";
                pictureBoxPreview.Size = new System.Drawing.Size(249, 249);
                pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxPreview.TabIndex = 27;
                pictureBoxPreview.TabStop = false;

                MaterialButton materialButtonSellProduct;
                materialButtonSellProduct = new MaterialButton();
                materialButtonSellProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                materialButtonSellProduct.AutoSize = false;
                materialButtonSellProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonSellProduct.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonSellProduct.Cursor = System.Windows.Forms.Cursors.Hand;
                materialButtonSellProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonSellProduct.Depth = 0;
                materialButtonSellProduct.HighEmphasis = true;
                materialButtonSellProduct.Icon = null;
                materialButtonSellProduct.Location = new System.Drawing.Point(736, 141);
                materialButtonSellProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonSellProduct.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonSellProduct.Name = "materialButtonSellProduct";
                materialButtonSellProduct.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonSellProduct.Size = new System.Drawing.Size(210, 47);
                materialButtonSellProduct.TabIndex = 38;
                materialButtonSellProduct.Text = "Добавить в избранные";
                materialButtonSellProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
                materialButtonSellProduct.UseAccentColor = false;
                materialButtonSellProduct.UseVisualStyleBackColor = true;

                materialTabControl.TabPages.Add(tabPageProduct);

                //tabPageProduct.Enter += new EventHandler(tabPageHome_Enter);

                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand("SELECT `Name` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                MySqlCommand com22 = new MySqlCommand("SELECT `Category` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                MySqlCommand com2 = new MySqlCommand("SELECT `Status` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                MySqlCommand com3 = new MySqlCommand("SELECT `Cost` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                MySqlCommand com4 = new MySqlCommand("SELECT `Code user` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                MySqlCommand com5 = new MySqlCommand("SELECT `Name` FROM `Users` WHERE `Code user` = " + Convert.ToInt32(com4.ExecuteScalar()), Connection.con);
                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + tag + " AND `IsPreview` = 1", Connection.con);
                DataTable matcher_query = new DataTable();
                msda.Fill(matcher_query);
                try
                {


                    Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);


                    pictureBoxPreview.Image = picture;
                }
                catch
                {

                }
                MySqlCommand com6 = new MySqlCommand("SELECT `Location` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                MySqlCommand com7 = new MySqlCommand("SELECT `Info` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                MySqlCommand com8 = new MySqlCommand("SELECT `City` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                MySqlCommand com10 = new MySqlCommand("SELECT `Selled` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                tabPageProduct.Text = Convert.ToString(com.ExecuteScalar());
                labelProductName.Text = Convert.ToString(com.ExecuteScalar());
                labelCategory.Text = Convert.ToString(com22.ExecuteScalar());
                labelStatus.Text = Convert.ToString(com2.ExecuteScalar());
                labelProductCost.Text = Convert.ToString(com3.ExecuteScalar()) + " ₽";
                labelUserName.Text = Convert.ToString(com5.ExecuteScalar());
                labelAdress.Text = Convert.ToString(com8.ExecuteScalar()) + " " + Convert.ToString(com6.ExecuteScalar());
                labelProductInfo.Text = Convert.ToString(com7.ExecuteScalar());
                labelUserName.Tag = Convert.ToInt32(com4.ExecuteScalar());
                materialButtonSellProduct.Tag = tag;

                int n = labelProductInfo.Text.Count(c => c == '\n');
                if (n == 6)
                {
                    labelProductInfo.Size = new System.Drawing.Size(276, 145);
                }
                if (n >= 7)
                {
                    labelProductInfo.Size = new System.Drawing.Size(276, labelProductInfo.Size.Height + 15 * n - 6);
                }

            }


        }

        private void materialButtonUpdate2_Click(object sender, EventArgs e)
        {
            UpdateProfiles();
        }

        void UpdateTable()
        {
            Connection.OpenConnection();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `Products`.`Name`, `Products`.`Cost`, `Users`.`Name`, `Products`.`Date sell` FROM `Products`, `Users` WHERE `Products`.`Code user` = `Users`.`Code user` AND `Products`.`Selled` = 1", Connection.con);

            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch
            {
                this.Text = "Dopamine (Администратор) (Сервер не найден)";
            }

            Connection.CloseConnection();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                materialListView1.Items.Add(item);
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void Export(System.Data.DataTable dt)
        {
            Excel.Application objExcel = new Excel.Application();
            Excel.Workbook workbook = objExcel.Workbooks.Add();
            Excel.Worksheet sheet = workbook.ActiveSheet;
            Excel.Range range = sheet.Range[sheet.Cells[1, 1], sheet.Cells[dt.Rows.Count, dt.Columns.Count]];
            for (int i = 0; i < dt.Rows.Count; ++i)
                for (int j = 0; j < dt.Columns.Count; ++j)
                    range.Cells[1 + i, 1 + j] = dt.Columns[j].ColumnName;
            for (int i = 0; i < dt.Rows.Count; ++i)
                for (int j = 0; j < dt.Columns.Count; ++j)
                    range.Cells[2 + i, 1 + j] = dt.Rows[i][j].ToString();
            sheet.Cells.EntireColumn.AutoFit();
            sheet.Cells.EntireRow.AutoFit();
            sheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
            sheet.PageSetup.Zoom = false;
            sheet.PageSetup.FitToPagesWide = 1;
            sheet.PageSetup.FitToPagesTall = false;
            sheet.PageSetup.ScaleWithDocHeaderFooter = true;
            sheet.PageSetup.AlignMarginsHeaderFooter = true;
            sheet.Name = "Проданные товары";
            objExcel.Visible = true;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `Products`.`Name`, `Products`.`Cost`, `Users`.`Name`, `Products`.`Date sell` FROM `Products`, `Users` WHERE `Products`.`Code user` = `Users`.`Code user` AND `Products`.`Selled` = 1", Connection.con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            Connection.CloseConnection();

            dt.Columns[0].ColumnName = "Товар";
            dt.Columns[1].ColumnName = "Стоимость";
            dt.Columns[2].ColumnName = "Продавец";
            dt.Columns[3].ColumnName = "Дата продажи";

            if (dt.Rows.Count != 0)
            {
                Export(dt);
            }


        }

        private void materialButtonFind_Click(object sender, EventArgs e)
        {
            System.Data.DataTable productsDT = new System.Data.DataTable();
            Connection.OpenConnection();
            MySqlDataAdapter msdaa = new MySqlDataAdapter("SELECT * FROM `Products` WHERE `Selled` = false", Connection.con);
            msdaa.Fill(productsDT);
            Connection.CloseConnection();

            int loseCount = 0;
            DataTable productsDTNormal = new DataTable();
            if (materialTextBoxFind.Text == "")
            {
                UpdateProducts();
                materialButtonCancelFind.Visible = false;
            }
            for (int j = 0; j < productsDT.Rows.Count; j++)
            {
                productsDT.Rows[j][3] = productsDT.Rows[j][3].ToString().ToLower();
                bool result = Regex.IsMatch(Convert.ToString(productsDT.Rows[j][3]), "\\b" + materialTextBoxFind.Text.ToString().ToLower() + "\\b");

                if (result == true)
                {
                    productsDT.Clear();
                    Connection.OpenConnection();

                    MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Products`", Connection.con);

                    msda.Fill(productsDT);
                    msda.Fill(productsDTNormal);

                    Connection.CloseConnection();

                    flowLayoutPanelProducts.Controls.Clear();
                    productsDT.Rows[j][3] = productsDT.Rows[j][3].ToString().ToLower();

                    if (materialTextBoxFind.Text != "")
                    {
                        materialButtonCancelFind.Visible = true;
                    }

                    for (int i = 0; i < productsDT.Rows.Count; i++)
                    {
                        if (Convert.ToString(productsDT.Rows[i][3]).Contains(materialTextBoxFind.Text.ToLower()))
                        {
                            if ((bool)productsDT.Rows[i][10] != true)
                            {
                                MaterialCard materialCardProduct = new MaterialSkin.Controls.MaterialCard();
                                MaterialCard materialCardProductPic = new MaterialSkin.Controls.MaterialCard();
                                MaterialLabel materialLabelProductName = new MaterialSkin.Controls.MaterialLabel();
                                MaterialButton materialButtonProductOpen = new MaterialSkin.Controls.MaterialButton();
                                MaterialButton materialButtonProductDelete = new MaterialSkin.Controls.MaterialButton();
                                PictureBox pictureBoxProductPic = new System.Windows.Forms.PictureBox();
                                // 
                                // materialCardProduct
                                // 
                                materialCardProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                                materialCardProduct.Controls.Add(materialButtonProductDelete);
                                materialCardProduct.Controls.Add(materialButtonProductOpen);
                                materialCardProduct.Controls.Add(materialLabelProductName);
                                materialCardProduct.Controls.Add(materialCardProductPic);
                                materialCardProduct.Depth = 0;
                                materialCardProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                                materialCardProduct.Location = new System.Drawing.Point(471, 14);
                                materialCardProduct.Margin = new System.Windows.Forms.Padding(14);
                                materialCardProduct.MouseState = MaterialSkin.MouseState.HOVER;
                                materialCardProduct.Name = "materialCardProduct";
                                materialCardProduct.Padding = new System.Windows.Forms.Padding(14);
                                materialCardProduct.Size = new System.Drawing.Size(719, 87);
                                materialCardProduct.TabIndex = 1;
                                // 
                                // materialCardProductPic
                                // 
                                materialCardProductPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                                materialCardProductPic.Controls.Add(pictureBoxProductPic);
                                materialCardProductPic.Depth = 0;
                                materialCardProductPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                                materialCardProductPic.Location = new System.Drawing.Point(8, 8);
                                materialCardProductPic.Margin = new System.Windows.Forms.Padding(14);
                                materialCardProductPic.MouseState = MaterialSkin.MouseState.HOVER;
                                materialCardProductPic.Name = "materialCardProductPic";
                                materialCardProductPic.Padding = new System.Windows.Forms.Padding(14);
                                materialCardProductPic.Size = new System.Drawing.Size(70, 70);
                                materialCardProductPic.TabIndex = 2;
                                // 
                                // materialLabelProductName
                                // 
                                materialLabelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
                                materialLabelProductName.AutoEllipsis = true;
                                materialLabelProductName.Depth = 0;
                                materialLabelProductName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                                materialLabelProductName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                                materialLabelProductName.Location = new System.Drawing.Point(95, 31);
                                materialLabelProductName.MouseState = MaterialSkin.MouseState.HOVER;
                                materialLabelProductName.Name = "materialLabelProductName";
                                materialLabelProductName.Size = new System.Drawing.Size(479, 23);
                                materialLabelProductName.TabIndex = 3;
                                materialLabelProductName.Text = "Пипидастр";
                                // 
                                // materialButtonProductOpen
                                // 
                                materialButtonProductOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                                materialButtonProductOpen.AutoSize = false;
                                materialButtonProductOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                                materialButtonProductOpen.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                                materialButtonProductOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                                materialButtonProductOpen.Depth = 0;
                                materialButtonProductOpen.HighEmphasis = true;
                                materialButtonProductOpen.Icon = null;
                                materialButtonProductOpen.Location = new System.Drawing.Point(594, 8);
                                materialButtonProductOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                                materialButtonProductOpen.MouseState = MaterialSkin.MouseState.HOVER;
                                materialButtonProductOpen.Name = "materialButtonProductOpen";
                                materialButtonProductOpen.NoAccentTextColor = System.Drawing.Color.Empty;
                                materialButtonProductOpen.Size = new System.Drawing.Size(107, 31);
                                materialButtonProductOpen.TabIndex = 4;
                                materialButtonProductOpen.Text = "Перейти";
                                materialButtonProductOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                                materialButtonProductOpen.UseAccentColor = false;
                                materialButtonProductOpen.UseVisualStyleBackColor = true;
                                materialButtonProductOpen.Tag = productsDT.Rows[i][0].ToString();
                                materialButtonProductOpen.Click += new EventHandler(buttonOpenProduct_Click);
                                materialButtonProductOpen.Cursor = Cursors.Hand;
                                // 
                                // materialButtonProductDelete
                                // 
                                materialButtonProductDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                                materialButtonProductDelete.AutoSize = false;
                                materialButtonProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                                materialButtonProductDelete.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                                materialButtonProductDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                                materialButtonProductDelete.Depth = 0;
                                materialButtonProductDelete.HighEmphasis = true;
                                materialButtonProductDelete.Icon = null;
                                materialButtonProductDelete.Location = new System.Drawing.Point(594, 47);
                                materialButtonProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                                materialButtonProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
                                materialButtonProductDelete.Name = "materialButtonProductDelete";
                                materialButtonProductDelete.NoAccentTextColor = System.Drawing.Color.Empty;
                                materialButtonProductDelete.Size = new System.Drawing.Size(107, 31);
                                materialButtonProductDelete.TabIndex = 5;
                                materialButtonProductDelete.Text = "Удалить";
                                materialButtonProductDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
                                materialButtonProductDelete.UseAccentColor = false;
                                materialButtonProductDelete.UseVisualStyleBackColor = true;
                                materialButtonProductDelete.Tag = productsDT.Rows[i][0].ToString();
                                materialButtonProductDelete.Click += new EventHandler(buttonDeleteProduct_Click);
                                materialButtonProductDelete.Cursor = Cursors.Hand;
                                // 
                                // pictureBoxProductPic
                                // 
                                pictureBoxProductPic.Location = new System.Drawing.Point(3, 3);
                                pictureBoxProductPic.Name = "pictureBoxProductPic";
                                pictureBoxProductPic.Size = new System.Drawing.Size(64, 64);
                                pictureBoxProductPic.TabIndex = 0;
                                pictureBoxProductPic.TabStop = false;
                                pictureBoxProductPic.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBoxProductPic.BackColor = Color.White;

                                flowLayoutPanelProducts.Controls.Add(materialCardProduct);

                                try
                                {
                                    Connection.OpenConnection();

                                    MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + (int)productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);
                                    System.Data.DataTable matcher_query = new System.Data.DataTable();
                                    msda2.Fill(matcher_query);
                                    Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);
                                    pictureBoxProductPic.Image = picture;
                                }
                                catch
                                {
                                }

                                MySqlCommand com = new MySqlCommand($"SELECT Name FROM Products WHERE `Code product` = {(int)productsDT.Rows[i][0]}", Connection.con);
                                materialLabelProductName.Text = (string)com.ExecuteScalar();
                            }
                        }
                    }
                }
                else
                {
                    loseCount++;
                }
            }
            //if (loseCount == productsDT.Rows.Count)
            //{
            //    if (materialTextBoxFind.Text != "")
            //    {
            //        BlackOutForm6 bfrm = new BlackOutForm6(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Поиск", "Объявлений не найдено", 1, this);
            //        bfrm.ShowDialog();
            //        //ShowMessageBox("Поиск", "Объявлений не найдено", 1);
            //        //ShowMessageBox("Поиск", "Объявлений не найдено", 1);
            //        //MessageBox.Show("Объявлений не найдено", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}

        }

        private void materialButtonCancelFind_Click(object sender, EventArgs e)
        {
            UpdateProducts();
            materialButtonCancelFind.Visible = false;
            materialTextBoxFind.Text = "";
        }

        private void materialButtonFind2_Click(object sender, EventArgs e)
        {
            DataTable profilesDT = new DataTable();
            Connection.OpenConnection();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Users` WHERE `Code user` <> " + Account.id, Connection.con);
            msda.Fill(profilesDT);
            Connection.CloseConnection();

            int loseCount = 0;
            DataTable profilesDTNormal = new DataTable();
            if (materialTextBoxFind2.Text == "")
            {
                UpdateProfiles();
                materialButtonCancelFind2.Visible = false;
            }
            for (int j = 0; j < profilesDT.Rows.Count; j++)
            {
                profilesDT.Rows[j][1] = profilesDT.Rows[j][1].ToString().ToLower();
                bool result = Regex.IsMatch(Convert.ToString(profilesDT.Rows[j][1]), "\\b" + materialTextBoxFind2.Text.ToString().ToLower() + "\\b");

                if (result == true)
                {
                    profilesDT.Clear();
                    Connection.OpenConnection();

                    MySqlDataAdapter msdaaa = new MySqlDataAdapter("SELECT * FROM `Users`", Connection.con);

                    msdaaa.Fill(profilesDT);
                    msdaaa.Fill(profilesDTNormal);

                    Connection.CloseConnection();

                    flowLayoutPanelProfiles.Controls.Clear();
                    profilesDT.Rows[j][1] = profilesDT.Rows[j][1].ToString().ToLower();

                    if (materialTextBoxFind2.Text != "")
                    {
                        materialButtonCancelFind2.Visible = true;
                    }

                    for (int i = 0; i < profilesDT.Rows.Count; i++)
                    {
                        if (Convert.ToString(profilesDT.Rows[i][1]).Contains(materialTextBoxFind2.Text.ToLower()))
                        {
                            MaterialCard materialCardProduct = new MaterialSkin.Controls.MaterialCard();
                            MaterialCard materialCardProductPic = new MaterialSkin.Controls.MaterialCard();
                            MaterialLabel materialLabelProductName = new MaterialSkin.Controls.MaterialLabel();
                            MaterialButton materialButtonProductOpen = new MaterialSkin.Controls.MaterialButton();
                            MaterialButton materialButtonProductDelete = new MaterialSkin.Controls.MaterialButton();
                            PictureBox pictureBoxProductPic = new System.Windows.Forms.PictureBox();
                            // 
                            // materialCardProduct
                            // 
                            materialCardProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            materialCardProduct.Controls.Add(materialButtonProductDelete);
                            materialCardProduct.Controls.Add(materialButtonProductOpen);
                            materialCardProduct.Controls.Add(materialLabelProductName);
                            materialCardProduct.Controls.Add(materialCardProductPic);
                            materialCardProduct.Depth = 0;
                            materialCardProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                            materialCardProduct.Location = new System.Drawing.Point(471, 14);
                            materialCardProduct.Margin = new System.Windows.Forms.Padding(14);
                            materialCardProduct.MouseState = MaterialSkin.MouseState.HOVER;
                            materialCardProduct.Name = "materialCardProfile";
                            materialCardProduct.Padding = new System.Windows.Forms.Padding(14);
                            materialCardProduct.Size = new System.Drawing.Size(719, 87);
                            materialCardProduct.TabIndex = 1;
                            // 
                            // materialCardProductPic
                            // 
                            materialCardProductPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            materialCardProductPic.Controls.Add(pictureBoxProductPic);
                            materialCardProductPic.Depth = 0;
                            materialCardProductPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                            materialCardProductPic.Location = new System.Drawing.Point(8, 8);
                            materialCardProductPic.Margin = new System.Windows.Forms.Padding(14);
                            materialCardProductPic.MouseState = MaterialSkin.MouseState.HOVER;
                            materialCardProductPic.Name = "materialCardProfilePic";
                            materialCardProductPic.Padding = new System.Windows.Forms.Padding(14);
                            materialCardProductPic.Size = new System.Drawing.Size(70, 70);
                            materialCardProductPic.TabIndex = 2;
                            // 
                            // materialLabelProductName
                            // 
                            materialLabelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                            materialLabelProductName.AutoEllipsis = true;
                            materialLabelProductName.Depth = 0;
                            materialLabelProductName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                            materialLabelProductName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                            materialLabelProductName.Location = new System.Drawing.Point(95, 31);
                            materialLabelProductName.MouseState = MaterialSkin.MouseState.HOVER;
                            materialLabelProductName.Name = "materialLabelProfileName";
                            materialLabelProductName.Size = new System.Drawing.Size(479, 23);
                            materialLabelProductName.TabIndex = 3;
                            materialLabelProductName.Text = "Пипидастр";
                            // 
                            // materialButtonProductOpen
                            // 
                            materialButtonProductOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                            materialButtonProductOpen.AutoSize = false;
                            materialButtonProductOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                            materialButtonProductOpen.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                            materialButtonProductOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                            materialButtonProductOpen.Depth = 0;
                            materialButtonProductOpen.HighEmphasis = true;
                            materialButtonProductOpen.Icon = null;
                            materialButtonProductOpen.Location = new System.Drawing.Point(594, 8);
                            materialButtonProductOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                            materialButtonProductOpen.MouseState = MaterialSkin.MouseState.HOVER;
                            materialButtonProductOpen.Name = "materialButtonProfileOpen";
                            materialButtonProductOpen.NoAccentTextColor = System.Drawing.Color.Empty;
                            materialButtonProductOpen.Size = new System.Drawing.Size(107, 31);
                            materialButtonProductOpen.TabIndex = 4;
                            materialButtonProductOpen.Text = "Заблокировать";
                            materialButtonProductOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                            materialButtonProductOpen.UseAccentColor = false;
                            materialButtonProductOpen.UseVisualStyleBackColor = true;
                            materialButtonProductOpen.Tag = profilesDT.Rows[i][0].ToString();
                            materialButtonProductOpen.Click += new EventHandler(buttonBlockUser_Click);
                            materialButtonProductOpen.Cursor = Cursors.Hand;
                            // 
                            // materialButtonProductDelete
                            // 
                            materialButtonProductDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                            materialButtonProductDelete.AutoSize = false;
                            materialButtonProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                            materialButtonProductDelete.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                            materialButtonProductDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                            materialButtonProductDelete.Depth = 0;
                            materialButtonProductDelete.HighEmphasis = true;
                            materialButtonProductDelete.Icon = null;
                            materialButtonProductDelete.Location = new System.Drawing.Point(594, 47);
                            materialButtonProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                            materialButtonProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
                            materialButtonProductDelete.Name = "materialButtonProfileDelete";
                            materialButtonProductDelete.NoAccentTextColor = System.Drawing.Color.Empty;
                            materialButtonProductDelete.Size = new System.Drawing.Size(107, 31);
                            materialButtonProductDelete.TabIndex = 5;
                            materialButtonProductDelete.Text = "Удалить";
                            materialButtonProductDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
                            materialButtonProductDelete.UseAccentColor = false;
                            materialButtonProductDelete.UseVisualStyleBackColor = true;
                            materialButtonProductDelete.Tag = profilesDT.Rows[i][0].ToString();
                            materialButtonProductDelete.Click += new EventHandler(buttonDeleteProfile_Click);
                            materialButtonProductDelete.Cursor = Cursors.Hand;
                            // 
                            // pictureBoxProductPic
                            // 
                            pictureBoxProductPic.Location = new System.Drawing.Point(3, 3);
                            pictureBoxProductPic.Name = "pictureBoxProfilePic";
                            pictureBoxProductPic.Size = new System.Drawing.Size(64, 64);
                            pictureBoxProductPic.TabIndex = 0;
                            pictureBoxProductPic.TabStop = false;
                            pictureBoxProductPic.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBoxProductPic.BackColor = Color.White;

                            flowLayoutPanelProfiles.Controls.Add(materialCardProduct);

                            if (profilesDT.Rows[i][6].ToString() == "True")
                            {
                                materialButtonProductOpen.Text = "Разблок.";
                                materialButtonProductOpen.Click += new EventHandler(buttonUnblockUser_Click);
                                materialButtonProductOpen.Click -= new EventHandler(buttonBlockUser_Click);
                            }

                            try
                            {
                                Connection.OpenConnection();

                                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Profile pictures` WHERE `Code user` = " + (int)profilesDT.Rows[i][0], Connection.con);
                                DataTable matcher_query = new DataTable();
                                msda2.Fill(matcher_query);
                                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);
                                pictureBoxProductPic.Image = picture;
                            }
                            catch
                            {
                            }

                            MySqlCommand com = new MySqlCommand($"SELECT Name FROM Users WHERE `Code user` = {(int)profilesDT.Rows[i][0]}", Connection.con);
                            materialLabelProductName.Text = (string)com.ExecuteScalar();
                        }
                    }
                }
                else
                {
                    loseCount++;
                }
            }
        }

        private void materialButtonCancelFind2_Click(object sender, EventArgs e)
        {
            UpdateProfiles();
            materialButtonCancelFind2.Visible = false;
            materialTextBoxFind2.Text = "";
        }

        private void materialComboBoxCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            System.Data.DataTable productsDT = new System.Data.DataTable();
            Connection.OpenConnection();
            MySqlDataAdapter msdaa = new MySqlDataAdapter("SELECT * FROM `Products` WHERE `Selled` = false", Connection.con);
            msdaa.Fill(productsDT);
            Connection.CloseConnection();

            if (materialComboBoxCity.Text != "Все города")
            {
                productsDT.Clear();
                Connection.OpenConnection();

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Products`", Connection.con);

                msda.Fill(productsDT);

                Connection.CloseConnection();

                flowLayoutPanelProducts.Controls.Clear();
                for (int i = 0; i < productsDT.Rows.Count; i++)
                {
                    if (Convert.ToString(productsDT.Rows[i][8]) == materialComboBoxCity.Text)
                    {
                        if ((bool)productsDT.Rows[i][10] != true)
                        {
                            MaterialCard materialCardProduct = new MaterialSkin.Controls.MaterialCard();
                            MaterialCard materialCardProductPic = new MaterialSkin.Controls.MaterialCard();
                            MaterialLabel materialLabelProductName = new MaterialSkin.Controls.MaterialLabel();
                            MaterialButton materialButtonProductOpen = new MaterialSkin.Controls.MaterialButton();
                            MaterialButton materialButtonProductDelete = new MaterialSkin.Controls.MaterialButton();
                            PictureBox pictureBoxProductPic = new System.Windows.Forms.PictureBox();
                            // 
                            // materialCardProduct
                            // 
                            materialCardProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            materialCardProduct.Controls.Add(materialButtonProductDelete);
                            materialCardProduct.Controls.Add(materialButtonProductOpen);
                            materialCardProduct.Controls.Add(materialLabelProductName);
                            materialCardProduct.Controls.Add(materialCardProductPic);
                            materialCardProduct.Depth = 0;
                            materialCardProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                            materialCardProduct.Location = new System.Drawing.Point(471, 14);
                            materialCardProduct.Margin = new System.Windows.Forms.Padding(14);
                            materialCardProduct.MouseState = MaterialSkin.MouseState.HOVER;
                            materialCardProduct.Name = "materialCardProduct";
                            materialCardProduct.Padding = new System.Windows.Forms.Padding(14);
                            materialCardProduct.Size = new System.Drawing.Size(719, 87);
                            materialCardProduct.TabIndex = 1;
                            // 
                            // materialCardProductPic
                            // 
                            materialCardProductPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            materialCardProductPic.Controls.Add(pictureBoxProductPic);
                            materialCardProductPic.Depth = 0;
                            materialCardProductPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                            materialCardProductPic.Location = new System.Drawing.Point(8, 8);
                            materialCardProductPic.Margin = new System.Windows.Forms.Padding(14);
                            materialCardProductPic.MouseState = MaterialSkin.MouseState.HOVER;
                            materialCardProductPic.Name = "materialCardProductPic";
                            materialCardProductPic.Padding = new System.Windows.Forms.Padding(14);
                            materialCardProductPic.Size = new System.Drawing.Size(70, 70);
                            materialCardProductPic.TabIndex = 2;
                            // 
                            // materialLabelProductName
                            // 
                            materialLabelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                            materialLabelProductName.AutoEllipsis = true;
                            materialLabelProductName.Depth = 0;
                            materialLabelProductName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                            materialLabelProductName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                            materialLabelProductName.Location = new System.Drawing.Point(95, 31);
                            materialLabelProductName.MouseState = MaterialSkin.MouseState.HOVER;
                            materialLabelProductName.Name = "materialLabelProductName";
                            materialLabelProductName.Size = new System.Drawing.Size(479, 23);
                            materialLabelProductName.TabIndex = 3;
                            materialLabelProductName.Text = "Пипидастр";
                            // 
                            // materialButtonProductOpen
                            // 
                            materialButtonProductOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                            materialButtonProductOpen.AutoSize = false;
                            materialButtonProductOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                            materialButtonProductOpen.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                            materialButtonProductOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                            materialButtonProductOpen.Depth = 0;
                            materialButtonProductOpen.HighEmphasis = true;
                            materialButtonProductOpen.Icon = null;
                            materialButtonProductOpen.Location = new System.Drawing.Point(594, 8);
                            materialButtonProductOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                            materialButtonProductOpen.MouseState = MaterialSkin.MouseState.HOVER;
                            materialButtonProductOpen.Name = "materialButtonProductOpen";
                            materialButtonProductOpen.NoAccentTextColor = System.Drawing.Color.Empty;
                            materialButtonProductOpen.Size = new System.Drawing.Size(107, 31);
                            materialButtonProductOpen.TabIndex = 4;
                            materialButtonProductOpen.Text = "Перейти";
                            materialButtonProductOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                            materialButtonProductOpen.UseAccentColor = false;
                            materialButtonProductOpen.UseVisualStyleBackColor = true;
                            materialButtonProductOpen.Tag = productsDT.Rows[i][0].ToString();
                            materialButtonProductOpen.Click += new EventHandler(buttonOpenProduct_Click);
                            materialButtonProductOpen.Cursor = Cursors.Hand;
                            // 
                            // materialButtonProductDelete
                            // 
                            materialButtonProductDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                            materialButtonProductDelete.AutoSize = false;
                            materialButtonProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                            materialButtonProductDelete.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                            materialButtonProductDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                            materialButtonProductDelete.Depth = 0;
                            materialButtonProductDelete.HighEmphasis = true;
                            materialButtonProductDelete.Icon = null;
                            materialButtonProductDelete.Location = new System.Drawing.Point(594, 47);
                            materialButtonProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                            materialButtonProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
                            materialButtonProductDelete.Name = "materialButtonProductDelete";
                            materialButtonProductDelete.NoAccentTextColor = System.Drawing.Color.Empty;
                            materialButtonProductDelete.Size = new System.Drawing.Size(107, 31);
                            materialButtonProductDelete.TabIndex = 5;
                            materialButtonProductDelete.Text = "Удалить";
                            materialButtonProductDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
                            materialButtonProductDelete.UseAccentColor = false;
                            materialButtonProductDelete.UseVisualStyleBackColor = true;
                            materialButtonProductDelete.Tag = productsDT.Rows[i][0].ToString();
                            materialButtonProductDelete.Click += new EventHandler(buttonDeleteProduct_Click);
                            materialButtonProductDelete.Cursor = Cursors.Hand;
                            // 
                            // pictureBoxProductPic
                            // 
                            pictureBoxProductPic.Location = new System.Drawing.Point(3, 3);
                            pictureBoxProductPic.Name = "pictureBoxProductPic";
                            pictureBoxProductPic.Size = new System.Drawing.Size(64, 64);
                            pictureBoxProductPic.TabIndex = 0;
                            pictureBoxProductPic.TabStop = false;
                            pictureBoxProductPic.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBoxProductPic.BackColor = Color.White;

                            flowLayoutPanelProducts.Controls.Add(materialCardProduct);

                            try
                            {
                                Connection.OpenConnection();

                                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + (int)productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);
                                System.Data.DataTable matcher_query = new System.Data.DataTable();
                                msda2.Fill(matcher_query);
                                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);
                                pictureBoxProductPic.Image = picture;
                            }
                            catch
                            {
                            }

                            MySqlCommand com = new MySqlCommand($"SELECT Name FROM Products WHERE `Code product` = {(int)productsDT.Rows[i][0]}", Connection.con);
                            materialLabelProductName.Text = (string)com.ExecuteScalar();
                        }
                    }
                }
            }
            else
            {
                UpdateProducts();

            }
        }

        private void materialComboBoxCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            System.Data.DataTable productsDT = new System.Data.DataTable();
            Connection.OpenConnection();
            MySqlDataAdapter msdaa = new MySqlDataAdapter("SELECT * FROM `Products` WHERE `Selled` = false", Connection.con);
            msdaa.Fill(productsDT);
            Connection.CloseConnection();

            if (materialComboBoxCategories.Text != "Все категории")
            {
                productsDT.Clear();
                Connection.OpenConnection();

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Products`", Connection.con);

                msda.Fill(productsDT);

                Connection.CloseConnection();

                flowLayoutPanelProducts.Controls.Clear();
                for (int i = 0; i < productsDT.Rows.Count; i++)
                {
                    if (Convert.ToString(productsDT.Rows[i][2]) == materialComboBoxCategories.Text)
                    {
                        if ((bool)productsDT.Rows[i][10] != true)
                        {
                            MaterialCard materialCardProduct = new MaterialSkin.Controls.MaterialCard();
                            MaterialCard materialCardProductPic = new MaterialSkin.Controls.MaterialCard();
                            MaterialLabel materialLabelProductName = new MaterialSkin.Controls.MaterialLabel();
                            MaterialButton materialButtonProductOpen = new MaterialSkin.Controls.MaterialButton();
                            MaterialButton materialButtonProductDelete = new MaterialSkin.Controls.MaterialButton();
                            PictureBox pictureBoxProductPic = new System.Windows.Forms.PictureBox();
                            // 
                            // materialCardProduct
                            // 
                            materialCardProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            materialCardProduct.Controls.Add(materialButtonProductDelete);
                            materialCardProduct.Controls.Add(materialButtonProductOpen);
                            materialCardProduct.Controls.Add(materialLabelProductName);
                            materialCardProduct.Controls.Add(materialCardProductPic);
                            materialCardProduct.Depth = 0;
                            materialCardProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                            materialCardProduct.Location = new System.Drawing.Point(471, 14);
                            materialCardProduct.Margin = new System.Windows.Forms.Padding(14);
                            materialCardProduct.MouseState = MaterialSkin.MouseState.HOVER;
                            materialCardProduct.Name = "materialCardProduct";
                            materialCardProduct.Padding = new System.Windows.Forms.Padding(14);
                            materialCardProduct.Size = new System.Drawing.Size(719, 87);
                            materialCardProduct.TabIndex = 1;
                            // 
                            // materialCardProductPic
                            // 
                            materialCardProductPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            materialCardProductPic.Controls.Add(pictureBoxProductPic);
                            materialCardProductPic.Depth = 0;
                            materialCardProductPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                            materialCardProductPic.Location = new System.Drawing.Point(8, 8);
                            materialCardProductPic.Margin = new System.Windows.Forms.Padding(14);
                            materialCardProductPic.MouseState = MaterialSkin.MouseState.HOVER;
                            materialCardProductPic.Name = "materialCardProductPic";
                            materialCardProductPic.Padding = new System.Windows.Forms.Padding(14);
                            materialCardProductPic.Size = new System.Drawing.Size(70, 70);
                            materialCardProductPic.TabIndex = 2;
                            // 
                            // materialLabelProductName
                            // 
                            materialLabelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                            materialLabelProductName.AutoEllipsis = true;
                            materialLabelProductName.Depth = 0;
                            materialLabelProductName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                            materialLabelProductName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                            materialLabelProductName.Location = new System.Drawing.Point(95, 31);
                            materialLabelProductName.MouseState = MaterialSkin.MouseState.HOVER;
                            materialLabelProductName.Name = "materialLabelProductName";
                            materialLabelProductName.Size = new System.Drawing.Size(479, 23);
                            materialLabelProductName.TabIndex = 3;
                            materialLabelProductName.Text = "Пипидастр";
                            // 
                            // materialButtonProductOpen
                            // 
                            materialButtonProductOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                            materialButtonProductOpen.AutoSize = false;
                            materialButtonProductOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                            materialButtonProductOpen.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                            materialButtonProductOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                            materialButtonProductOpen.Depth = 0;
                            materialButtonProductOpen.HighEmphasis = true;
                            materialButtonProductOpen.Icon = null;
                            materialButtonProductOpen.Location = new System.Drawing.Point(594, 8);
                            materialButtonProductOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                            materialButtonProductOpen.MouseState = MaterialSkin.MouseState.HOVER;
                            materialButtonProductOpen.Name = "materialButtonProductOpen";
                            materialButtonProductOpen.NoAccentTextColor = System.Drawing.Color.Empty;
                            materialButtonProductOpen.Size = new System.Drawing.Size(107, 31);
                            materialButtonProductOpen.TabIndex = 4;
                            materialButtonProductOpen.Text = "Перейти";
                            materialButtonProductOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                            materialButtonProductOpen.UseAccentColor = false;
                            materialButtonProductOpen.UseVisualStyleBackColor = true;
                            materialButtonProductOpen.Tag = productsDT.Rows[i][0].ToString();
                            materialButtonProductOpen.Click += new EventHandler(buttonOpenProduct_Click);
                            materialButtonProductOpen.Cursor = Cursors.Hand;
                            // 
                            // materialButtonProductDelete
                            // 
                            materialButtonProductDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                            materialButtonProductDelete.AutoSize = false;
                            materialButtonProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                            materialButtonProductDelete.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                            materialButtonProductDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                            materialButtonProductDelete.Depth = 0;
                            materialButtonProductDelete.HighEmphasis = true;
                            materialButtonProductDelete.Icon = null;
                            materialButtonProductDelete.Location = new System.Drawing.Point(594, 47);
                            materialButtonProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                            materialButtonProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
                            materialButtonProductDelete.Name = "materialButtonProductDelete";
                            materialButtonProductDelete.NoAccentTextColor = System.Drawing.Color.Empty;
                            materialButtonProductDelete.Size = new System.Drawing.Size(107, 31);
                            materialButtonProductDelete.TabIndex = 5;
                            materialButtonProductDelete.Text = "Удалить";
                            materialButtonProductDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
                            materialButtonProductDelete.UseAccentColor = false;
                            materialButtonProductDelete.UseVisualStyleBackColor = true;
                            materialButtonProductDelete.Tag = productsDT.Rows[i][0].ToString();
                            materialButtonProductDelete.Click += new EventHandler(buttonDeleteProduct_Click);
                            materialButtonProductDelete.Cursor = Cursors.Hand;
                            // 
                            // pictureBoxProductPic
                            // 
                            pictureBoxProductPic.Location = new System.Drawing.Point(3, 3);
                            pictureBoxProductPic.Name = "pictureBoxProductPic";
                            pictureBoxProductPic.Size = new System.Drawing.Size(64, 64);
                            pictureBoxProductPic.TabIndex = 0;
                            pictureBoxProductPic.TabStop = false;
                            pictureBoxProductPic.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBoxProductPic.BackColor = Color.White;

                            flowLayoutPanelProducts.Controls.Add(materialCardProduct);

                            try
                            {
                                Connection.OpenConnection();

                                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + (int)productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);
                                System.Data.DataTable matcher_query = new System.Data.DataTable();
                                msda2.Fill(matcher_query);
                                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);
                                pictureBoxProductPic.Image = picture;
                            }
                            catch
                            {
                            }

                            MySqlCommand com = new MySqlCommand($"SELECT Name FROM Products WHERE `Code product` = {(int)productsDT.Rows[i][0]}", Connection.con);
                            materialLabelProductName.Text = (string)com.ExecuteScalar();
                        }
                    }
                }
            }
            else
            {
                UpdateProducts();

            }
        }

        private void materialButtonLogin_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP = materialTextBoxIP.Text;
            Properties.Settings.Default.Username = materialTextBoxLoginServer.Text;
            Properties.Settings.Default.Password = materialTextBoxPassServer.Text;
            Properties.Settings.Default.Database = materialTextBoxDatabase.Text;
            Properties.Settings.Default.Save();

            FormMessageBox frm = new FormMessageBox("Настройки", "Конфигурация сервера изменена, перезапустите приложение", 1);
            frm.ShowDialog();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AdminLogin = materialTextBoxLoginAdmin.Text;
            Properties.Settings.Default.AdminPassword = materialTextBoxPasswordAdmin.Text;
            Properties.Settings.Default.Save();

            Connection.OpenConnection();

            MySqlCommand com = new MySqlCommand($"UPDATE `Users` SET `Login` = '{materialTextBoxLoginAdmin.Text}', `Password` = '{materialTextBoxPasswordAdmin.Text}' WHERE `IsAdmin` = 1",Connection.con);
            com.ExecuteNonQuery();

            Connection.CloseConnection();

            FormMessageBox frm = new FormMessageBox("Настройки", "Конфигурация аккаунта изменена, перезапустите приложение", 1);
            frm.ShowDialog();
        }
    }
}