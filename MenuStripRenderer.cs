using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dopamine
{
    public class Cols : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            // 51, 153, 255 - устанавливаем голубой цвет выбранного элемента
            // (или задаете свой)
            get { return Color.FromArgb(64, 64, 64); }
        }

        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(255, 64,64,64); }
        }

        public override Color ImageMarginGradientBegin
        {
            get { return Color.FromArgb(255, 64, 64, 64); }
        }

        public override Color ImageMarginGradientEnd
        {
            get { return Color.FromArgb(255, 64, 64, 64); }
        }

        public override Color ImageMarginGradientMiddle
        {
            get { return Color.FromArgb(255, 64, 64, 64); }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(255, 64, 64, 64); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(255, 64, 64, 64); }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(255, 64, 64, 64); }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.FromArgb(255, 64, 64, 64); }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(255, 64, 64, 64); }
        }

        public override Color MenuItemBorder
        {
            get { return Color.FromArgb(255, 64, 64, 64); }
        }



    }


}
