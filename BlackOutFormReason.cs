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
    public partial class BlackOutFormReason : Form
    {

        int id;
        FormMain main;
        public BlackOutFormReason(int width, int height, int x, int y)
        {
            
            InitializeComponent();

            this.Width = width; this.Height = height;
            this.Location = new Point(x, y);

            
        }

        private void BlackOutForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BlackOutForm_Shown(object sender, EventArgs e)
        {
            FormReason frm = new FormReason();
            frm.ShowDialog();

            Close();
        }
    }
}
