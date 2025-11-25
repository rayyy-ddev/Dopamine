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
    public partial class BlackOutForm5 : Form
    {
        int tag;
        public BlackOutForm5(int width, int height, int x, int y, int tag)
        {
            
            InitializeComponent();

            this.Width = width; this.Height = height;
            this.Location = new Point(x, y);
            this.tag = tag;
            
        }

        private void BlackOutForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BlackOutForm_Shown(object sender, EventArgs e)
        {
            FormMessengersShow frm = new FormMessengersShow(tag);
            frm.ShowDialog();


            Close();
        }
    }
}
