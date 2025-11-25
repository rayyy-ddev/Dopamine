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
    public partial class BlackOutForm : Form
    {
        string formType;
        string title;
        string desc;
        int btnCount;
        FormMain main;
        public BlackOutForm(int width, int height, int x, int y, string formType, string title, string desc, int btnCount, FormMain main)
        {
            
            InitializeComponent();

            this.Width = width; this.Height = height;
            this.Location = new Point(x, y);

            this.formType = formType;
            this.title = title;
            this.desc = desc;
            this.btnCount = btnCount;

            this.main = main;
            
        }

        private void BlackOutForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BlackOutForm_Shown(object sender, EventArgs e)
        {
            if (formType == "msg")
            {
                FormMessageBox frm = new FormMessageBox(title, desc, btnCount);
                frm.ShowDialog();
            }
            if (formType == "dialog")
            {
                FormDialogBox frm = new FormDialogBox(title, desc, btnCount);
                frm.ShowDialog();
            }
            if (formType == "auth")
            {
                FormAuth frm = new FormAuth(main);
                frm.ShowDialog();
            }
            if (formType == "change")
            {
                FormChangeAccount frm = new FormChangeAccount(main);
                frm.ShowDialog();
            }

            Close();
        }
    }
}
