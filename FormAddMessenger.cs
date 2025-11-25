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
    public partial class FormAddMessenger : MaterialForm
    {
        FormMessengers main;
        public FormAddMessenger(FormMessengers main)
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

        private void FormAddMessenger_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if(materialTextBoxLink.Text != "" && materialComboBoxMessenger.SelectedItem != null)
            {
                if (Account.hasAccount == true)
                {
                    Connection.OpenConnection();

                    MySqlCommand com = new MySqlCommand($"INSERT INTO `Messenger` (Name, Link, `Code user`) VALUES ('{materialComboBoxMessenger.SelectedItem}', '{materialTextBoxLink.Text}', {Account.id})", Connection.con);

                    com.ExecuteNonQuery();

                    Connection.CloseConnection();
                }
                else
                {

                    main.messengersDT.Rows.Add(1, materialComboBoxMessenger.SelectedItem.ToString(), materialTextBoxLink.Text);

                }
                Hide();
                
                main.UpdateRows();
                //if(main.Height >= 155 && main.Height < 385)
                //{
                //    main.Height += 77;
                //}
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
    }
}
