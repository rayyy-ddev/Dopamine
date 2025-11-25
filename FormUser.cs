using Dopamine.Properties;
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
    public partial class FormUser : Form
    {

        DataTable productsDT = new DataTable();

        public FormUser(int tag)
        {
            InitializeComponent();
            Connection.OpenConnection();

            MySqlCommand com = new MySqlCommand("SELECT `Name` FROM `Users` WHERE `Code user` = " + tag, Connection.con);
            
            this.Text = "Dopamine - " + Convert.ToString(com.ExecuteScalar());
            labelUserName.Text = Convert.ToString(com.ExecuteScalar());


            Connection.CloseConnection();

            Connection.OpenConnection();

            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM `Products`", Connection.con);

            msda.Fill(productsDT);


            try
            {

                MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Profile pictures` WHERE `Code user` = " + tag, Connection.con);

                DataTable matcher_query = new DataTable();

                msda2.Fill(matcher_query);

                Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                pictureBoxAva.Image = picture;
            }
            catch
            {
                

            }



            for (int i = 0; i < productsDT.Rows.Count; i++)
            {
                if (Convert.ToInt32(productsDT.Rows[i][1]) == tag)
                {
                    PictureBox productPicture;
                    Label labelProductName;
                    Label labelCost;
                    Label labelLocation;
                    Label labelDate;
                    Panel productCard;

                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
                    productPicture = new PictureBox();
                    labelProductName = new Label();
                    labelCost = new Label();
                    labelLocation = new Label();
                    labelDate = new Label();
                    productCard = new Panel();

                    // 
                    // productPicture
                    //
                    try
                    {
                        

                        MySqlDataAdapter msda2 = new MySqlDataAdapter("SELECT `Picture` FROM `Pictures` WHERE `Code product` = " + productsDT.Rows[i][0] + " AND `IsPreview` = 1", Connection.con);

                        DataTable matcher_query = new DataTable();

                        msda2.Fill(matcher_query);

                        

                        Bitmap picture = ByteImage.GetImageFromByteArray((byte[])matcher_query.Rows[matcher_query.Rows.Count - 1][0]);

                        productPicture.Image = picture;
                    }
                    catch
                    {
                        productPicture.Image = ((System.Drawing.Image)(resources.GetObject("productPicture.Image")));

                    }

                    productPicture.Location = new System.Drawing.Point(3, 3);
                    productPicture.Name = "productPicture";
                    productPicture.Size = new System.Drawing.Size(157, 110);
                    productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    productPicture.TabIndex = 0;
                    productPicture.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
                    productPicture.TabStop = false;
                    productPicture.Tag = productsDT.Rows[i][0];
                    productPicture.Cursor = System.Windows.Forms.Cursors.Hand;
                    productPicture.Click += new EventHandler(pictureProduct_Click);

                    // 
                    // labelProductName
                    // 
                    labelProductName.AutoEllipsis = true;
                    labelProductName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    labelProductName.ForeColor = System.Drawing.Color.DodgerBlue;
                    labelProductName.Location = new System.Drawing.Point(0, 116);
                    labelProductName.Name = "labelProductName";
                    labelProductName.Size = new System.Drawing.Size(161, 18);
                    labelProductName.TabIndex = 2;
                    labelProductName.Text = productsDT.Rows[i][3].ToString();
                    labelProductName.MouseEnter += new EventHandler(labelName_Hover);
                    labelProductName.MouseLeave += new EventHandler(labelName_Leave);
                    labelProductName.Click += new EventHandler(labelName_Click);
                    labelProductName.Cursor = System.Windows.Forms.Cursors.Hand;
                    labelProductName.Tag = productsDT.Rows[i][0];

                    // 
                    // labelCost
                    // 
                    labelCost.AutoEllipsis = true;
                    labelCost.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    labelCost.Location = new System.Drawing.Point(0, 138);
                    labelCost.Name = "labelCost";
                    labelCost.Size = new System.Drawing.Size(161, 18);
                    labelCost.TabIndex = 3;
                    labelCost.Text = productsDT.Rows[i][6].ToString();
                    // 
                    // labelLocation
                    // 
                    labelLocation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    labelLocation.ForeColor = System.Drawing.Color.DimGray;
                    labelLocation.Location = new System.Drawing.Point(0, 156);
                    labelLocation.Name = "labelLocation";
                    labelLocation.Size = new System.Drawing.Size(160, 19);
                    labelLocation.TabIndex = 4;
                    labelLocation.Text = productsDT.Rows[i][8].ToString() + " " + productsDT.Rows[i][7].ToString();
                    // 
                    // labelDate
                    // 
                    labelDate.AutoSize = true;
                    labelDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    labelDate.ForeColor = System.Drawing.Color.DimGray;
                    labelDate.Location = new System.Drawing.Point(0, 174);
                    labelDate.Name = "labelDate";
                    labelDate.Size = new System.Drawing.Size(34, 13);
                    labelDate.TabIndex = 5;
                    labelDate.Text = productsDT.Rows[i][9].ToString();
                    // 
                    // productCard
                    // 
                    productCard.Controls.Add(labelDate);
                    productCard.Controls.Add(labelLocation);
                    productCard.Controls.Add(labelCost);
                    productCard.Controls.Add(labelProductName);
                    productCard.Controls.Add(productPicture);
                    productCard.Location = new System.Drawing.Point(511, 182);
                    productCard.Name = "productCard";
                    productCard.Size = new System.Drawing.Size(165, 199);
                    productCard.TabIndex = 1;
                    productCard.Visible = true;


                    flowLayoutPanel1.Controls.Add(productCard);

                }
                Connection.CloseConnection();
            }
                
        }

        private void labelName_Hover(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = System.Drawing.Color.PaleVioletRed;

        }

        private void labelName_Click(object sender, EventArgs e)
        {
            object tag = ((Label)sender).Tag;
            FormProduct fProduct = new FormProduct(Convert.ToInt32(tag));
            fProduct.Show();

        }

        private void labelName_Leave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = System.Drawing.Color.DodgerBlue;

        }

        private void pictureProduct_Click(object sender, EventArgs e)
        {
            object tag = ((PictureBox)sender).Tag;
            FormProduct fProduct = new FormProduct(Convert.ToInt32(tag));
            fProduct.Show();

        }
    }
}
