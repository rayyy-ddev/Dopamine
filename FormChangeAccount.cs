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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dopamine
{
    public partial class FormChangeAccount : MaterialForm
    {
        FormMain main;
        public FormChangeAccount(FormMain main)
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
            this.main = main;

            Connection.OpenConnection();

            MySqlCommand com = new MySqlCommand($"SELECT Name FROM Users WHERE `Code user` = {Account.id}", Connection.con);
            MySqlCommand com2 = new MySqlCommand($"SELECT Login FROM Users WHERE `Code user` = {Account.id}", Connection.con);
            MySqlCommand com3 = new MySqlCommand($"SELECT Password FROM Users WHERE `Code user` = {Account.id}", Connection.con);
            MySqlCommand com4 = new MySqlCommand($"SELECT Phone FROM Users WHERE `Code user` = {Account.id}", Connection.con);

            materialTextBoxName.Text = (string)com.ExecuteScalar();
            materialTextBoxLogin.Text = (string)com2.ExecuteScalar();
            materialTextBoxPassword.Text = (string)com3.ExecuteScalar();
            materialTextBoxPhone.Text = (string)com4.ExecuteScalar();


            try
            {
                Connection.OpenConnection();

                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Profile pictures` WHERE `Code user` = " + Account.id, Connection.con);

                DataTable matcher_query = new DataTable();

                msda2.Fill(matcher_query);

                Connection.CloseConnection();

                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                pictureBoxPreview.Image = picture;
            }
            catch
            {
                //productPicture.Image = ((System.Drawing.Image)(resources.GetObject("productPicture.Image")));

            }


            Connection.CloseConnection();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            BlackOutForm2 bfrm2 = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "dialog", "Аккаунт", "Сохранить изменения?", 2);
            bfrm2.ShowDialog();
            if (DialogBoxResultcs.result == true)
            {
                try
                {
                    if (materialTextBoxLogin.Text != "" && materialTextBoxName.Text != "" && materialTextBoxChkPassword.Text != "" && materialTextBoxPassword.Text != "" && materialTextBoxPhone.Text != "")
                    {
                        if (materialTextBoxPhone.Text.Length == 11)
                        {


                            if (materialTextBoxPassword.Text.Length >= 6 && materialTextBoxPassword.Text.Length <= 25)
                            {

                                if (materialTextBoxPassword.Text == materialTextBoxChkPassword.Text)
                                {
                                    Connection.OpenConnection();

                                    MySqlCommand com = new MySqlCommand($"UPDATE Users SET Name = '{materialTextBoxName.Text}', Login = '{materialTextBoxLogin.Text}', Password = '{materialTextBoxPassword.Text}', Phone = '{materialTextBoxPhone.Text}' WHERE `Code user` = {Account.id}", Connection.con);
                                    com.ExecuteNonQuery();

                                    DataTable profPics = new DataTable();
                                    bool nonPic = false;

                                    MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Profile pictures`", Connection.con);

                                    msda.Fill(profPics);

                                    for(int i = 0; i < profPics.Rows.Count; i++)
                                    {
                                        if ((int)profPics.Rows[i][2] == Account.id)
                                        {
                                            nonPic = false;
                                        }
                                        else
                                        {
                                            nonPic = true;
                                        }    
                                    }

                                    if(nonPic == true)
                                    {
                                        Image image = pictureBoxPreview.Image;
                                        System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                                        byte[] image_bytes = memoryStream.ToArray();
                                        MySqlCommand com3 = new MySqlCommand($@"INSERT INTO `Profile pictures` (Picture, `Code user`) VALUES (@ImageData, {Account.id})", Connection.con);
                                        com3.Parameters.Add("@ImageData", MySqlDbType.VarBinary, 1000000);
                                        com3.Parameters["@ImageData"].Value = image_bytes;
                                        com3.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        Image image = pictureBoxPreview.Image;
                                        System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                                        byte[] image_bytes = memoryStream.ToArray();
                                        MySqlCommand com3 = new MySqlCommand($@"UPDATE `Profile pictures` SET `Picture` = @ImageData WHERE `Code user` = {Account.id}", Connection.con);
                                        com3.Parameters.Add("@ImageData", MySqlDbType.VarBinary, 1000000);
                                        com3.Parameters["@ImageData"].Value = image_bytes;
                                        com3.ExecuteNonQuery();
                                    }

                                    Connection.CloseConnection();

                                    BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Аккаунт", "Вы успешно сохранили изменения!", 1);
                                    bfrm.ShowDialog();

                                    Close();

                                    Account.login = materialTextBoxLogin.Text;
                                    Account.password = materialTextBoxPassword.Text;
                                    Account.name = materialTextBoxName.Text;


                                    main.Login();
                                    main.materialTabControl1.SelectedIndex = 0;
                                    main.materialTabControl1.SelectedIndex = 2;
                                }
                                else
                                {
                                    BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Пароли не совпадают", 1);
                                    bfrm.ShowDialog();
                                    //FormMessageBox frm = new FormMessageBox("Ошибка", "Пароли не совпадают", 1);
                                    //frm.ShowDialog();
                                    //MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                            else
                            {
                                BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Длинна пароля должна быть от 6 до 25 символов", 1);
                                bfrm.ShowDialog();
                                //FormMessageBox frm = new FormMessageBox("Ошибка", "Длинна пароля должна быть от 6 до 25 символов", 1);
                                //frm.ShowDialog();
                                //MessageBox.Show("Длинна пароля должна быть от 6 до 25 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Проверьте правильность номера телефона", 1);
                            bfrm.ShowDialog();
                            //FormMessageBox frm = new FormMessageBox("Ошибка", "Проверьте правильность номера телефона", 1);
                            //frm.ShowDialog();
                        }
                    }
                    else
                    {
                        BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Заполните все поля", 1);
                        bfrm.ShowDialog();
                        //FormMessageBox frm = new FormMessageBox("Ошибка", "Заполните все поля", 1);
                        //frm.ShowDialog();
                        //MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message == $"Duplicate entry '{materialTextBoxLogin.Text}' for key 'users.Login'")
                    {
                        BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Пользователь с таким логином уже существует", 1);
                        bfrm.ShowDialog();
                        //FormMessageBox frm = new FormMessageBox("Ошибка", "Пользователь с таким логином уже существует", 1);
                        //frm.ShowDialog();
                    }

                    //MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void buttonSelectPhone_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxPreview.ImageLocation = openFileDialog1.FileName;
            
            Connection.CloseConnection();
        }

        private void buttonMessengers_Click(object sender, EventArgs e)
        {
            BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "messenger", "Ошибка", "Пользователь с таким логином уже существует", 1);
            bfrm.ShowDialog();
            //FormMessengers formMessengers = new FormMessengers();
            //formMessengers.ShowDialog();
        }

        private void materialTextBoxPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormRegistration_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void materialTextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
