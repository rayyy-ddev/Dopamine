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

namespace Dopamine
{
    public partial class FormMessengers : MaterialForm
    {
        FormAddMessenger formAddMessenger;
        FormChangeMessenger formChangeMessenger;

        public DataTable messengersDT = new DataTable();
        public FormMessengers()
        {
            InitializeComponent();
            Opacity = 0;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.7d) == 1) timer.Stop();
            });
            timer.Interval = 100;
            timer.Start();
            UpdateRows();
        }

        public void UpdateRows()
        {
            
            if (Account.hasAccount == true)
            {
                messengersDT.Clear();
            }
            
            Connection.OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM `Messenger` WHERE `Code user` = {Account.id}", Connection.con);
            da.Fill(messengersDT);
            Connection.CloseConnection();


            flowLayoutPanelMessengers.Controls.Clear();

            for (int i = 0; i < messengersDT.Rows.Count; i++)
            {
                MaterialCard materialCardRaw;
                MaterialButton materialButtonDelete;
                MaterialButton materialButtonEdit;
                MaterialLabel materialLabelLink;
                MaterialLabel materialLabelMessenger;

                materialCardRaw = new MaterialSkin.Controls.MaterialCard();
                materialLabelMessenger = new MaterialSkin.Controls.MaterialLabel();
                materialLabelLink = new MaterialSkin.Controls.MaterialLabel();
                materialButtonEdit = new MaterialSkin.Controls.MaterialButton();
                materialButtonDelete = new MaterialSkin.Controls.MaterialButton();

                // 
                // materialCardRaw
                // 
                materialCardRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCardRaw.Controls.Add(materialButtonDelete);
                materialCardRaw.Controls.Add(materialButtonEdit);
                materialCardRaw.Controls.Add(materialLabelLink);
                materialCardRaw.Controls.Add(materialLabelMessenger);
                materialCardRaw.Depth = 0;
                materialCardRaw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCardRaw.Location = new System.Drawing.Point(510, 0);
                materialCardRaw.Margin = new System.Windows.Forms.Padding(14);
                materialCardRaw.MouseState = MaterialSkin.MouseState.HOVER;
                materialCardRaw.Name = "materialCardRaw";
                materialCardRaw.Padding = new System.Windows.Forms.Padding(14);
                materialCardRaw.Size = new System.Drawing.Size(456, 46);
                materialCardRaw.TabIndex = 15;
                // 
                // materialLabelMessenger
                // 
                materialLabelMessenger.AutoSize = true;
                materialLabelMessenger.Depth = 0;
                materialLabelMessenger.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                materialLabelMessenger.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
                materialLabelMessenger.Location = new System.Drawing.Point(11, 14);
                materialLabelMessenger.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabelMessenger.Name = "materialLabelMessenger";
                materialLabelMessenger.Size = new System.Drawing.Size(106, 17);
                materialLabelMessenger.TabIndex = 0;
                materialLabelMessenger.Text = messengersDT.Rows[i][1].ToString();
                // 
                // materialLabelLink
                // 
                materialLabelLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                materialLabelLink.AutoEllipsis = true;
                materialLabelLink.Depth = 0;
                materialLabelLink.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                materialLabelLink.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
                materialLabelLink.Location = new System.Drawing.Point(146, 14);
                materialLabelLink.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabelLink.Name = "materialLabelLink";
                materialLabelLink.Size = new System.Drawing.Size(185, 17);
                materialLabelLink.TabIndex = 1;
                materialLabelLink.Text = messengersDT.Rows[i][2].ToString();
                materialLabelLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // materialButtonEdit
                // 
                materialButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                materialButtonEdit.AutoSize = false;
                materialButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonEdit.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
                materialButtonEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonEdit.Depth = 0;
                materialButtonEdit.HighEmphasis = true;
                materialButtonEdit.Icon = global::Dopamine.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
                materialButtonEdit.Location = new System.Drawing.Point(356, 5);
                materialButtonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonEdit.Name = "materialButtonEdit";
                materialButtonEdit.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonEdit.Size = new System.Drawing.Size(39, 34);
                materialButtonEdit.TabIndex = 17;
                materialButtonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                materialButtonEdit.UseAccentColor = false;
                materialButtonEdit.UseVisualStyleBackColor = true;
                materialButtonEdit.Click += new EventHandler(buttonChange_Click);
                // 
                // materialButtonDelete
                // 
                materialButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                materialButtonDelete.AutoSize = false;
                materialButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonDelete.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
                materialButtonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonDelete.Depth = 0;
                materialButtonDelete.HighEmphasis = true;
                materialButtonDelete.Icon = global::Dopamine.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
                materialButtonDelete.Location = new System.Drawing.Point(403, 5);
                materialButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonDelete.Name = "materialButtonDelete";
                materialButtonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonDelete.Size = new System.Drawing.Size(39, 34);
                materialButtonDelete.TabIndex = 18;
                materialButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                materialButtonDelete.UseAccentColor = false;
                materialButtonDelete.UseVisualStyleBackColor = true;
                materialButtonDelete.Click += new EventHandler(buttonDelete_Click);

                flowLayoutPanelMessengers.Controls.Add(materialCardRaw);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BlackOutForm3 bfrm = new BlackOutForm3(this.Width, this.Height, this.Location.X, this.Location.Y, "add", "Ошибка", "Пользователь с таким логином уже существует", 1, this);
            bfrm.ShowDialog();
            //FormAddMessenger frm = new FormAddMessenger(this);
            //frm.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            object tag = ((Button)sender).Tag;
            messengersDT.Rows[Convert.ToInt32(tag)].Delete();
            UpdateRows();
            //if (Height >= 155 && Height < 385)
            //{
            //    Height -= 77;
            //}
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            object tag = ((Button)sender).Tag;

            BlackOutForm4 bfrm = new BlackOutForm4(this.Width, this.Height, this.Location.X, this.Location.Y, "change", "Ошибка", "Пользователь с таким логином уже существует", 1, this, Convert.ToInt32(tag));
            bfrm.ShowDialog();
            //if (formChangeMessenger == null)
            //{
            //    formChangeMessenger = new FormChangeMessenger(this);
            //}
            //formChangeMessenger.Start(Convert.ToInt32(tag));
            //formChangeMessenger.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Account.messengersDT = messengersDT;
            Close();
        }

        private void FormMessengers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Account.messengersDT = messengersDT;
        }
    }
}
