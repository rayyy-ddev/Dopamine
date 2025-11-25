using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dopamine
{
    public partial class FormChangeMyProduct : MaterialForm
    {
        int id;
        FormMain main;
        public FormChangeMyProduct(int id, FormMain main)
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
            this.id = id;
            this.main = main;

            Connection.OpenConnection();

            MySqlCommand com = new MySqlCommand($"SELECT Name FROM Products WHERE `Code product` = {id}", Connection.con);
            MySqlCommand com2 = new MySqlCommand($"SELECT Info FROM Products WHERE `Code product` = {id}", Connection.con);
            MySqlCommand com3 = new MySqlCommand($"SELECT Status FROM Products WHERE `Code product` = {id}", Connection.con);
            MySqlCommand com4 = new MySqlCommand($"SELECT Cost FROM Products WHERE `Code product` = {id}", Connection.con);
            MySqlCommand com5 = new MySqlCommand($"SELECT Location FROM Products WHERE `Code product` = {id}", Connection.con);
            MySqlCommand com6 = new MySqlCommand($"SELECT City FROM Products WHERE `Code product` = {id}", Connection.con);

            materialTextBoxNameOfMyProduct.Text = Convert.ToString(com.ExecuteScalar());
            materialMultiLineTextBoxDescForMyProd.Text = Convert.ToString(com2.ExecuteScalar());
            materialComboBoxStatusForMyProd.SelectedText = Convert.ToString(com3.ExecuteScalar());
            materialTextBoxCostForMyProd.Text = Convert.ToString(com4.ExecuteScalar());
            materialComboBoxCityForMyProd.SelectedText = Convert.ToString(com6.ExecuteScalar());
            string location = Convert.ToString(com5.ExecuteScalar());
            string[] locations = location.Split(' ');

            string street = "";
            string house = "";

            foreach (var sub in locations)
            {
                if(sub != "Ул." && sub != "д.")
                {
                    try
                    {
                        Convert.ToInt32(sub);
                        house = sub;
                    }
                    catch
                    {
                        street = sub;
                    }
                }    
            }

            try
            {
                Connection.OpenConnection();

                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + id + " AND `IsPreview` = 1", Connection.con);

                DataTable matcher_query = new DataTable();

                msda2.Fill(matcher_query);

                Connection.CloseConnection();

                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                pictureBoxMyProductPicture.Image = picture;
            }
            catch
            {
                //productPicture.Image = ((System.Drawing.Image)(resources.GetObject("productPicture.Image")));

            }
            Connection.CloseConnection();

            materialTextBoxStreet2.Text = street;
            materialTextBoxHouse.Text = house;

        }


        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMessengers_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void materialButtonPublish_Click(object sender, EventArgs e)
        {
            if (pictureBoxMyProductPicture.Image != null)
            {
                if (materialTextBoxNameOfMyProduct.Text != "" && materialMultiLineTextBoxDescForMyProd.Text != "" && materialTextBoxCostForMyProd.Text != "" && materialTextBoxStreet.Text != "")
                {
                    try
                    {
                        Connection.OpenConnection();

                        MySqlCommand com = new MySqlCommand($"UPDATE Products SET Category = '{materialComboBoxCategoryForMyProd.Text}', Name = '{materialTextBoxNameOfMyProduct.Text}', Info = '{materialMultiLineTextBoxDescForMyProd.Text}', Status = '{materialComboBoxStatusForMyProd.Text}', Cost = {Convert.ToInt32(materialTextBoxCostForMyProd.Text)}, Location = '{"Ул. " + materialTextBoxStreet2.Text + " д. " + materialTextBoxHouse.Text}', City = '{materialComboBoxCityForMyProd.Text}', Date = '{DateTime.Now.ToShortDateString()}' WHERE `Code product` = {id}", Connection.con);
                        com.ExecuteNonQuery();

                        Image image = pictureBoxMyProductPicture.Image;
                        System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                        byte[] image_bytes = memoryStream.ToArray();
                        MySqlCommand com3 = new MySqlCommand($@"UPDATE Pictures SET `Picture` = @ImageData WHERE `Code product` = {id}", Connection.con);
                        com3.Parameters.Add("@ImageData", MySqlDbType.VarBinary, 1000000);
                        com3.Parameters["@ImageData"].Value = image_bytes;
                        com3.ExecuteNonQuery();
                        Connection.CloseConnection();

                        BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Публикация", "Вы успешно изменили объявление!", 1);
                        bfrm.ShowDialog();

                        Close();

                        int index = 0;

                        if (main.materialTabControl1.SelectedIndex != main.materialTabControl1.TabPages.Count - 1)
                        {
                            index = main.materialTabControl1.SelectedIndex;
                        }
                        else if (main.materialTabControl1.SelectedIndex == main.materialTabControl1.TabPages.Count - 1 && main.materialTabControl1.TabPages.Count != 6)
                        {
                            index = main.materialTabControl1.SelectedIndex - 1;
                        }
                        else if (main.materialTabControl1.SelectedIndex == main.materialTabControl1.TabPages.Count - 1 && main.materialTabControl1.TabPages.Count == 6)
                        {
                            index = 0;
                        }

                        main.materialTabControl1.TabPages.Remove((TabPage)CurTab.tabPage);
                        main.CreateTabProduct(id);
                        main.materialTabControl1.SelectedIndex = main.materialTabControl1.TabPages.Count - 1;


                    }
                    catch (Exception ex)
                    {
                        BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", ex.Message, 1);
                        bfrm.ShowDialog();
                    }
                }
                else
                {
                    BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Заполните все поля", 1);
                    bfrm.ShowDialog();
                }
            }
            else
            {
                BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Выберите фото", 1);
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

        private void materialButtonRefreshMyProd_Click(object sender, EventArgs e)
        {
            BlackOutForm2 bfrm2 = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Публикация", "Сбросить форму?", 2);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                RefreshMyProductForm();
            }
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
    }
}
