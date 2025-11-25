using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Dopamine
{
    public partial class FormMessengersShow : MaterialForm
    {
        int id;
        public FormMessengersShow(int id)
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

            this.id = id;

            Connection.OpenConnection();

            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM Messenger WHERE `Code user` = {id}", Connection.con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            Connection.CloseConnection();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MaterialSkin.Controls.MaterialCard materialCard1;
                MaterialSkin.Controls.MaterialLabel materialLabelLink;
                MaterialSkin.Controls.MaterialLabel materialLabelName;

                materialCard1 = new MaterialSkin.Controls.MaterialCard();
                materialLabelName = new MaterialSkin.Controls.MaterialLabel();
                materialLabelLink = new MaterialSkin.Controls.MaterialLabel();

                // 
                // materialCard1
                // 
                materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                materialCard1.Controls.Add(materialLabelLink);
                materialCard1.Controls.Add(materialLabelName);
                materialCard1.Depth = 0;
                materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                materialCard1.Location = new System.Drawing.Point(43, 147);
                materialCard1.Margin = new System.Windows.Forms.Padding(14);
                materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
                materialCard1.Name = "materialCard1";
                materialCard1.Padding = new System.Windows.Forms.Padding(14);
                materialCard1.Size = new System.Drawing.Size(287, 35);
                materialCard1.TabIndex = 17;
                // 
                // materialLabelName
                // 
                materialLabelName.AutoSize = true;
                materialLabelName.Depth = 0;
                materialLabelName.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                materialLabelName.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
                materialLabelName.Location = new System.Drawing.Point(12, 9);
                materialLabelName.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabelName.Name = "materialLabelName";
                materialLabelName.Size = new System.Drawing.Size(106, 17);
                materialLabelName.TabIndex = 0;
                materialLabelName.Text = dt.Rows[i][1].ToString();
                // 
                // materialLabelLink
                // 
                materialLabelLink.AutoEllipsis = true;
                materialLabelLink.Depth = 0;
                materialLabelLink.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                materialLabelLink.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
                materialLabelLink.Location = new System.Drawing.Point(140, 9);
                materialLabelLink.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabelLink.Name = "materialLabelLink";
                materialLabelLink.Size = new System.Drawing.Size(130, 17);
                materialLabelLink.TabIndex = 1;
                materialLabelLink.Text = dt.Rows[i][2].ToString();
                materialLabelLink.TextAlign = System.Drawing.ContentAlignment.TopRight;

                flowLayoutPanel1.Controls.Add(materialCard1);
            }
        }

        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void FormMessageBox_Paint(object sender, PaintEventArgs e)
        {
        }

    private void materialButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
