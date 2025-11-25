using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dopamine
{
    public partial class FormForgotPass : MaterialForm
    {
        FormAddMessenger formAddMessenger;
        FormChangeMessenger formChangeMessenger;

        public DataTable messengersDT = new DataTable();
        public FormForgotPass()
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


        string uemail = "danchick6@yandex.ru";
        string upassword = "yspoarjsquoshtdk";
        private void materialButtonSave_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();

            MySqlCommand com = new MySqlCommand($"SELECT EXISTS(SELECT `Email` FROM `USERS` WHERE `Email` = '{materialTextBoxLogin.Text}')",Connection.con);

            if(com.ExecuteScalar().ToString() == "1")
            {
                MySqlCommand com2 = new MySqlCommand($"SELECT `Login` FROM `Users` WHERE `Email` = '{materialTextBoxLogin.Text}'",Connection.con);
                MySqlCommand com3 = new MySqlCommand($"SELECT `Password` FROM `Users` WHERE `Email` = '{materialTextBoxLogin.Text}'", Connection.con);

                MailAddress from = new MailAddress(uemail);
                try
                {
                    MailAddress to = new MailAddress(materialTextBoxLogin.Text);
                    MailMessage message = new MailMessage(from, to)
                    {
                        Subject = "Восстановление аккаунта Dopamine",
                        IsBodyHtml = false,
                        Body = $"Ваш логин - {com2.ExecuteScalar()}\nПароль: {com3.ExecuteScalar()}"
                    };
                    SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25)
                    {
                        Credentials = new NetworkCredential(uemail, upassword),
                        EnableSsl = true
                    };
                    smtp.Send(message);
                    FormMessageBox frm = new FormMessageBox("Восстановление аккаунта", "Логин и пароль были отправлены на Вашу почту", 1);
                    frm.ShowDialog();
                    Close();
                }
                catch
                {
                    FormMessageBox frm2 = new FormMessageBox("Восстановление аккаунта", "Неверный формат почты", 1);
                    frm2.ShowDialog();
                }
                
                
                
            }
            else
            {
                FormMessageBox frm = new FormMessageBox("Восстановление аккаунта", "Такой email не зарегистрирован", 1);
                frm.ShowDialog();
            }

            Connection.CloseConnection();

            
        }
    }
}
