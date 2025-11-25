using Dopamine.Properties;
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
using Microsoft.Win32;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlTypes;

using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.Runtime.InteropServices;
using System.Windows;
using System.Threading;
using System.Windows.Media;
using System.Text.RegularExpressions;
using System.Drawing.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Media.Media3D;
using MaterialSkin.Controls;
using MaterialSkin;
using MaterialSkin.Properties;
using System.Windows.Interop;

namespace Dopamine
{
    public partial class FormMain : MaterialForm
    {
        DataTable productsDT = new DataTable();
        FormAuth formAuth;

        Bitmap bmp;

        public FormMain()
            : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            panelPopUp.Dock = DockStyle.Fill;

            this.Size = new System.Drawing.Size(1, 1);
            //Opacity = 0;
            //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            //timer.Tick += new EventHandler((sender, e) =>
            //{
            //    if ((Opacity += 0.5d) == 1) timer.Stop();
            //});
            //timer.Interval = 100;
            //timer.Start();
        }


        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
        //        return cp;
        //    }
        //}

        private void SetWhiteColor(ToolStripMenuItem item)
        {
            item.ForeColor = System.Drawing.Color.White;
            foreach (ToolStripMenuItem it in item.DropDownItems)
            {
                SetWhiteColor(it);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelPopUp.Visible = true;
            timer1.Enabled = true;

            UpdateProducts();

            if(Account.name == "(Гость) (Сервер не найден)")
            {
                this.Text = "Dopamine (Гость) (Сервер не найден)";
            }

            Connection.OpenConnection();
            if(Properties.Settings.Default.Login != "")
            {
                Account.hasAccount = true;

                MySqlCommand com2 = new MySqlCommand($"SELECT `Name` FROM `Users` WHERE `Login` = '{Properties.Settings.Default.Login}'", Connection.con);
                MySqlCommand com3 = new MySqlCommand($"SELECT `Code user` FROM `Users` WHERE `Login` = '{Properties.Settings.Default.Login}'", Connection.con);
                Account.name = Convert.ToString(com2.ExecuteScalar());
                Account.id = Convert.ToInt32(com3.ExecuteScalar());

                Login();
            }

            Connection.CloseConnection();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Account.hasAccount = false;
                this.Text = "Dopamine (Гость)";


            }


        }

        void ShowMessageBox(string title, string desc, int btnCount)
        {
            // take a screenshot of the form and darken it:


            // put the darkened screenshot into a Panel and bring it to the front:
            using (Panel p = new Panel())
            {
                //p.Location = new System.Drawing.Point(0, 0);
                //p.Size = this.ClientRectangle.Size;
                //p.BackgroundImage = bmp;
                //this.Controls.Add(p);
                //p.BringToFront();

                // display your dialog somehow:
                Form frm = new FormMessageBox("Поиск", "Объявлений не найдено", 1);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
            } // panel will be disposed and the form will "lighten" again..
        }

