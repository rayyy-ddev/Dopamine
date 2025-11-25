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
    public partial class FormRegistration : MaterialForm
    {

        public FormRegistration()
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
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
                return cp;
            }
        }

        //private const int CS_DROPSHADOW = 0x20000;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= CS_DROPSHADOW;
        //        return cp;
        //    }
        //}
        public void Register()
        {
            MySqlCommand com = new MySqlCommand($"INSERT INTO `USERS` (`Name`, `Login`, `Password`, `Phone`, `Email`) VALUES ('{materialTextBoxName.Text}', '{materialTextBoxLogin.Text}', '{materialTextBoxPassword.Text}', '{materialTextBoxPhone.Text}', '{materialTextBoxHint.Text}')", Connection.con);

            com.ExecuteNonQuery();


            MySqlCommand com2 = new MySqlCommand("SELECT @@identity", Connection.con);
            int curID = Convert.ToInt32(com2.ExecuteScalar());

            try
            {
                if (openFileDialog1.FileName != null)
                {
                    byte[] image_bytes = File.ReadAllBytes(openFileDialog1.FileName);
                    MySqlCommand com3 = new MySqlCommand($@"INSERT INTO `Profile pictures`(`Picture`, `Code user`) VALUES (@ImageData, {curID})", Connection.con);
                    com3.Parameters.Add("@ImageData", MySqlDbType.VarBinary, 1000000);
                    com3.Parameters["@ImageData"].Value = image_bytes;
                    com3.ExecuteNonQuery();
                }
            }
            catch
            {

            }

            for (int i = 0; i < Account.messengersDT.Rows.Count; i++)
            {
                MySqlCommand com4 = new MySqlCommand($"INSERT INTO `Messenger`(`Name`, `Link`, `Code user`) VALUES ('{Account.messengersDT.Rows[i][1]}', '{Account.messengersDT.Rows[i][2]}', {curID})", Connection.con);

                com4.ExecuteNonQuery();
            }

            Connection.CloseConnection();


            BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Регистрация", "Успешная регистрация", 1);
            bfrm.ShowDialog();
            //FormMessageBox frm = new FormMessageBox("Регистрация", "Успешная регистрация", 1);
            //frm.ShowDialog();

            //MessageBox.Show("Успешная регистрация", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hide();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialTextBoxLogin.Text != "" && materialTextBoxName.Text != "" && materialTextBoxChkPassword.Text != "" && materialTextBoxPassword.Text != "" && materialTextBoxPhone.Text != "" && materialTextBoxHint.Text != "")
                {
                    if (materialTextBoxPhone.Text.Length == 11)
                    {


                        if (materialTextBoxPassword.Text.Length >= 6 && materialTextBoxPassword.Text.Length <= 25)
                        {
                            Connection.OpenConnection();

                            if (materialTextBoxPassword.Text == materialTextBoxChkPassword.Text)
                            {
                                if (materialTextBoxHint.Text != materialTextBoxPassword.Text)
                                {

                                    FormCheckEmail frm = new FormCheckEmail(this, materialTextBoxHint.Text);
                                    frm.ShowDialog();
                                    
                                }
                                else
                                {
                                    BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Подсказка не должна совпадать с паролем", 1);
                                    bfrm.ShowDialog();
                                }
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
            catch(Exception ex)
            {
                if (ex.Message == $"Duplicate entry '{materialTextBoxLogin.Text}' for key 'users.Login'")
                {
                    BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Пользователь с таким логином уже существует", 1);
                    bfrm.ShowDialog();

                }
                else if (ex.Message == $"Duplicate entry '{materialTextBoxHint.Text}' for key 'users.Email'")
                {
                    BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Пользователь с таким email уже существует", 1);
                    bfrm.ShowDialog();

                }

                //MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
