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
    public partial class FormProduct : Form
    {
        DataTable miniPicturesDT = new DataTable();
        public FormProduct(int tag)
        {
            InitializeComponent();

            Connection.OpenConnection();

            MySqlCommand com = new MySqlCommand("SELECT `Name` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
            MySqlCommand com2 = new MySqlCommand("SELECT `Status` FROM `Products` WHERE `Code product` = " + tag, Connection.con);
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
            this.Text = "Dopamine - " + Convert.ToString(com.ExecuteScalar());
            labelProductName.Text = Convert.ToString(com.ExecuteScalar());
            labelStatus.Text = Convert.ToString(com2.ExecuteScalar());
            labelProductCost.Text = Convert.ToString(com3.ExecuteScalar()) + " ₽";
            labelUserName.Text = Convert.ToString(com5.ExecuteScalar());
            labelAdress.Text = Convert.ToString(com8.ExecuteScalar()) + " " + Convert.ToString(com6.ExecuteScalar());
            labelProductInfo.Text = Convert.ToString(com7.ExecuteScalar());
            labelUserName.Tag = Convert.ToInt32(com4.ExecuteScalar());

            MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT * FROM `Pictures` WHERE `Code product` = " + tag + " AND `IsPreview` = 0", Connection.con);

            msda2.Fill(miniPicturesDT);


            for (int i = 0; i < miniPicturesDT.Rows.Count; i++)
            {
                PictureBox pictureBoxMiniProd;
                pictureBoxMiniProd = new PictureBox();

                try
                {

                    MySqlDataAdapter msda3 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + tag + " AND `Code picture` = " + miniPicturesDT.Rows[i][0], Connection.con);

                    DataTable matcher_query2 = new DataTable();

                    msda3.Fill(matcher_query2);

                    

                    Bitmap picture2 = ByteImage.GetImageFromByteArray((byte[])matcher_query2.Rows[matcher_query2.Rows.Count - 1][0]);

                    pictureBoxMiniProd.Image = picture2;
                }
                catch
                {
                    

                }

                // 
                // pictureBoxMiniProd
                // 
                pictureBoxMiniProd.BackColor = System.Drawing.Color.Transparent;
                pictureBoxMiniProd.Location = new System.Drawing.Point(537, 329);
                pictureBoxMiniProd.Name = "pictureBoxMiniProd";
                pictureBoxMiniProd.Size = new System.Drawing.Size(112, 112);
                pictureBoxMiniProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxMiniProd.TabIndex = 26;
                pictureBoxMiniProd.TabStop = false;
                pictureBoxMiniProd.Click += new System.EventHandler(this.pictureBox1_Click);




                //flowLayoutPanel1.Controls.Add(pictureBoxMiniProd);

            }
            Connection.CloseConnection();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }

        private void labelUserName_MouseEnter(object sender, EventArgs e)
        {
            labelUserName.ForeColor = System.Drawing.Color.PaleVioletRed;
        }

        private void labelUserName_MouseLeave(object sender, EventArgs e)
        {
            labelUserName.ForeColor = System.Drawing.Color.Black;
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {
            object tag = ((Label)sender).Tag;
            FormUser fUser = new FormUser(Convert.ToInt32(tag));
            fUser.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowPhone_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {

        }

        private void labelProductCost_Click(object sender, EventArgs e)
        {

        }
    }
}
