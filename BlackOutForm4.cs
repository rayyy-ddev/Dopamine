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
    public partial class BlackOutForm4 : Form
    {
        string formType;
        string title;
        string desc;
        int btnCount;
        int tag;
        FormMessengers main;
        public BlackOutForm4(int width, int height, int x, int y, string formType, string title, string desc, int btnCount, FormMessengers main, int tag)
        {
            
            InitializeComponent();

            this.Width = width; this.Height = height;
            this.Location = new Point(x, y);

            this.formType = formType;
            this.title = title;
            this.desc = desc;
            this.btnCount = btnCount;

            this.main = main;
            this.tag = tag;
            
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
            if (formType == "add")
            {
                FormAddMessenger frm = new FormAddMessenger(main);
                frm.ShowDialog();
            }
            if (formType == "change")
            {
                FormChangeMessenger2 frm = new FormChangeMessenger2(main, tag);
                frm.ShowDialog();
            }
            if (formType == "messenger")
            {
                FormMessengers frm = new FormMessengers();
                frm.ShowDialog();
            }

            Close();
        }
    }
}
