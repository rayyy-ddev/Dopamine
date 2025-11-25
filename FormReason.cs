using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class FormReason : MaterialForm
    {
        public FormReason()
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
            if (materialTextBox21.Text != "")
            {
                Reason.reason = materialTextBox21.Text;
                Close();
                DialogBoxResultcs.result = true;
            }
        }

        private void materialButtonCancel_Click(object sender, EventArgs e)
        {
            DialogBoxResultcs.result = false;
            Close();
        }

        private void FormReason_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogBoxResultcs.result = false;
        }
    }
}
