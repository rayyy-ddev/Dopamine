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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dopamine
{
    public partial class FormChangeMessenger2 : MaterialForm
    {
        int id;
        FormMessengers main;
        public FormChangeMessenger2(FormMessengers main, int tag)
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

            id = tag;
            materialComboBoxMessenger.SelectedItem = main.messengersDT.Rows[id][1].ToString();
            materialTextBoxLink.Text = main.messengersDT.Rows[id][2].ToString();
        }

        private void FormAddMessenger_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (materialTextBoxLink.Text != "" && materialComboBoxMessenger.SelectedItem != null)
            {
                if (Account.hasAccount == true)
                {
                    Connection.OpenConnection();

                    MySqlCommand com = new MySqlCommand($"UPDATE `Messenger` SET Name = '{materialComboBoxMessenger.SelectedItem}', Link = '{materialTextBoxLink.Text}', `Code user` = {Account.id})", Connection.con);

                    com.ExecuteNonQuery();

                    Connection.CloseConnection();
                }
                else
                {

                    main.messengersDT.Rows[id][1] = (materialComboBoxMessenger.SelectedItem.ToString());
                    main.messengersDT.Rows[id][2] = (materialTextBoxLink.Text);

                }
                Hide();

                main.UpdateRows();

            }
            else
            {
                BlackOutForm2 bfrm = new BlackOutForm2(this.Width, this.Height, this.Location.X, this.Location.Y, "msg", "Ошибка", "Заполните все поля", 1);
                bfrm.ShowDialog();
                //MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
