using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace Dopamine
{
    public partial class BlackOutForm6 : Form
    {

        int id;
        FormMain main;
        public BlackOutForm6(int width, int height, int x, int y, int id, FormMain main)
        {
            
            InitializeComponent();

            this.Width = width; this.Height = height;
            this.Location = new Point(x, y);

            this.id = id;

            this.main = main;
            
        }

        private void BlackOutForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BlackOutForm_Shown(object sender, EventArgs e)
        {
            FormChangeMyProduct frm = new FormChangeMyProduct(id, main);
            frm.ShowDialog();

            Close();
        }
    }
}