        public void Login()
        {

            this.Text = $"Dopamine ({Account.name})";


            Connection.OpenConnection();

            try
            {
                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Profile pictures` WHERE `Code user` = " + Account.id, Connection.con);

                DataTable matcher_query = new DataTable();

                msda2.Fill(matcher_query);

                Connection.CloseConnection();

                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                //picture = new Bitmap(picture, new System.Drawing.Size(40,40));

                //входИРегистрацияToolStripMenuItem.Image = picture;
                pictureBoxMyPicture.Image = picture;


            }
            catch
            {
            }

            labelMyUserName.Text = Account.name;

            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            byte[] image_bytes = File.ReadAllBytes(openFileDialog1.FileName);
            Connection.OpenConnection();
            MySqlCommand com = new MySqlCommand(@"INSERT INTO Pictures(`Picture`, `IsPreview`, `Code product`) VALUES (@ImageData, 1, 4)", Connection.con);
            com.Parameters.Add("@ImageData", MySqlDbType.VarBinary, 1000000);
            com.Parameters["@ImageData"].Value = image_bytes;
            com.ExecuteNonQuery();
            Connection.CloseConnection();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productCard_CursorChanged(object sender, EventArgs e)
        {
        }

        private void productCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productCard_Click(object sender, EventArgs e)
        {
            object tag = ((MaterialCard)sender).Tag;

            bool isNoRepeat = true;

            Connection.OpenConnection();

            MySqlCommand comName = new MySqlCommand("SELECT `Name` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
            string name = Convert.ToString(comName.ExecuteScalar());

            Connection.CloseConnection();

            for (int i = 0; i < materialTabControl1.TabPages.Count; i++)
            {
                if (materialTabControl1.TabPages[i].Text == name)
                {
                    isNoRepeat = false;
                    CreateTabProduct(Convert.ToInt32(tag));
                    materialTabControl1.SelectedIndex = i;
                }
            }

            if (isNoRepeat == true)
            {
                if (materialTabControl1.TabPages.Count >= 10)
                {
                    materialTabControl1.TabPages.RemoveAt(5);
                }
                CreateTabProduct(Convert.ToInt32(tag));
                materialTabControl1.SelectedIndex = Convert.ToInt32(materialTabControl1.TabCount) - 1;
            }
        }

        private void labelName_Hover(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = System.Drawing.Color.PaleVioletRed;

        }

        private void labelName_Click(object sender, EventArgs e)
        {
            object tag = ((Label)sender).Tag;

            bool isNoRepeat = true;

            Connection.OpenConnection();

            MySqlCommand comName = new MySqlCommand("SELECT `Name` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
            string name = Convert.ToString(comName.ExecuteScalar());

            Connection.CloseConnection();

            for (int i = 0; i < materialTabControl1.TabPages.Count; i++)
            {
                if (materialTabControl1.TabPages[i].Text == name)
                {
                    isNoRepeat = false;
                    CreateTabProduct(Convert.ToInt32(tag));
                    materialTabControl1.SelectedIndex = i;
                }
            }

            if (isNoRepeat == true)
            {
                if (materialTabControl1.TabPages.Count >= 10)
                {
                    materialTabControl1.TabPages.RemoveAt(5);
                }
                CreateTabProduct(Convert.ToInt32(tag));
                materialTabControl1.SelectedIndex = Convert.ToInt32(materialTabControl1.TabCount) - 1;
            }

        }

        private void pictureProduct_Click(object sender, EventArgs e)
        {
            object tag = ((PictureBox)sender).Tag;

            bool isNoRepeat = true;

            Connection.OpenConnection();

            MySqlCommand comName = new MySqlCommand("SELECT `Name` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
            string name = Convert.ToString(comName.ExecuteScalar());

            Connection.CloseConnection();

            for (int i = 0; i < materialTabControl1.TabPages.Count; i++)
            {
                if (materialTabControl1.TabPages[i].Text == name)
                {
                    isNoRepeat = false;
                    CreateTabProduct(Convert.ToInt32(tag));
                    materialTabControl1.SelectedIndex = i;
                }
            }

            if (isNoRepeat == true)
            {
                if (materialTabControl1.TabPages.Count >= 10)
                {
                    materialTabControl1.TabPages.RemoveAt(5);
                }
                CreateTabProduct(Convert.ToInt32(tag));
                materialTabControl1.SelectedIndex = Convert.ToInt32(materialTabControl1.TabCount) - 1;
            }

        }

        private void labelName_Leave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = System.Drawing.Color.DodgerBlue;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); // создаем диалоговое окно
            openFileDialog1.ShowDialog(); // показываем
            byte[] image_bytes = File.ReadAllBytes(openFileDialog1.FileName); // получаем байты выбранного файла
            Connection.OpenConnection();
            MySqlCommand com = new MySqlCommand(@"INSERT INTO `Profile pictures`(`Picture`, `Code user`) VALUES (@ImageData, 1)", Connection.con);
            com.Parameters.Add("@ImageData", MySqlDbType.VarBinary, 1000000);
            com.Parameters["@ImageData"].Value = image_bytes;// скалярной переменной ImageData присвоем массив байтов
            com.ExecuteNonQuery();
            Connection.CloseConnection();
        }

        private void comboBoxCity_SelectionChangeCommitted(object sender, EventArgs e)
        {



        }

        private void comboBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBoxCity_TextUpdate(object sender, EventArgs e)
        {

        }

        private void productCard_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).Size = new System.Drawing.Size(((MaterialCard)sender).Size.Width + 5, ((MaterialCard)sender).Size.Height + 5);
        }

        private void productCard_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).Size = new System.Drawing.Size(((MaterialCard)sender).Size.Width - 5, ((MaterialCard)sender).Size.Height - 5);
        }

        void UpdateProducts()
        {
            productsDT.Clear();
            Connection.OpenConnection();

            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Products`", Connection.con);

            try
            {
                msda.Fill(productsDT);
            }
            catch
            {

            }

            Connection.CloseConnection();

            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < productsDT.Rows.Count; i++)
            {
                if ((bool)productsDT.Rows[i][10] != true)
                {
                    PictureBox productPicture;
                    Label labelProductName;
                    Label labelCost;
                    Label labelLocation;
                    Label labelDate;
                    MaterialCard productCard;

                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
                    productPicture = new PictureBox();
                    labelProductName = new Label();
                    labelCost = new Label();
                    labelLocation = new Label();
                    labelDate = new Label();
                    productCard = new MaterialCard();

                    // 
                    // productPicture
                    //
                    try
                    {
                        Connection.OpenConnection();

                        MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);

                        DataTable matcher_query = new DataTable();

                        msda2.Fill(matcher_query);

                        Connection.CloseConnection();

                        Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                        productPicture.Image = picture;
                    }
                    catch
                    {
                        productPicture.Image = ((System.Drawing.Image)(resources.GetObject("productPicture.Image")));

                    }

                    productPicture.Location = new System.Drawing.Point(3, 3);
                    productPicture.Name = "productPicture";
                    productPicture.Size = new System.Drawing.Size(150, 110);
                    productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    productPicture.TabIndex = 0;
                    productPicture.BackColor = System.Drawing.Color.White;
                    
                    productPicture.TabStop = false;
                    productPicture.Tag = productsDT.Rows[i][0];
                    productPicture.Cursor = System.Windows.Forms.Cursors.Hand;
                    productPicture.Click += new EventHandler(pictureProduct_Click);

                    // 
                    // labelProductName
                    // 
                    labelProductName.AutoEllipsis = true;
                    labelProductName.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    labelProductName.ForeColor = System.Drawing.Color.DodgerBlue;
                    labelProductName.Location = new System.Drawing.Point(3, 116);
                    labelProductName.Name = "labelProductName";
                    labelProductName.Size = new System.Drawing.Size(161, 18);
                    labelProductName.TabIndex = 2;
                    labelProductName.Text = productsDT.Rows[i][3].ToString();
                    //labelProductName.MouseEnter += new EventHandler(labelName_Hover);
                    //labelProductName.MouseLeave += new EventHandler(labelName_Leave);
                    labelProductName.Click += new EventHandler(labelName_Click);
                    labelProductName.Cursor = System.Windows.Forms.Cursors.Hand;
                    labelProductName.Tag = productsDT.Rows[i][0];

                    // 
                    // labelCost
                    // 
                    labelCost.AutoEllipsis = true;
                    labelCost.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    labelCost.Location = new System.Drawing.Point(3, 140);
                    labelCost.Name = "labelCost";
                    labelCost.Size = new System.Drawing.Size(161, 18);
                    labelCost.TabIndex = 3;
                    labelCost.Text = productsDT.Rows[i][6].ToString() + " ₽";
                    // 
                    // labelLocation
                    // 
                    labelLocation.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    labelLocation.ForeColor = System.Drawing.Color.DimGray;
                    labelLocation.Location = new System.Drawing.Point(3, 167);
                    labelLocation.Name = "labelLocation";
                    labelLocation.Size = new System.Drawing.Size(156, 19);
                    labelLocation.TabIndex = 4;
                    labelLocation.Text = productsDT.Rows[i][8].ToString() + " " + productsDT.Rows[i][7].ToString();
                    // 
                    // labelDate
                    // 
                    labelDate.AutoSize = true;
                    labelDate.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    labelDate.ForeColor = System.Drawing.Color.DimGray;
                    labelDate.Location = new System.Drawing.Point(3, 185);
                    labelDate.Name = "labelDate";
                    labelDate.Size = new System.Drawing.Size(34, 13);
                    labelDate.TabIndex = 5;
                    labelDate.Text = productsDT.Rows[i][9].ToString();
                    // 
                    // productCard
                    // 
                    productCard.Controls.Add(labelDate);
                    productCard.Controls.Add(labelLocation);
                    productCard.Controls.Add(labelCost);
                    productCard.Controls.Add(labelProductName);
                    productCard.Controls.Add(productPicture);
                    productCard.Location = new System.Drawing.Point(511, 182);
                    productCard.Name = "productCard";
                    productCard.Size = new System.Drawing.Size(156, 210);
                    productCard.TabIndex = 1;
                    productCard.Visible = true;
                    productCard.Cursor = Cursors.Hand;
                    productCard.Click += new EventHandler(productCard_Click);
                    productCard.Tag = productsDT.Rows[i][0];




                    flowLayoutPanel1.Controls.Add(productCard);
                }
                //flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1].Tag = flowLayoutPanel1.Controls.Count - 1;
                //flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1].MouseEnter += new EventHandler(productCard_MouseEnter);
                //flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1].MouseLeave += new EventHandler(productCard_MouseLeave);
            }
        }

        private void comboBoxCity_TextChanged(object sender, EventArgs e)
        {
            if (materialComboBoxCity.Text != "Все города")
            {
                productsDT.Clear();
                Connection.OpenConnection();

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Products`", Connection.con);

                msda.Fill(productsDT);

                Connection.CloseConnection();

                flowLayoutPanel1.Controls.Clear();
                for (int i = 0; i < productsDT.Rows.Count; i++)
                {
                    if (Convert.ToString(productsDT.Rows[i][8]) == materialComboBoxCity.Text)
                    {
                        if ((bool)productsDT.Rows[i][10] != true)
                        {
                            PictureBox productPicture;
                            Label labelProductName;
                            Label labelCost;
                            Label labelLocation;
                            Label labelDate;
                            MaterialCard productCard;

                            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
                            productPicture = new PictureBox();
                            labelProductName = new Label();
                            labelCost = new Label();
                            labelLocation = new Label();
                            labelDate = new Label();
                            productCard = new MaterialCard();

                            // 
                            // productPicture
                            //
                            try
                            {
                                Connection.OpenConnection();

                                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);

                                DataTable matcher_query = new DataTable();

                                msda2.Fill(matcher_query);

                                Connection.CloseConnection();

                                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                                productPicture.Image = picture;
                            }
                            catch
                            {
                                productPicture.Image = ((System.Drawing.Image)(resources.GetObject("productPicture.Image")));

                            }

                            productPicture.Location = new System.Drawing.Point(3, 3);
                            productPicture.Name = "productPicture";
                            productPicture.Size = new System.Drawing.Size(150, 110);
                            productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                            productPicture.TabIndex = 0;
                            productPicture.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
                            productPicture.TabStop = false;
                            productPicture.Tag = productsDT.Rows[i][0];
                            productPicture.Cursor = System.Windows.Forms.Cursors.Hand;
                            productPicture.Click += new EventHandler(pictureProduct_Click);

                            // 
                            // labelProductName
                            // 
                            labelProductName.AutoEllipsis = true;
                            labelProductName.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelProductName.ForeColor = System.Drawing.Color.DodgerBlue;
                            labelProductName.Location = new System.Drawing.Point(3, 116);
                            labelProductName.Name = "labelProductName";
                            labelProductName.Size = new System.Drawing.Size(161, 18);
                            labelProductName.TabIndex = 2;
                            labelProductName.Text = productsDT.Rows[i][3].ToString();
                            //labelProductName.MouseEnter += new EventHandler(labelName_Hover);
                            //labelProductName.MouseLeave += new EventHandler(labelName_Leave);
                            labelProductName.Click += new EventHandler(labelName_Click);
                            labelProductName.Cursor = System.Windows.Forms.Cursors.Hand;
                            labelProductName.Tag = productsDT.Rows[i][0];

                            // 
                            // labelCost
                            // 
                            labelCost.AutoEllipsis = true;
                            labelCost.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelCost.Location = new System.Drawing.Point(3, 140);
                            labelCost.Name = "labelCost";
                            labelCost.Size = new System.Drawing.Size(161, 18);
                            labelCost.TabIndex = 3;
                            labelCost.Text = productsDT.Rows[i][6].ToString() + " ₽";
                            // 
                            // labelLocation
                            // 
                            labelLocation.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            labelLocation.ForeColor = System.Drawing.Color.DimGray;
                            labelLocation.Location = new System.Drawing.Point(3, 167);
                            labelLocation.Name = "labelLocation";
                            labelLocation.Size = new System.Drawing.Size(160, 19);
                            labelLocation.TabIndex = 4;
                            labelLocation.Text = productsDT.Rows[i][8].ToString() + " " + productsDT.Rows[i][7].ToString();
                            // 
                            // labelDate
                            // 
                            labelDate.AutoSize = true;
                            labelDate.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            labelDate.ForeColor = System.Drawing.Color.DimGray;
                            labelDate.Location = new System.Drawing.Point(3, 185);
                            labelDate.Name = "labelDate";
                            labelDate.Size = new System.Drawing.Size(34, 13);
                            labelDate.TabIndex = 5;
                            labelDate.Text = productsDT.Rows[i][9].ToString();
                            // 
                            // productCard
                            // 
                            productCard.Controls.Add(labelDate);
                            productCard.Controls.Add(labelLocation);
                            productCard.Controls.Add(labelCost);
                            productCard.Controls.Add(labelProductName);
                            productCard.Controls.Add(productPicture);
                            productCard.Location = new System.Drawing.Point(511, 182);
                            productCard.Name = "productCard";
                            productCard.Size = new System.Drawing.Size(156, 210);
                            productCard.TabIndex = 1;
                            productCard.Visible = true;
                            productCard.Cursor = Cursors.Hand;
                            productCard.Click += new EventHandler(productCard_Click);
                            productCard.Tag = productsDT.Rows[i][0];


                            flowLayoutPanel1.Controls.Add(productCard);
                        }
                    }
                }
            }
            else
            {
                UpdateProducts();

            }
        }

        private void linkLabelSearch_Click(object sender, EventArgs e)
        {
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

                    flowLayoutPanel1.Controls.Clear();
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
                                PictureBox productPicture;
                                Label labelProductName;
                                Label labelCost;
                                Label labelLocation;
                                Label labelDate;
                                MaterialCard productCard;

                                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
                                productPicture = new PictureBox();
                                labelProductName = new Label();
                                labelCost = new Label();
                                labelLocation = new Label();
                                labelDate = new Label();
                                productCard = new MaterialCard();

                                // 
                                // productPicture
                                //
                                try
                                {
                                    Connection.OpenConnection();

                                    MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);

                                    DataTable matcher_query = new DataTable();

                                    msda2.Fill(matcher_query);

                                    Connection.CloseConnection();

                                    Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                                    productPicture.Image = picture;
                                }
                                catch
                                {
                                    productPicture.Image = ((System.Drawing.Image)(resources.GetObject("productPicture.Image")));

                                }

                                productPicture.Location = new System.Drawing.Point(3, 3);
                                productPicture.Name = "productPicture";
                                productPicture.Size = new System.Drawing.Size(150, 110);
                                productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                                productPicture.TabIndex = 0;
                                productPicture.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
                                productPicture.TabStop = false;
                                productPicture.Tag = productsDT.Rows[i][0];
                                productPicture.Cursor = System.Windows.Forms.Cursors.Hand;
                                productPicture.Click += new EventHandler(pictureProduct_Click);

                                // 
                                // labelProductName
                                // 
                                labelProductName.AutoEllipsis = true;
                                labelProductName.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                labelProductName.ForeColor = System.Drawing.Color.DodgerBlue;
                                labelProductName.Location = new System.Drawing.Point(3, 116);
                                labelProductName.Name = "labelProductName";
                                labelProductName.Size = new System.Drawing.Size(161, 18);
                                labelProductName.TabIndex = 2;
                                labelProductName.Text = productsDTNormal.Rows[i][3].ToString();
                                //labelProductName.MouseEnter += new EventHandler(labelName_Hover);
                                //labelProductName.MouseLeave += new EventHandler(labelName_Leave);
                                labelProductName.Click += new EventHandler(labelName_Click);
                                labelProductName.Cursor = System.Windows.Forms.Cursors.Hand;
                                labelProductName.Tag = productsDT.Rows[i][0];

                                // 
                                // labelCost
                                // 
                                labelCost.AutoEllipsis = true;
                                labelCost.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                labelCost.Location = new System.Drawing.Point(3, 140);
                                labelCost.Name = "labelCost";
                                labelCost.Size = new System.Drawing.Size(161, 18);
                                labelCost.TabIndex = 3;
                                labelCost.Text = productsDT.Rows[i][6].ToString() + " ₽";
                                // 
                                // labelLocation
                                // 
                                labelLocation.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                labelLocation.ForeColor = System.Drawing.Color.DimGray;
                                labelLocation.Location = new System.Drawing.Point(3, 167);
                                labelLocation.Name = "labelLocation";
                                labelLocation.Size = new System.Drawing.Size(160, 19);
                                labelLocation.TabIndex = 4;
                                labelLocation.Text = productsDT.Rows[i][8].ToString() + " " + productsDT.Rows[i][7].ToString();
                                // 
                                // labelDate
                                // 
                                labelDate.AutoSize = true;
                                labelDate.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                labelDate.ForeColor = System.Drawing.Color.DimGray;
                                labelDate.Location = new System.Drawing.Point(3, 185);
                                labelDate.Name = "labelDate";
                                labelDate.Size = new System.Drawing.Size(34, 13);
                                labelDate.TabIndex = 5;
                                labelDate.Text = productsDT.Rows[i][9].ToString();
                                // 
                                // productCard
                                // 
                                productCard.Controls.Add(labelDate);
                                productCard.Controls.Add(labelLocation);
                                productCard.Controls.Add(labelCost);
                                productCard.Controls.Add(labelProductName);
                                productCard.Controls.Add(productPicture);
                                productCard.Location = new System.Drawing.Point(511, 182);
                                productCard.Name = "productCard";
                                productCard.Size = new System.Drawing.Size(156, 210);
                                productCard.TabIndex = 1;
                                productCard.Visible = true;
                                productCard.Cursor = Cursors.Hand;
                                productCard.Click += new EventHandler(productCard_Click);
                                productCard.Tag = productsDT.Rows[i][0];


                                flowLayoutPanel1.Controls.Add(productCard);
                            }
                        }

                    }
                }
                else
                {
                    loseCount++;
                }
            }

            if (loseCount == productsDT.Rows.Count)
            {
                if (materialTextBoxFind.Text != "")
                {
                    BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Поиск", "Объявлений не найдено", 1, this);
                    bfrm.ShowDialog();
                    //ShowMessageBox("Поиск", "Объявлений не найдено", 1);
                    //ShowMessageBox("Поиск", "Объявлений не найдено", 1);
                    //MessageBox.Show("Объявлений не найдено", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void входИРегистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Account.hasAccount == false)
            {
                if (formAuth == null || formAuth.IsDisposed == true)
                {
                    formAuth = new FormAuth(this);
                }

                formAuth.Show();
            }

        }

        private void входИРегистрацияToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void входИРегистрацияToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = System.Drawing.Color.FromArgb(237, 65, 52);
            Cursor = Cursors.Hand;
        }

        private void входИРегистрацияToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = System.Drawing.Color.White;
            Cursor = Cursors.Default;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void корзинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Войдите, для просмотра корзины", "Вход", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                if (Account.hasAccount == false)
                {
                    if (formAuth == null || formAuth.IsDisposed == true)
                    {
                        formAuth = new FormAuth(this);
                    }

                    formAuth.Show();
                }
            }


        }

        private void разместитьОбъявлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Войдите, для размещения объявления", "Вход", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                if (Account.hasAccount == false)
                {
                    if (formAuth == null || formAuth.IsDisposed == true)
                    {
                        formAuth = new FormAuth(this);
                    }

                    formAuth.Show();
                }
            }
        }

        public void CreateTabProduct(int tag)
        {

            bool isNoRepeat = true;

            Connection.OpenConnection();

            MySqlCommand comName = new MySqlCommand("SELECT `Name` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
            string name = Convert.ToString(comName.ExecuteScalar());

            Connection.CloseConnection();

            for (int i = 0; i < materialTabControl1.TabPages.Count; i++)
            {
                if (materialTabControl1.TabPages[i].Text == name)
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
                materialCardPictures.Location = new System.Drawing.Point(20, 464);
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
                tabPageProduct.Controls.Add(materialButtonShowPhone);
                tabPageProduct.Controls.Add(label2);
                tabPageProduct.Controls.Add(labelStatus);
                tabPageProduct.Controls.Add(label3);
                tabPageProduct.Controls.Add(label4);
                tabPageProduct.Controls.Add(labelUserName);
                tabPageProduct.Controls.Add(labelProductCost);
                tabPageProduct.Controls.Add(labelProductName);
                tabPageProduct.Controls.Add(labelCategory);
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
                labelCategory.Text = "Status";
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
                labelUserName.MouseEnter += new EventHandler(labelUserName_MouseEnter);
                labelUserName.MouseLeave += new EventHandler(labelUserName_MouseLeave);
                labelUserName.Click += new EventHandler(labelUserName_Click);
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
                materialButtonShowPhone.Click += new EventHandler(buttonShowPhone_click);

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
                materialButtonConnect.Location = new System.Drawing.Point(736, 200);
                materialButtonConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonConnect.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonConnect.Name = "materialButtonConnect";
                materialButtonConnect.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonConnect.Size = new System.Drawing.Size(210, 47);
                materialButtonConnect.TabIndex = 39;
                materialButtonConnect.Text = "Связаться с продавцом";
                materialButtonConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
                materialButtonConnect.UseAccentColor = false;
                materialButtonConnect.UseVisualStyleBackColor = true;
                materialButtonConnect.Click += new EventHandler(buttonConnect_click);

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
                materialCardPicturePreview.Location = new System.Drawing.Point(20, 181);
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
                materialButtonSellProduct.Click += new EventHandler(buttonAddToCart_Click);
                

                tabPageProduct.Controls.Add(materialButtonSellProduct);

                materialButtonSellProduct.Location = new System.Drawing.Point(733, 200);
                materialButtonShowPhone.Location = new System.Drawing.Point(733, 140);
                materialButtonConnect.Location = new System.Drawing.Point(733, 260);
                label2.Location = new System.Drawing.Point(733, 320);
                labelUserName.Location = new System.Drawing.Point(733, 347);

                materialTabControl1.TabPages.Add(tabPageProduct);

                tabPageProduct.Enter += new EventHandler(tabPageHome_Enter);

                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand("SELECT `Name` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                MySqlCommand com2 = new MySqlCommand("SELECT `Status` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                MySqlCommand com22 = new MySqlCommand("SELECT `Category` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
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
                MySqlCommand com11 = new MySqlCommand("SELECT `Date sell` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
                tabPageProduct.Text = Convert.ToString(com.ExecuteScalar());
                labelProductName.Text = Convert.ToString(com.ExecuteScalar());
                labelStatus.Text = Convert.ToString(com2.ExecuteScalar());
                labelCategory.Text = Convert.ToString(com22.ExecuteScalar());
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

                materialButtonShowPhone.Tag = Convert.ToInt32(com4.ExecuteScalar());
                materialButtonConnect.Tag = Convert.ToInt32(com4.ExecuteScalar());

                

                if (Convert.ToInt32(com4.ExecuteScalar()) == Account.id)
                {
                    materialButtonConnect.Text = "Удалить объявление";
                    materialButtonShowPhone.Text = "Редактировать объявление";
                    labelUserName.Click -= new EventHandler(labelUserName_Click);
                    labelUserName.Click += new EventHandler(buttonMyUserName_Click);
                    materialButtonConnect.Click -= new EventHandler(buttonConnect_click);
                    materialButtonShowPhone.Click -= new EventHandler(buttonShowPhone_click);
                    materialButtonConnect.Click += new EventHandler(myProductDelete);
                    materialButtonConnect.Tag = tag;
                    materialButtonShowPhone.Click += new EventHandler(changeMyProduct);
                    materialButtonShowPhone.Tag = tag;
                    materialButtonSellProduct.Text = "Отметить как проданный";
                    labelUserName.Text = Convert.ToString(com5.ExecuteScalar()) + " (Вы)";
                    materialButtonSellProduct.Click -= new EventHandler(buttonAddToCart_Click);
                    materialButtonSellProduct.Click += new EventHandler(buttonSell_Click);

                    if ((bool)com10.ExecuteScalar() == true)
                    {
                        materialButtonSellProduct.Text = "Опубликовать заново";
                        materialButtonSellProduct.Click -= new EventHandler(buttonSell_Click);
                        labelProductName.Text = Convert.ToString(com.ExecuteScalar()) + $" (Продан {Convert.ToString(com11.ExecuteScalar())})";
                        materialButtonSellProduct.Click += new EventHandler(buttonUnsell_Click);
                    }


                }
                else
                {
                    if(Account.hasAccount == true)
                    {
                        DataTable carts = new DataTable();

                        MySqlDataAdapter msda2 = new MySqlDataAdapter($"SELECT * FROM Carts WHERE `Code user` = {Account.id}", Connection.con);

                        msda2.Fill(carts);

                        for(int i = 0; i < carts.Rows.Count; i++)
                        {
                            if ((int)carts.Rows[i][1] == tag)
                            {
                                materialButtonSellProduct.Enabled = false;
                            }
                        }

                        if ((bool)com10.ExecuteScalar() == true)
                        {
                            labelProductName.Text = Convert.ToString(com.ExecuteScalar()) + $" (Продан {Convert.ToString(com11.ExecuteScalar())})";
                            materialButtonShowPhone.Enabled = false;
                            materialButtonConnect.Enabled = false;

                        }
                    }
                    
                }

                
            }


        }

        private void buttonUnsell_Click(object sender, EventArgs e)
        {
            int tag = (int)((MaterialButton)sender).Tag;

            BlackOutForm bfrm2 = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Продажа", "Опубликовать объявление заново?", 2, this);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand($"UPDATE Products SET Selled = {false} WHERE `Code product` = {tag}", Connection.con);
                com.ExecuteNonQuery();

                Connection.CloseConnection();

                UpdateProducts();
                int index = 0;

                if (materialTabControl1.SelectedIndex != materialTabControl1.TabPages.Count - 1)
                {
                    index = materialTabControl1.SelectedIndex;
                }
                else if (materialTabControl1.SelectedIndex == materialTabControl1.TabPages.Count - 1 && materialTabControl1.TabPages.Count != 6)
                {
                    index = materialTabControl1.SelectedIndex - 1;
                }
                else if (materialTabControl1.SelectedIndex == materialTabControl1.TabPages.Count - 1 && materialTabControl1.TabPages.Count == 6)
                {
                    index = 0;
                }

                materialTabControl1.TabPages.Remove((TabPage)((MaterialButton)sender).Parent);

                CreateTabProduct(tag);

                materialTabControl1.SelectedIndex = materialTabControl1.Controls.Count - 1;
            }
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            int tag = (int)((MaterialButton)sender).Tag;

            BlackOutForm bfrm2 = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Продажа", "Пометить товар как проданный?", 2, this);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand($"UPDATE Products SET Selled = {true} WHERE `Code product` = {tag}", Connection.con);
                MySqlCommand com2 = new MySqlCommand($"UPDATE Products SET `Date sell` = '{DateTime.Now.ToShortDateString()}' WHERE `Code product` = {tag}", Connection.con);
                com.ExecuteNonQuery();
                com2.ExecuteNonQuery();

                Connection.CloseConnection();

                UpdateProducts();
                int index = 0;

                if (materialTabControl1.SelectedIndex != materialTabControl1.TabPages.Count - 1)
                {
                    index = materialTabControl1.SelectedIndex;
                }
                else if (materialTabControl1.SelectedIndex == materialTabControl1.TabPages.Count - 1 && materialTabControl1.TabPages.Count != 6)
                {
                    index = materialTabControl1.SelectedIndex - 1;
                }
                else if (materialTabControl1.SelectedIndex == materialTabControl1.TabPages.Count - 1 && materialTabControl1.TabPages.Count == 6)
                {
                    index = 0;
                }

                materialTabControl1.TabPages.Remove((TabPage)((MaterialButton)sender).Parent);

                CreateTabProduct(tag);

                materialTabControl1.SelectedIndex = materialTabControl1.Controls.Count -1;
            }
        }

            private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            int tag = (int)((MaterialButton)sender).Tag;

            if(Account.hasAccount == false)
            {
                BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "auth", "Поиск", "Объявлений не найдено", 1, this);
                bfrm.ShowDialog();
            }
            else
            {
                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand($"INSERT INTO Carts (`Code product`, `Code user`) VALUES ({tag}, {Account.id})", Connection.con);
                com.ExecuteNonQuery();

                BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Избранные", "Товар добавлен в избранные", 1, this);
                bfrm.ShowDialog();

                Connection.CloseConnection();
            }
        }

        private void materialCardInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUserName_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = System.Drawing.Color.PaleVioletRed;
        }

        private void labelUserName_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = System.Drawing.Color.Black;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            panelPopUp.Visible = true;
            timer1.Enabled = true;
            int index = 0;

            if (materialTabControl1.SelectedIndex != materialTabControl1.TabPages.Count - 1)
            {
                index = materialTabControl1.SelectedIndex;
            }
            else if (materialTabControl1.SelectedIndex == materialTabControl1.TabPages.Count - 1 && materialTabControl1.TabPages.Count != 6)
            {
                index = materialTabControl1.SelectedIndex - 1;
            }
            else if (materialTabControl1.SelectedIndex == materialTabControl1.TabPages.Count - 1 && materialTabControl1.TabPages.Count == 6)
            {
                index = 0;
            }

            materialTabControl1.TabPages.Remove((TabPage)((MaterialFloatingActionButton)sender).Parent);


            materialTabControl1.SelectedIndex = index;



        }

        private void labelUserName_Click(object sender, EventArgs e)
        {
            panelPopUp.Visible = true;
            timer1.Enabled = true;
            object tag = ((Label)sender).Tag;

            bool isNoRepeat = true;

            Connection.OpenConnection();

            MySqlCommand comName = new MySqlCommand("SELECT `Name` FROM `Users` WHERE `Code user` = " + tag, Connection.con);
            string name = Convert.ToString(comName.ExecuteScalar());

            Connection.CloseConnection();

            for (int i = 0; i < materialTabControl1.TabPages.Count; i++)
            {
                if (materialTabControl1.TabPages[i].Text == name)
                {
                    isNoRepeat = false;
                    CreateTabSeller(Convert.ToInt32(tag));
                    materialTabControl1.SelectedIndex = i;
                }
            }

            if (isNoRepeat == true)
            {
                if (materialTabControl1.TabPages.Count >= 10)
                {
                    materialTabControl1.TabPages.RemoveAt(5);
                }
                CreateTabSeller(Convert.ToInt32(tag));
                materialTabControl1.SelectedIndex = Convert.ToInt32(materialTabControl1.TabCount) - 1;
            }
        }

        void CreateTabSeller(int tag)
        {


            bool isNoRepeat = true;

            Connection.OpenConnection();

            MySqlCommand comName = new MySqlCommand("SELECT `Name` FROM `Users` WHERE `Code user` = " + tag, Connection.con);
            string name = Convert.ToString(comName.ExecuteScalar());

            Connection.CloseConnection();

            for (int i = 0; i < materialTabControl1.TabPages.Count; i++)
            {
                if (materialTabControl1.TabPages[i].Text == name)
                {
                    isNoRepeat = false;
                }
            }

            if (isNoRepeat == true)
            {

                System.Windows.Forms.TabPage tabPageSeller;
                MaterialSkin.Controls.MaterialCard materialCardSellerPicture;
                System.Windows.Forms.PictureBox pictureBoxSellerPicture;
                MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButtonClose2;
                System.Windows.Forms.Label labelSellerName;
                MaterialSkin.Controls.MaterialButton materialButtonConnect2;
                MaterialSkin.Controls.MaterialButton materialButtonShowPhone2;
                System.Windows.Forms.Label labelSellersProducts;
                CustomFlowLayoutPanel flowLayoutPanelSellersProducts;

                tabPageSeller = new System.Windows.Forms.TabPage();
                materialCardSellerPicture = new MaterialSkin.Controls.MaterialCard();
                pictureBoxSellerPicture = new System.Windows.Forms.PictureBox();
                materialFloatingActionButtonClose2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
                labelSellerName = new System.Windows.Forms.Label();
                materialButtonConnect2 = new MaterialSkin.Controls.MaterialButton();
                materialButtonShowPhone2 = new MaterialSkin.Controls.MaterialButton();
                labelSellersProducts = new System.Windows.Forms.Label();
                flowLayoutPanelSellersProducts = new CustomFlowLayoutPanel();

                // 
                // tabPageSeller
                // 
                tabPageSeller.BackColor = System.Drawing.SystemColors.Control;
                tabPageSeller.Controls.Add(flowLayoutPanelSellersProducts);
                tabPageSeller.Controls.Add(labelSellersProducts);
                tabPageSeller.Controls.Add(materialButtonConnect2);
                tabPageSeller.Controls.Add(materialButtonShowPhone2);
                tabPageSeller.Controls.Add(labelSellerName);
                tabPageSeller.Controls.Add(materialFloatingActionButtonClose2);
                tabPageSeller.Controls.Add(materialCardSellerPicture);
                tabPageSeller.Location = new System.Drawing.Point(4, 31);
                tabPageSeller.Name = "tabPageSeller";
                tabPageSeller.Padding = new System.Windows.Forms.Padding(3);
                tabPageSeller.Size = new System.Drawing.Size(1117, 611);
                tabPageSeller.TabIndex = 6;
                tabPageSeller.Text = "UserName";
                // 
                // materialCardSellerPicture
                // 
                materialCardSellerPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCardSellerPicture.Controls.Add(pictureBoxSellerPicture);
                materialCardSellerPicture.Depth = 0;
                materialCardSellerPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCardSellerPicture.Location = new System.Drawing.Point(20, 53);
                materialCardSellerPicture.Margin = new System.Windows.Forms.Padding(14);
                materialCardSellerPicture.MouseState = MaterialSkin.MouseState.HOVER;
                materialCardSellerPicture.Name = "materialCardSellerPicture";
                materialCardSellerPicture.Padding = new System.Windows.Forms.Padding(14);
                materialCardSellerPicture.Size = new System.Drawing.Size(255, 255);
                materialCardSellerPicture.TabIndex = 43;
                // 
                // pictureBoxSellerPicture
                // 
                pictureBoxSellerPicture.BackColor = System.Drawing.Color.White;
                pictureBoxSellerPicture.Location = new System.Drawing.Point(3, 3);
                pictureBoxSellerPicture.Name = "pictureBoxSellerPicture";
                pictureBoxSellerPicture.Size = new System.Drawing.Size(249, 249);
                pictureBoxSellerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxSellerPicture.TabIndex = 27;
                pictureBoxSellerPicture.TabStop = false;
                // 
                // materialFloatingActionButtonClose2
                // 
                materialFloatingActionButtonClose2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                materialFloatingActionButtonClose2.Depth = 0;
                materialFloatingActionButtonClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                materialFloatingActionButtonClose2.Icon = global::Dopamine.Properties.Resources.icons8_close_48__1_;
                materialFloatingActionButtonClose2.ImageKey = "(отсутствует)";
                materialFloatingActionButtonClose2.Location = new System.Drawing.Point(1074, 3);
                materialFloatingActionButtonClose2.Mini = true;
                materialFloatingActionButtonClose2.MouseState = MaterialSkin.MouseState.HOVER;
                materialFloatingActionButtonClose2.Name = "materialFloatingActionButtonClose2";
                materialFloatingActionButtonClose2.Size = new System.Drawing.Size(40, 40);
                materialFloatingActionButtonClose2.TabIndex = 44;
                materialFloatingActionButtonClose2.Text = "Закрыть";
                materialFloatingActionButtonClose2.UseVisualStyleBackColor = true;
                materialFloatingActionButtonClose2.Cursor = Cursors.Hand;
                materialFloatingActionButtonClose2.Click += new EventHandler(buttonClose_Click);
                // 
                // labelSellerName
                // 
                labelSellerName.AutoSize = false;
                labelSellerName.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelSellerName.Location = new System.Drawing.Point(17, 320);
                labelSellerName.Name = "labelSellerName";
                labelSellerName.Size = new System.Drawing.Size(252, 56);
                labelSellerName.TabIndex = 45;
                labelSellerName.Text = "UserName";
                labelSellerName.AutoEllipsis = true;
                // 
                // materialButtonConnect2
                // 
                materialButtonConnect2.AutoSize = false;
                materialButtonConnect2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonConnect2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonConnect2.Cursor = System.Windows.Forms.Cursors.Hand;
                materialButtonConnect2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonConnect2.Depth = 0;
                materialButtonConnect2.HighEmphasis = true;
                materialButtonConnect2.Icon = null;
                materialButtonConnect2.Location = new System.Drawing.Point(20, 432);
                materialButtonConnect2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonConnect2.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonConnect2.Name = "materialButtonConnect2";
                materialButtonConnect2.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonConnect2.Size = new System.Drawing.Size(252, 47);
                materialButtonConnect2.TabIndex = 47;
                materialButtonConnect2.Text = "Связаться с продавцом";
                materialButtonConnect2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
                materialButtonConnect2.UseAccentColor = false;
                materialButtonConnect2.UseVisualStyleBackColor = true;
                materialButtonConnect2.Click += new EventHandler(buttonConnect_click);
                materialButtonConnect2.Tag = tag;
                // 
                // materialButtonShowPhone2
                // 
                materialButtonShowPhone2.AutoSize = false;
                materialButtonShowPhone2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonShowPhone2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonShowPhone2.Cursor = System.Windows.Forms.Cursors.Hand;
                materialButtonShowPhone2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonShowPhone2.Depth = 0;
                materialButtonShowPhone2.HighEmphasis = true;
                materialButtonShowPhone2.Icon = null;
                materialButtonShowPhone2.Location = new System.Drawing.Point(20, 378);
                materialButtonShowPhone2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonShowPhone2.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonShowPhone2.Name = "materialButtonShowPhone2";
                materialButtonShowPhone2.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonShowPhone2.Size = new System.Drawing.Size(252, 47);
                materialButtonShowPhone2.TabIndex = 46;
                materialButtonShowPhone2.Text = "Показать телефон";
                materialButtonShowPhone2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                materialButtonShowPhone2.UseAccentColor = false;
                materialButtonShowPhone2.UseVisualStyleBackColor = true;
                materialButtonShowPhone2.Click += new EventHandler(buttonShowPhone_click);
                materialButtonShowPhone2.Tag = tag;
                // 
                // labelSellersProducts
                // 
                labelSellersProducts.AutoSize = true;
                labelSellersProducts.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelSellersProducts.Location = new System.Drawing.Point(305, 53);
                labelSellersProducts.Name = "labelSellersProducts";
                labelSellersProducts.Size = new System.Drawing.Size(380, 33);
                labelSellersProducts.TabIndex = 48;
                labelSellersProducts.Text = "Объявления пользователя";
                // 
                // flowLayoutPanelSellersProducts
                // 
                flowLayoutPanelSellersProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                flowLayoutPanelSellersProducts.AutoScroll = true;
                flowLayoutPanelSellersProducts.BackColor = System.Drawing.SystemColors.Control;
                flowLayoutPanelSellersProducts.Location = new System.Drawing.Point(311, 106);
                flowLayoutPanelSellersProducts.Name = "flowLayoutPanelSellersProducts";
                flowLayoutPanelSellersProducts.Size = new System.Drawing.Size(794, 481);
                flowLayoutPanelSellersProducts.TabIndex = 49;

                materialTabControl1.TabPages.Add(tabPageSeller);

                tabPageSeller.Enter += new EventHandler(tabPageHome_Enter);

                productsDT.Clear();

                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand("SELECT `Name` FROM `Users` WHERE `Code user` = " + tag, Connection.con);

                tabPageSeller.Text = Convert.ToString(com.ExecuteScalar());
                labelSellerName.Text = Convert.ToString(com.ExecuteScalar());

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Products`", Connection.con);

                msda.Fill(productsDT);

                try
                {

                    MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Profile pictures` WHERE `Code user` = " + tag, Connection.con);

                    DataTable matcher_query = new DataTable();

                    msda2.Fill(matcher_query);

                    Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                    pictureBoxSellerPicture.Image = picture;
                }
                catch
                {


                }

                for (int i = 0; i < productsDT.Rows.Count; i++)
                {
                    if (Convert.ToInt32(productsDT.Rows[i][1]) == tag)
                    {
                        if ((bool)productsDT.Rows[i][10] != true)
                        {
                            PictureBox productPicture;
                            Label labelProductName;
                            Label labelCost;
                            Label labelLocation;
                            Label labelDate;
                            MaterialCard productCard;

                            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
                            productPicture = new PictureBox();
                            labelProductName = new Label();
                            labelCost = new Label();
                            labelLocation = new Label();
                            labelDate = new Label();
                            productCard = new MaterialCard();

                            // 
                            // productPicture
                            //
                            try
                            {
                                Connection.OpenConnection();

                                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);

                                DataTable matcher_query = new DataTable();

                                msda2.Fill(matcher_query);

                                Connection.CloseConnection();

                                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                                productPicture.Image = picture;
                            }
                            catch
                            {
                                productPicture.Image = ((System.Drawing.Image)(resources.GetObject("productPicture.Image")));

                            }

                            productPicture.Location = new System.Drawing.Point(3, 3);
                            productPicture.Name = "productPicture";
                            productPicture.Size = new System.Drawing.Size(150, 110);
                            productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                            productPicture.TabIndex = 0;
                            productPicture.BackColor = System.Drawing.Color.White;
                            productPicture.TabStop = false;
                            productPicture.Tag = productsDT.Rows[i][0];
                            productPicture.Cursor = System.Windows.Forms.Cursors.Hand;
                            productPicture.Click += new EventHandler(pictureProduct_Click);

                            // 
                            // labelProductName
                            // 
                            labelProductName.AutoEllipsis = true;
                            labelProductName.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelProductName.ForeColor = System.Drawing.Color.DodgerBlue;
                            labelProductName.Location = new System.Drawing.Point(3, 116);
                            labelProductName.Name = "labelProductName";
                            labelProductName.Size = new System.Drawing.Size(161, 18);
                            labelProductName.TabIndex = 2;
                            labelProductName.Text = productsDT.Rows[i][3].ToString();
                            //labelProductName.MouseEnter += new EventHandler(labelName_Hover);
                            //labelProductName.MouseLeave += new EventHandler(labelName_Leave);
                            labelProductName.Click += new EventHandler(labelName_Click);
                            labelProductName.Cursor = System.Windows.Forms.Cursors.Hand;
                            labelProductName.Tag = productsDT.Rows[i][0];

                            // 
                            // labelCost
                            // 
                            labelCost.AutoEllipsis = true;
                            labelCost.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelCost.Location = new System.Drawing.Point(3, 140);
                            labelCost.Name = "labelCost";
                            labelCost.Size = new System.Drawing.Size(161, 18);
                            labelCost.TabIndex = 3;
                            labelCost.Text = productsDT.Rows[i][6].ToString() + " ₽";
                            // 
                            // labelLocation
                            // 
                            labelLocation.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            labelLocation.ForeColor = System.Drawing.Color.DimGray;
                            labelLocation.Location = new System.Drawing.Point(3, 167);
                            labelLocation.Name = "labelLocation";
                            labelLocation.Size = new System.Drawing.Size(156, 19);
                            labelLocation.TabIndex = 4;
                            labelLocation.Text = productsDT.Rows[i][8].ToString() + " " + productsDT.Rows[i][7].ToString();
                            // 
                            // labelDate
                            // 
                            labelDate.AutoSize = true;
                            labelDate.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            labelDate.ForeColor = System.Drawing.Color.DimGray;
                            labelDate.Location = new System.Drawing.Point(3, 185);
                            labelDate.Name = "labelDate";
                            labelDate.Size = new System.Drawing.Size(34, 13);
                            labelDate.TabIndex = 5;
                            labelDate.Text = productsDT.Rows[i][9].ToString();
                            // 
                            // productCard
                            // 
                            productCard.Controls.Add(labelDate);
                            productCard.Controls.Add(labelLocation);
                            productCard.Controls.Add(labelCost);
                            productCard.Controls.Add(labelProductName);
                            productCard.Controls.Add(productPicture);
                            productCard.Location = new System.Drawing.Point(511, 182);
                            productCard.Name = "productCard";
                            productCard.Size = new System.Drawing.Size(156, 210);
                            productCard.TabIndex = 1;
                            productCard.Visible = true;
                            productCard.Cursor = Cursors.Hand;
                            productCard.Click += new EventHandler(productCard_Click);
                            productCard.Tag = productsDT.Rows[i][0];


                            flowLayoutPanelSellersProducts.Controls.Add(productCard);
                        }
                    }
                }
            }
        }

        private void materialButtonCancelFind_Click(object sender, EventArgs e)
        {
            UpdateProducts();
            materialButtonCancelFind.Visible = false;
            materialTextBoxFind.Text = "";
        }

        private void materialTextBoxFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButtonRefresh_Click(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelPopUp.Visible = false;
            timer1.Enabled = false;
        }

        private void panelPopUp_Enter(object sender, EventArgs e)
        {
        }

        private void tabPageHome_Enter(object sender, EventArgs e)
        {
            panelPopUp.Visible = true;
            timer1.Enabled = true;
        }

        private void buttonMyUserName_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
        }

        private void tabPageProfile_Enter(object sender, EventArgs e)
        {
            if (Account.hasAccount == false)
            {
                BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "auth", "Поиск", "Объявлений не найдено", 1, this);
                bfrm.ShowDialog();
                //FormAuth frm = new FormAuth(this);
                //frm.ShowDialog();
                //panelPopUp.Visible = true;
                materialTabControl1.SelectedIndex = 0;


            }
            else
            {
                panelPopUp.Visible = true;
                timer1.Enabled = true;

                productsDT.Clear();

                Connection.OpenConnection();

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Products`", Connection.con);

                msda.Fill(productsDT);

                flowLayoutPanelMyProducts.Controls.Clear();

                for (int i = 0; i < productsDT.Rows.Count; i++)
                {
                    if (Convert.ToInt32(productsDT.Rows[i][1]) == Account.id)
                    {
                        if ((bool)productsDT.Rows[i][10] != true)
                        {
                            PictureBox productPicture;
                            Label labelProductName;
                            Label labelCost;
                            Label labelLocation;
                            Label labelDate;
                            MaterialCard productCard;

                            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
                            productPicture = new PictureBox();
                            labelProductName = new Label();
                            labelCost = new Label();
                            labelLocation = new Label();
                            labelDate = new Label();
                            productCard = new MaterialCard();

                            // 
                            // productPicture
                            //
                            try
                            {
                                Connection.OpenConnection();

                                MySqlDataAdapter msda3 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);

                                DataTable matcher_query = new DataTable();

                                msda3.Fill(matcher_query);

                                Connection.CloseConnection();

                                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                                productPicture.Image = picture;
                            }
                            catch
                            {
                                productPicture.Image = ((System.Drawing.Image)(resources.GetObject("productPicture.Image")));

                            }

                            productPicture.Location = new System.Drawing.Point(3, 3);
                            productPicture.Name = "productPicture";
                            productPicture.Size = new System.Drawing.Size(150, 110);
                            productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                            productPicture.TabIndex = 0;
                            productPicture.BackColor = System.Drawing.Color.White;
                            productPicture.TabStop = false;
                            productPicture.Tag = productsDT.Rows[i][0];
                            productPicture.Cursor = System.Windows.Forms.Cursors.Hand;
                            productPicture.Click += new EventHandler(pictureProduct_Click);

                            // 
                            // labelProductName
                            // 
                            labelProductName.AutoEllipsis = true;
                            labelProductName.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelProductName.ForeColor = System.Drawing.Color.DodgerBlue;
                            labelProductName.Location = new System.Drawing.Point(3, 116);
                            labelProductName.Name = "labelProductName";
                            labelProductName.Size = new System.Drawing.Size(161, 18);
                            labelProductName.TabIndex = 2;
                            labelProductName.Text = productsDT.Rows[i][3].ToString();
                            //labelProductName.MouseEnter += new EventHandler(labelName_Hover);
                            //labelProductName.MouseLeave += new EventHandler(labelName_Leave);
                            labelProductName.Click += new EventHandler(labelName_Click);
                            labelProductName.Cursor = System.Windows.Forms.Cursors.Hand;
                            labelProductName.Tag = productsDT.Rows[i][0];

                            // 
                            // labelCost
                            // 
                            labelCost.AutoEllipsis = true;
                            labelCost.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelCost.Location = new System.Drawing.Point(3, 140);
                            labelCost.Name = "labelCost";
                            labelCost.Size = new System.Drawing.Size(161, 18);
                            labelCost.TabIndex = 3;
                            labelCost.Text = productsDT.Rows[i][6].ToString() + " ₽";
                            // 
                            // labelLocation
                            // 
                            labelLocation.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            labelLocation.ForeColor = System.Drawing.Color.DimGray;
                            labelLocation.Location = new System.Drawing.Point(3, 167);
                            labelLocation.Name = "labelLocation";
                            labelLocation.Size = new System.Drawing.Size(156, 19);
                            labelLocation.TabIndex = 4;
                            labelLocation.Text = productsDT.Rows[i][8].ToString() + " " + productsDT.Rows[i][7].ToString();
                            // 
                            // labelDate
                            // 
                            labelDate.AutoSize = true;
                            labelDate.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            labelDate.ForeColor = System.Drawing.Color.DimGray;
                            labelDate.Location = new System.Drawing.Point(3, 185);
                            labelDate.Name = "labelDate";
                            labelDate.Size = new System.Drawing.Size(34, 13);
                            labelDate.TabIndex = 5;
                            labelDate.Text = productsDT.Rows[i][9].ToString();
                            // 
                            // productCard
                            // 
                            productCard.Controls.Add(labelDate);
                            productCard.Controls.Add(labelLocation);
                            productCard.Controls.Add(labelCost);
                            productCard.Controls.Add(labelProductName);
                            productCard.Controls.Add(productPicture);
                            productCard.Location = new System.Drawing.Point(511, 182);
                            productCard.Name = "productCard";
                            productCard.Size = new System.Drawing.Size(156, 210);
                            productCard.TabIndex = 1;
                            productCard.Visible = true;
                            productCard.Cursor = Cursors.Hand;
                            productCard.Click += new EventHandler(productCard_Click);
                            productCard.Tag = productsDT.Rows[i][0];


                            flowLayoutPanelMyProducts.Controls.Add(productCard);
                        }
                    }
                }
                DataTable selledProdDT = new DataTable();

                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT * FROM `Products`", Connection.con);

                msda.Fill(selledProdDT);

                flowLayoutPanelMyArchive.Controls.Clear();

                for (int i = 0; i < selledProdDT.Rows.Count; i++)
                {
                    if (Convert.ToInt32(selledProdDT.Rows[i][1]) == Account.id)
                    {
                        if ((bool)selledProdDT.Rows[i][10] == true)
                        {
                            MaterialSkin.Controls.MaterialCard materialCardSelledProd = new MaterialCard();
                            MaterialSkin.Controls.MaterialLabel materialLabelSelledProdName = new MaterialLabel();
                            MaterialSkin.Controls.MaterialCard materialCardSelledProdPic = new MaterialCard();
                            PictureBox pictureBoxSelledProdPic = new PictureBox();
                            // 
                            // materialCardSelledProd
                            // 
                            materialCardSelledProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            materialCardSelledProd.Controls.Add(materialLabelSelledProdName);
                            materialCardSelledProd.Controls.Add(materialCardSelledProdPic);
                            materialCardSelledProd.Depth = 0;
                            materialCardSelledProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                            materialCardSelledProd.Location = new System.Drawing.Point(714, 315);
                            materialCardSelledProd.Margin = new System.Windows.Forms.Padding(14);
                            materialCardSelledProd.MouseState = MaterialSkin.MouseState.HOVER;
                            materialCardSelledProd.Name = "materialCardSelledProd";
                            materialCardSelledProd.Padding = new System.Windows.Forms.Padding(14);
                            materialCardSelledProd.Size = new System.Drawing.Size(526, 91);
                            materialCardSelledProd.TabIndex = 57;
                            materialCardSelledProd.Cursor = Cursors.Hand;
                            materialCardSelledProd.Tag = (int)selledProdDT.Rows[i][0];
                            materialCardSelledProd.Click += new EventHandler(selledCard_Click);
                        // 
                        // materialLabelSelledProdName
                        // 
                            materialLabelSelledProdName.AutoEllipsis = true;
                            materialLabelSelledProdName.Depth = 0;
                            materialLabelSelledProdName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                            materialLabelSelledProdName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                            materialLabelSelledProdName.Location = new System.Drawing.Point(103, 33);
                            materialLabelSelledProdName.MouseState = MaterialSkin.MouseState.HOVER;
                            materialLabelSelledProdName.Name = "materialLabelSelledProdName";
                            materialLabelSelledProdName.Size = new System.Drawing.Size(393, 23);
                            materialLabelSelledProdName.TabIndex = 48;
                            materialLabelSelledProdName.Text = "ProductName";
                            // 
                            // materialCardSelledProdPic
                            // 
                            materialCardSelledProdPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            materialCardSelledProdPic.Controls.Add(pictureBoxSelledProdPic);
                            materialCardSelledProdPic.Depth = 0;
                            materialCardSelledProdPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                            materialCardSelledProdPic.Location = new System.Drawing.Point(9, 5);
                            materialCardSelledProdPic.Margin = new System.Windows.Forms.Padding(14);
                            materialCardSelledProdPic.MouseState = MaterialSkin.MouseState.HOVER;
                            materialCardSelledProdPic.Name = "materialCardSelledProdPic";
                            materialCardSelledProdPic.Padding = new System.Windows.Forms.Padding(14);
                            materialCardSelledProdPic.Size = new System.Drawing.Size(76, 76);
                            materialCardSelledProdPic.TabIndex = 47;
                            // 
                            // pictureBoxSelledProdPic
                            // 
                            pictureBoxSelledProdPic.BackColor = System.Drawing.Color.White;
                            pictureBoxSelledProdPic.Location = new System.Drawing.Point(3, 3);
                            pictureBoxSelledProdPic.Name = "pictureBoxSelledProdPic";
                            pictureBoxSelledProdPic.Size = new System.Drawing.Size(70, 70);
                            pictureBoxSelledProdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                            pictureBoxSelledProdPic.TabIndex = 27;
                            pictureBoxSelledProdPic.TabStop = false;

                            flowLayoutPanelMyArchive.Controls.Add(materialCardSelledProd);

                            MySqlCommand com = new MySqlCommand($"SELECT Name FROM Products WHERE `Code product` = {(int)selledProdDT.Rows[i][0]}", Connection.con);

                            Connection.OpenConnection();

                            materialLabelSelledProdName.Text = com.ExecuteScalar().ToString();

                            try
                            {
                                Connection.OpenConnection();

                                MySqlDataAdapter msda3 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + (int)selledProdDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);

                                DataTable matcher_query = new DataTable();

                                msda3.Fill(matcher_query);

                                Connection.CloseConnection();

                                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                                pictureBoxSelledProdPic.Image = picture;
                            }
                            catch
                            {

                            }
                        }
                        
                    }
                }



                if (flowLayoutPanelMyProducts.Controls.Count == 0)
                {
                    labelNoMyProd.Visible = true;
                    flowLayoutPanelMyProducts.Controls.Add(labelNoMyProd);
                    flowLayoutPanelMyProducts.Size = new System.Drawing.Size(flowLayoutPanelMyProducts.Size.Width, 30);
                    label7.Location = new System.Drawing.Point(252, 136);
                    flowLayoutPanelMyArchive.Location = new System.Drawing.Point(258, 181);
                    flowLayoutPanelMyArchive.Size = new System.Drawing.Size(flowLayoutPanelMyArchive.Size.Width, 325);
                }
                else
                {
                    labelNoMyProd.Visible = false;
                    flowLayoutPanelMyProducts.Controls.Remove(labelNoMyProd);
                    flowLayoutPanelMyProducts.Size = new System.Drawing.Size(flowLayoutPanelMyProducts.Size.Width, 228);
                    label7.Location = new System.Drawing.Point(252, 329);
                    flowLayoutPanelMyArchive.Location = new System.Drawing.Point(258, 382);
                    flowLayoutPanelMyArchive.Size = new System.Drawing.Size(flowLayoutPanelMyArchive.Size.Width, 115);
                }
                if (flowLayoutPanelMyArchive.Controls.Count == 0)
                {
                    labelNonSelled.Visible = true;
                    flowLayoutPanelMyArchive.Controls.Add(labelNonSelled);
                }
                else
                {
                    labelNonSelled.Visible = false;
                    flowLayoutPanelMyArchive.Controls.Remove(labelNonSelled);
                }
            }

        }

        private void selledCard_Click(object sender, EventArgs e)
        {
            int tag = (int)((MaterialCard)sender).Tag;

            CreateTabProduct(tag);

            materialTabControl1.SelectedIndex = materialTabControl1.Controls.Count - 1;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Выход", "Вы точно хотите выйти из аккаунта?", 2, this);
            bfrm.ShowDialog();
            //FormDialogBox frm = new FormDialogBox("Выход", "Вы точно хотите выйти из аккаунта?", 2);
            //frm.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                Account.hasAccount = false;
                this.Text = "Dopamine (Гость)";
                materialTabControl1.SelectedIndex = 0;
                Properties.Settings.Default.Login = "";
                Properties.Settings.Default.Save();

                //FormMessageBox frm2 = new FormMessageBox("Выход", "Вы вышли из аккаунта", 1);
                //frm2.ShowDialog();
            }
        }

        private void tabPageNewProduct_Enter(object sender, EventArgs e)
        {
            if (Account.hasAccount == false)
            {
                BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "auth", "Поиск", "Объявлений не найдено", 1, this);
                bfrm.ShowDialog();
                //panelPopUp.Visible = true;
                materialTabControl1.SelectedIndex = 0;


            }
            else
            {
                panelPopUp.Visible = true;
                timer1.Enabled = true;
            }
        }

        private void tabPageCart_Enter(object sender, EventArgs e)
        {
            if (Account.hasAccount == false)
            {
                BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "auth", "Поиск", "Объявлений не найдено", 1, this);
                bfrm.ShowDialog();
                //panelPopUp.Visible = true;
                materialTabControl1.SelectedIndex = 0;


            }
            else
            {
                
                Carts();
            }
        }

        void Carts()
        {
            panelPopUp.Visible = true;
            timer1.Enabled = true;
            DataTable prodInCart = new DataTable();

            Connection.OpenConnection();

            MySqlDataAdapter msda = new MySqlDataAdapter($"SELECT * FROM `Carts` WHERE `Code user` = {Account.id}", Connection.con);

            msda.Fill(prodInCart);

            

            flowLayoutPanelCarts.Controls.Clear();

            if (prodInCart.Rows.Count > 0)
            {
                labelNonFav.Visible = false;
                flowLayoutPanelCarts.Controls.Remove(labelNonFav);
            }
            else
            {
                labelNonFav.Visible = true;
                flowLayoutPanelCarts.Controls.Add(labelNonFav);
            }

            for (int i = 0; i < prodInCart.Rows.Count; i++)
            {
                MaterialCard materialCard11 = new MaterialSkin.Controls.MaterialCard();
                MaterialCard materialCard12 = new MaterialSkin.Controls.MaterialCard();
                PictureBox pictureBoxPhotoInCart = new System.Windows.Forms.PictureBox();
                MaterialLabel materialLabelProdInCart = new MaterialSkin.Controls.MaterialLabel();
                MaterialButton materialButtonDeleteProdInCart = new MaterialSkin.Controls.MaterialButton();

                // 
                // materialCard11
                // 
                materialCard11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCard11.Controls.Add(materialButtonDeleteProdInCart);
                materialCard11.Controls.Add(materialLabelProdInCart);
                materialCard11.Controls.Add(materialCard12);
                materialCard11.Depth = 0;
                materialCard11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCard11.Location = new System.Drawing.Point(809, 71);
                materialCard11.Margin = new System.Windows.Forms.Padding(14);
                materialCard11.MouseState = MaterialSkin.MouseState.HOVER;
                materialCard11.Name = "materialCard11";
                materialCard11.Padding = new System.Windows.Forms.Padding(14);
                materialCard11.Size = new System.Drawing.Size(526, 91);
                materialCard11.TabIndex = 1;
                materialCard11.Cursor = Cursors.Hand;
                materialCard11.Tag = prodInCart.Rows[i][1];
                materialCard11.Click += new EventHandler(productCard_Click);
                // 
                // materialCard12
                // 
                materialCard12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCard12.Controls.Add(pictureBoxPhotoInCart);
                materialCard12.Depth = 0;
                materialCard12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCard12.Location = new System.Drawing.Point(9, 5);
                materialCard12.Margin = new System.Windows.Forms.Padding(14);
                materialCard12.MouseState = MaterialSkin.MouseState.HOVER;
                materialCard12.Name = "materialCard12";
                materialCard12.Padding = new System.Windows.Forms.Padding(14);
                materialCard12.Size = new System.Drawing.Size(76, 76);
                materialCard12.TabIndex = 47;
                // 
                // pictureBoxPhotoInCart
                // 
                pictureBoxPhotoInCart.BackColor = System.Drawing.Color.White;
                pictureBoxPhotoInCart.Location = new System.Drawing.Point(3, 3);
                pictureBoxPhotoInCart.Name = "pictureBoxPhotoInCart";
                pictureBoxPhotoInCart.Size = new System.Drawing.Size(70, 70);
                pictureBoxPhotoInCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxPhotoInCart.TabIndex = 27;
                pictureBoxPhotoInCart.TabStop = false;
                // 
                // materialLabelProdInCart
                // 
                materialLabelProdInCart.AutoEllipsis = true;
                materialLabelProdInCart.Depth = 0;
                materialLabelProdInCart.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                materialLabelProdInCart.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
                materialLabelProdInCart.Location = new System.Drawing.Point(103, 33);
                materialLabelProdInCart.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabelProdInCart.Name = "materialLabelProdInCart";
                materialLabelProdInCart.Size = new System.Drawing.Size(359, 23);
                materialLabelProdInCart.TabIndex = 48;
                materialLabelProdInCart.Text = "ProductName";
                // 
                // materialButtonDeleteProdInCart
                // 
                materialButtonDeleteProdInCart.AutoSize = false;
                materialButtonDeleteProdInCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                materialButtonDeleteProdInCart.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
                materialButtonDeleteProdInCart.Cursor = System.Windows.Forms.Cursors.Hand;
                materialButtonDeleteProdInCart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButtonDeleteProdInCart.Depth = 0;
                materialButtonDeleteProdInCart.HighEmphasis = true;
                materialButtonDeleteProdInCart.Icon = global::Dopamine.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
                materialButtonDeleteProdInCart.Location = new System.Drawing.Point(469, 28);
                materialButtonDeleteProdInCart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                materialButtonDeleteProdInCart.MouseState = MaterialSkin.MouseState.HOVER;
                materialButtonDeleteProdInCart.Name = "materialButtonDeleteProdInCart";
                materialButtonDeleteProdInCart.NoAccentTextColor = System.Drawing.Color.Empty;
                materialButtonDeleteProdInCart.Size = new System.Drawing.Size(39, 37);
                materialButtonDeleteProdInCart.TabIndex = 49;
                materialButtonDeleteProdInCart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                materialButtonDeleteProdInCart.UseAccentColor = false;
                materialButtonDeleteProdInCart.UseVisualStyleBackColor = true;
                materialButtonDeleteProdInCart.Tag = prodInCart.Rows[i][0];
                materialButtonDeleteProdInCart.Click += new EventHandler(buttonDeleteCart_Click);

                flowLayoutPanelCarts.Controls.Add(materialCard11);

                int prodId = (int)prodInCart.Rows[i][1];

                MySqlCommand com = new MySqlCommand($"SELECT Name FROM Products WHERE `Code product` = {prodId}", Connection.con);
                MySqlCommand com2 = new MySqlCommand($"SELECT Selled FROM Products WHERE `Code product` = {prodId}", Connection.con);

                Connection.OpenConnection();

                materialLabelProdInCart.Text = com.ExecuteScalar().ToString();

                try
                {
                    Connection.OpenConnection();

                    MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + prodId + " AND `IsPreview` = 1", Connection.con);

                    DataTable matcher_query = new DataTable();

                    msda2.Fill(matcher_query);

                    

                    Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                    pictureBoxPhotoInCart.Image = picture;
                }
                catch
                {

                }

                if((bool)com2.ExecuteScalar() == true)
                {
                    materialLabelProdInCart.Text = com.ExecuteScalar().ToString() + " (Продан)";
                }

                Connection.CloseConnection();
            }

            //Connection.CloseConnection();
        }

        private void buttonDeleteCart_Click(object sender, EventArgs e)
        {
            BlackOutForm bfrm2 = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Удаление", "Удалить из избранных?", 2, this);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                int tag = (int)((MaterialButton)sender).Tag;

                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand($"DELETE FROM Carts WHERE `Code cart` = {tag}", Connection.con);
                com.ExecuteNonQuery();

                Connection.CloseConnection();

                Carts();
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            MainFormPaint.height = this.Height;
            MainFormPaint.width = this.Width;
            MainFormPaint.x = this.Location.X;
            MainFormPaint.y = this.Location.Y;
        }

        private void buttonShowPhone_click(object sender, EventArgs e)
        {
            object tag = ((MaterialButton)sender).Tag;

            Connection.OpenConnection();

            MySqlCommand com = new MySqlCommand($"SELECT Phone FROM Users WHERE `Code user` = {Convert.ToInt32(tag)}", Connection.con);



            if (Account.hasAccount == false)
            {
                BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "auth", "Поиск", "Объявлений не найдено", 1, this);
                bfrm.ShowDialog();

            }
            else
            {
                BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Номер телефона", Convert.ToString(com.ExecuteScalar()), 1, this);
                bfrm.ShowDialog();

            }
            Connection.CloseConnection();

        }

        private void buttonConnect_click(object sender, EventArgs e)
        {
            object tag = ((MaterialButton)sender).Tag;

            if (Account.hasAccount == false)
            {
                BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "auth", "Поиск", "Объявлений не найдено", 1, this);
                bfrm.ShowDialog();

            }
            else
            {
                BlackOutForm5 bfrm = new BlackOutForm5(this.Width, this.Height, this.Location.X, this.Location.Y, Convert.ToInt32(tag));
                bfrm.ShowDialog();

            }
        }

        private void materialButtonSelectPhotoForMyProduct_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxMyProductPicture.ImageLocation = openFileDialog1.FileName;
        }

        void RefreshMyProductForm()
        {
            pictureBoxMyProductPicture.ImageLocation = null;
            materialTextBoxNameOfMyProduct.Text = "";
            materialMultiLineTextBoxDescForMyProd.Text = "";
            materialComboBoxCategoryForMyProd.SelectedIndex = 0;
            materialComboBoxStatusForMyProd.SelectedIndex = 0;
            materialComboBoxCityForMyProd.SelectedIndex = 0;
            materialTextBoxCostForMyProd.Text = "";
            materialComboBoxStatusForMyProd.Text = "";
            materialTextBoxStreet2.Text = "";
            materialTextBoxHouse.Text = "";
        }

        private void changeMyProduct(object sender, EventArgs e)
        {
            CurTab.tabPage = ((MaterialButton)sender).Parent;
            object tag = ((MaterialButton)sender).Tag;
            BlackOutForm6 bfrm = new BlackOutForm6(this.Width, this.Height, this.Location.X, this.Location.Y, Convert.ToInt32(tag), this);
            bfrm.ShowDialog();

            

        }

            private void materialButtonPublish_Click(object sender, EventArgs e)
        {
            BlackOutForm bfrm2 = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Публикация", "Разместить данное объявление?", 2, this);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                if (pictureBoxMyProductPicture.ImageLocation != null)
                {
                    if (materialTextBoxNameOfMyProduct.Text != "" && materialMultiLineTextBoxDescForMyProd.Text != "" && materialTextBoxCostForMyProd.Text != "" && materialTextBoxStreet.Text != "")
                    {
                        if (Convert.ToInt32(materialTextBoxCostForMyProd.Text) > 0)
                        {
                            try
                            {
                                Connection.OpenConnection();

                                MySqlCommand com = new MySqlCommand($"INSERT INTO Products (`Code user`, Category, Name, Info, Status, Cost, Location, City, Date) VALUES ({Account.id}, '{materialComboBoxCategoryForMyProd.Text}', '{materialTextBoxNameOfMyProduct.Text}', '{materialMultiLineTextBoxDescForMyProd.Text}', '{materialComboBoxStatusForMyProd.Text}', {Convert.ToInt32(materialTextBoxCostForMyProd.Text)}, '{"Ул. " + materialTextBoxStreet2.Text + " д. " + materialTextBoxHouse.Text}', '{materialComboBoxCityForMyProd.Text}', '{DateTime.Now.ToShortDateString().ToString()}')", Connection.con);
                                com.ExecuteNonQuery();

                                MySqlCommand com2 = new MySqlCommand("SELECT @@identity", Connection.con);
                                int curID = Convert.ToInt32(com2.ExecuteScalar());

                                byte[] image_bytes = File.ReadAllBytes(pictureBoxMyProductPicture.ImageLocation.ToString());
                                MySqlCommand com3 = new MySqlCommand($@"INSERT INTO Pictures(`Picture`, `IsPreview`, `Code product`) VALUES (@ImageData, 1, {curID})", Connection.con);
                                com3.Parameters.Add("@ImageData", MySqlDbType.VarBinary, 1000000);
                                com3.Parameters["@ImageData"].Value = image_bytes;
                                com3.ExecuteNonQuery();
                                Connection.CloseConnection();

                                BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Публикация", "Вы успешно разместили объявление!", 1, this);
                                bfrm.ShowDialog();

                                RefreshMyProductForm();
                            }
                            catch (Exception ex)
                            {
                                BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", ex.Message, 1, this);
                                bfrm.ShowDialog();
                            }
                        }
                        else
                        {
                            BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Стоимость должна быть больше 0", 1, this);
                            bfrm.ShowDialog();
                        }
                    }
                    else
                    {
                        BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Заполните все поля", 1, this);
                        bfrm.ShowDialog();
                    }
                }
                else
                {
                    BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Выберите фото", 1, this);
                    bfrm.ShowDialog();
                }
            }
        }

        private void materialButtonSetUpAccount_Click(object sender, EventArgs e)
        {
            BlackOutForm bfrm = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "change", "Ошибка", "Выберите фото", 1, this);
            bfrm.ShowDialog();
        }

        private void materialTextBoxCostForMyProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void materialTextBoxHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void materialButtonRefreshMyProd_Click(object sender, EventArgs e)
        {
            BlackOutForm bfrm2 = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Публикация", "Сбросить форму?", 2, this);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                RefreshMyProductForm();
            }
        }

        private void myProductDelete(object sender, EventArgs e)
        {
            object tag = ((MaterialButton)sender).Tag;

            BlackOutForm bfrm2 = new BlackOutForm(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Удаление", "Вы уверены, что хотите удалить объявление?", 2, this);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                Connection.OpenConnection();

                MySqlCommand com = new MySqlCommand($"DELETE FROM Products WHERE `Code product` = {Convert.ToInt32(tag)}", Connection.con);
                com.ExecuteNonQuery();

                UpdateProducts();
                int index = 0;

                if (materialTabControl1.SelectedIndex != materialTabControl1.TabPages.Count - 1)
                {
                    index = materialTabControl1.SelectedIndex;
                }
                else if (materialTabControl1.SelectedIndex == materialTabControl1.TabPages.Count - 1 && materialTabControl1.TabPages.Count != 6)
                {
                    index = materialTabControl1.SelectedIndex - 1;
                }
                else if (materialTabControl1.SelectedIndex == materialTabControl1.TabPages.Count - 1 && materialTabControl1.TabPages.Count == 6)
                {
                    index = 0;
                }

                materialTabControl1.TabPages.Remove((TabPage)((MaterialButton)sender).Parent);


                materialTabControl1.SelectedIndex = index;

                Connection.CloseConnection();
            }
        }

        private void tabPageCart_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void tabPageSettings_Enter(object sender, EventArgs e)
        {
            panelPopUp.Visible = true;
            timer1.Enabled = true;
        }

        private void materialComboBoxCategories_TextChanged(object sender, EventArgs e)
        {
            if (materialComboBoxCategories.Text != "Все категории")
            {
                productsDT.Clear();
                Connection.OpenConnection();

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Products`", Connection.con);

                msda.Fill(productsDT);

                Connection.CloseConnection();

                flowLayoutPanel1.Controls.Clear();
                for (int i = 0; i < productsDT.Rows.Count; i++)
                {
                    if (Convert.ToString(productsDT.Rows[i][2]) == materialComboBoxCategories.Text)
                    {
                        if ((bool)productsDT.Rows[i][10] != true)
                        {
                            PictureBox productPicture;
                            Label labelProductName;
                            Label labelCost;
                            Label labelLocation;
                            Label labelDate;
                            MaterialCard productCard;

                            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
                            productPicture = new PictureBox();
                            labelProductName = new Label();
                            labelCost = new Label();
                            labelLocation = new Label();
                            labelDate = new Label();
                            productCard = new MaterialCard();

                            // 
                            // productPicture
                            //
                            try
                            {
                                Connection.OpenConnection();

                                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);

                                DataTable matcher_query = new DataTable();

                                msda2.Fill(matcher_query);

                                Connection.CloseConnection();

                                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                                productPicture.Image = picture;
                            }
                            catch
                            {
                                productPicture.Image = ((System.Drawing.Image)(resources.GetObject("productPicture.Image")));

                            }

                            productPicture.Location = new System.Drawing.Point(3, 3);
                            productPicture.Name = "productPicture";
                            productPicture.Size = new System.Drawing.Size(150, 110);
                            productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                            productPicture.TabIndex = 0;
                            productPicture.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
                            productPicture.TabStop = false;
                            productPicture.Tag = productsDT.Rows[i][0];
                            productPicture.Cursor = System.Windows.Forms.Cursors.Hand;
                            productPicture.Click += new EventHandler(pictureProduct_Click);

                            // 
                            // labelProductName
                            // 
                            labelProductName.AutoEllipsis = true;
                            labelProductName.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelProductName.ForeColor = System.Drawing.Color.DodgerBlue;
                            labelProductName.Location = new System.Drawing.Point(3, 116);
                            labelProductName.Name = "labelProductName";
                            labelProductName.Size = new System.Drawing.Size(161, 18);
                            labelProductName.TabIndex = 2;
                            labelProductName.Text = productsDT.Rows[i][3].ToString();
                            //labelProductName.MouseEnter += new EventHandler(labelName_Hover);
                            //labelProductName.MouseLeave += new EventHandler(labelName_Leave);
                            labelProductName.Click += new EventHandler(labelName_Click);
                            labelProductName.Cursor = System.Windows.Forms.Cursors.Hand;
                            labelProductName.Tag = productsDT.Rows[i][0];

                            // 
                            // labelCost
                            // 
                            labelCost.AutoEllipsis = true;
                            labelCost.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelCost.Location = new System.Drawing.Point(3, 140);
                            labelCost.Name = "labelCost";
                            labelCost.Size = new System.Drawing.Size(161, 18);
                            labelCost.TabIndex = 3;
                            labelCost.Text = productsDT.Rows[i][6].ToString() + " ₽";
                            // 
                            // labelLocation
                            // 
                            labelLocation.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            labelLocation.ForeColor = System.Drawing.Color.DimGray;
                            labelLocation.Location = new System.Drawing.Point(3, 167);
                            labelLocation.Name = "labelLocation";
                            labelLocation.Size = new System.Drawing.Size(160, 19);
                            labelLocation.TabIndex = 4;
                            labelLocation.Text = productsDT.Rows[i][8].ToString() + " " + productsDT.Rows[i][7].ToString();
                            // 
                            // labelDate
                            // 
                            labelDate.AutoSize = true;
                            labelDate.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            labelDate.ForeColor = System.Drawing.Color.DimGray;
                            labelDate.Location = new System.Drawing.Point(3, 185);
                            labelDate.Name = "labelDate";
                            labelDate.Size = new System.Drawing.Size(34, 13);
                            labelDate.TabIndex = 5;
                            labelDate.Text = productsDT.Rows[i][9].ToString();
                            // 
                            // productCard
                            // 
                            productCard.Controls.Add(labelDate);
                            productCard.Controls.Add(labelLocation);
                            productCard.Controls.Add(labelCost);
                            productCard.Controls.Add(labelProductName);
                            productCard.Controls.Add(productPicture);
                            productCard.Location = new System.Drawing.Point(511, 182);
                            productCard.Name = "productCard";
                            productCard.Size = new System.Drawing.Size(156, 210);
                            productCard.TabIndex = 1;
                            productCard.Visible = true;
                            productCard.Cursor = Cursors.Hand;
                            productCard.Click += new EventHandler(productCard_Click);
                            productCard.Tag = productsDT.Rows[i][0];


                            flowLayoutPanel1.Controls.Add(productCard);
                        }
                    }
                }
            }
            else
            {
                UpdateProducts();

            }
        }

        private void materialComboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Справка.pdf");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("Справка.pdf");
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
