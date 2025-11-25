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
    public partial class FormAuth : MaterialForm
    {

        FormMain main;
        public FormAuth(FormMain main)
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

        private void button1_Click(object sender, EventArgs e)
        {
            BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "reg", "Вход", "Успешный вход", 1);
            bfrm.ShowDialog();
            //FormRegistration formRegistration = new FormRegistration();
            //formRegistration.ShowDialog();
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            if (materialTextBoxLogin.Text != "" && materialTextBoxPassword.Text != "")
            {
                Connection.OpenConnection();

                try
                {
                    MySqlCommand com = new MySqlCommand($"SELECT `Password` FROM `Users` WHERE `Login` = '{materialTextBoxLogin.Text}'", Connection.con);
                    MySqlCommand comBan = new MySqlCommand($"SELECT `Banned` FROM `Users` WHERE `Login` = '{materialTextBoxLogin.Text}'", Connection.con);
                    MySqlCommand comReason = new MySqlCommand($"SELECT `Reason` FROM `Users` WHERE `Login` = '{materialTextBoxLogin.Text}'", Connection.con);
                    MySqlCommand comAdmin = new MySqlCommand($"SELECT `IsAdmin` FROM `Users` WHERE `Login` = '{materialTextBoxLogin.Text}'", Connection.con);
                    MySqlCommand comHint = new MySqlCommand($"SELECT `Hint` FROM `Users` WHERE `Login` = '{materialTextBoxLogin.Text}'", Connection.con);
                    if (Convert.ToString(com.ExecuteScalar()) == materialTextBoxPassword.Text)
                    {
                        if ((bool)comBan.ExecuteScalar() == false)
                        {
                            if ((bool)comAdmin.ExecuteScalar() == false)
                            {
                                Account.hasAccount = true;
                                Account.login = materialTextBoxLogin.Text;
                                Account.password = materialTextBoxPassword.Text;

                                MySqlCommand com2 = new MySqlCommand($"SELECT `Name` FROM `Users` WHERE `Login` = '{materialTextBoxLogin.Text}'", Connection.con);
                                MySqlCommand com3 = new MySqlCommand($"SELECT `Code user` FROM `Users` WHERE `Login` = '{materialTextBoxLogin.Text}'", Connection.con);
                                Properties.Settings.Default.Login = materialTextBoxLogin.Text;
                                Properties.Settings.Default.Save();
                                Account.name = Convert.ToString(com2.ExecuteScalar());
                                Account.id = Convert.ToInt32(com3.ExecuteScalar());

                                main.Login();

                                Close();

                                BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Вход", "Успешный вход", 1);
                                bfrm.ShowDialog();

                                main.materialTabControl1.SelectedIndex = 0;

                                //FormMessageBox frm = new FormMessageBox("Вход", "Успешный вход", 1);
                                //frm.ShowDialog();

                                //MessageBox.Show("Успешный вход", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MySqlCommand com3 = new MySqlCommand($"SELECT `Code user` FROM `Users` WHERE `Login` = '{materialTextBoxLogin.Text}'", Connection.con);

                                Account.id = Convert.ToInt32(com3.ExecuteScalar());
                                FormAdminPanel formAdminPanel = new FormAdminPanel();
                                formAdminPanel.Show();
                                Close();

                                main.Hide();

                            }
                        }
                        else
                        {
                            BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", $"Ваш аккаунт заблокирован. Причина: {(string)comReason.ExecuteScalar()}", 1);
                            bfrm.ShowDialog();
                        }

                    }
                    else
                    {
                        BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Неправильный логин или пароль", 1);
                        bfrm.ShowDialog();
                    }
                }
                catch
                {
                    if(Account.name != "(Гость) (Сервер не найден)")
                    {
                        BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Неправильный логин или пароль", 1);
                        bfrm.ShowDialog();
                    }
                    else
                    {
                        if(materialTextBoxLogin.Text == Properties.Settings.Default.AdminLogin && materialTextBoxPassword.Text == Properties.Settings.Default.AdminPassword)
                        {
                            FormAdminPanel formAdminPanel = new FormAdminPanel();
                            formAdminPanel.Show();
                            Close();

                            main.Hide();
                        }
                        else
                        {
                            BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Неправильный логин или пароль", 1);
                            bfrm.ShowDialog();
                        }
                    }
                    
                    //FormMessageBox frm = new FormMessageBox("Ошибка", "Неправильный логин или пароль", 1);
                    //frm.ShowDialog();
                    //MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                Connection.CloseConnection();
            }
            else
            {
                BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Заполните все поля", 1);
                bfrm.ShowDialog();
                //FormMessageBox frm = new FormMessageBox("Ошибка", "Заполните все поля", 1);
                //frm.ShowDialog();
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void FormAuth_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void materialButtonForgot_Click(object sender, EventArgs e)
        {
            FormForgotPass frm = new FormForgotPass();
            frm.ShowDialog();
        }
    }
}
