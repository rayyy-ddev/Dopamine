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
    public partial class FormCheckEmail : MaterialForm
    {
        FormRegistration main;
        int code = 0;

        public DataTable messengersDT = new DataTable();
        public FormCheckEmail(FormRegistration main, string email)
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

            Random random = new Random();
            code = random.Next(1000, 9999);

            MailAddress from = new MailAddress(uemail);
            MailAddress to = new MailAddress(email);
            MailMessage message = new MailMessage(from, to)
            {
                Subject = "Dopamine - подтверждение почты",
                IsBodyHtml = false,
                Body = $"Ваш код подтверждения - {code}"
            };
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25)
            {
                Credentials = new NetworkCredential(uemail, upassword),
                EnableSsl = true
            };
            smtp.Send(message);
        }


        string uemail = "danchick6@yandex.ru";
        string upassword = "yspoarjsquoshtdk";
        private void materialButtonSave_Click(object sender, EventArgs e)
        {
            if (materialTextBoxLogin.Text == code.ToString())
            {
                main.Register();
                Close();
            }
            else
            {
                FormMessageBox frm = new FormMessageBox("Ошибка", "Неверный код подтверждения", 1);
                frm.ShowDialog();
            }

            
        }
    }
}
