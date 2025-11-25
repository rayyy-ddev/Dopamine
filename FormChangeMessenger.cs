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
    public partial class FormChangeMessenger : Form
    {
        FormMessengers main;
        int id;
        public FormChangeMessenger(FormMessengers main)
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

        public void Start(int tag)
        {
            id = tag;
            comboBoxMessenger.SelectedItem = main.messengersDT.Rows[id][1].ToString();
            textBoxLink.Text = main.messengersDT.Rows[id][2].ToString();

        }

        private void FormAddMessenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void textBoxLink_Click(object sender, EventArgs e)
        {
            if(textBoxLink.Text == "Ссылка")
            {
                textBoxLink.Text = "";
            }
        }

        private void textBoxLink_Leave(object sender, EventArgs e)
        {
            if (textBoxLink.Text == "")
            {
                textBoxLink.Text = "Ссылка";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBoxLink.Text != "Ссылка" && comboBoxMessenger.SelectedItem != null)
            {
                if (Account.hasAccount == true)
                {
                    Connection.OpenConnection();

                    MySqlCommand com = new MySqlCommand($"UPDATE `Messenger` SET Name = '{comboBoxMessenger.SelectedItem}', Link = '{textBoxLink.Text}', `Code user` = {Account.id})", Connection.con);

                    com.ExecuteNonQuery();

                    Connection.CloseConnection();
                }
                else
                {

                    main.messengersDT.Rows[id][1] = (comboBoxMessenger.SelectedItem.ToString());
                    main.messengersDT.Rows[id][2] = (textBoxLink.Text);

                }
                Hide();
                
                main.UpdateRows();

            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
