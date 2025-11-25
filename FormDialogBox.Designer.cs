using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Dopamine
{
    partial class FormDialogBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bounds = new Rectangle(0, 0, Width, Height);
            int CornerRadius = 12;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X+0.7f, bounds.Y+0.7f, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - CornerRadius, bounds.Y+1f, CornerRadius-1.7f, CornerRadius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - CornerRadius-2.7f, bounds.Y + bounds.Height - CornerRadius-2.7f, CornerRadius+1, CornerRadius+1, 0, 90);
            path.AddArc(bounds.X+0.7f, bounds.Y + bounds.Height - CornerRadius-2f, CornerRadius-1.7f, CornerRadius, 90, 90);
            path.CloseAllFigures();
            Region = new Region(path);
            base.OnPaint(e);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonNo = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonYes = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 1);
            this.panel1.TabIndex = 15;
            // 
            // materialLabelTitle
            // 
            this.materialLabelTitle.Depth = 0;
            this.materialLabelTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabelTitle.Location = new System.Drawing.Point(21, 4);
            this.materialLabelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTitle.Name = "materialLabelTitle";
            this.materialLabelTitle.Size = new System.Drawing.Size(262, 44);
            this.materialLabelTitle.TabIndex = 14;
            this.materialLabelTitle.Text = "Title";
            this.materialLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabelTitle.Visible = false;
            // 
            // materialButtonNo
            // 
            this.materialButtonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonNo.AutoSize = false;
            this.materialButtonNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonNo.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonNo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonNo.Depth = 0;
            this.materialButtonNo.HighEmphasis = true;
            this.materialButtonNo.Icon = null;
            this.materialButtonNo.Location = new System.Drawing.Point(87, 82);
            this.materialButtonNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonNo.Name = "materialButtonNo";
            this.materialButtonNo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonNo.Size = new System.Drawing.Size(88, 28);
            this.materialButtonNo.TabIndex = 13;
            this.materialButtonNo.Text = "Нет";
            this.materialButtonNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonNo.UseAccentColor = false;
            this.materialButtonNo.UseVisualStyleBackColor = true;
            this.materialButtonNo.Click += new System.EventHandler(this.materialButtonCancel_Click);
            // 
            // materialButtonYes
            // 
            this.materialButtonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonYes.AutoSize = false;
            this.materialButtonYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonYes.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonYes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonYes.Depth = 0;
            this.materialButtonYes.HighEmphasis = true;
            this.materialButtonYes.Icon = null;
            this.materialButtonYes.Location = new System.Drawing.Point(183, 82);
            this.materialButtonYes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonYes.Name = "materialButtonYes";
            this.materialButtonYes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonYes.Size = new System.Drawing.Size(85, 28);
            this.materialButtonYes.TabIndex = 12;
            this.materialButtonYes.Text = "Да";
            this.materialButtonYes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonYes.UseAccentColor = false;
            this.materialButtonYes.UseVisualStyleBackColor = true;
            this.materialButtonYes.Click += new System.EventHandler(this.materialButtonOK_Click);
            // 
            // materialLabelDescription
            // 
            this.materialLabelDescription.Depth = 0;
            this.materialLabelDescription.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDescription.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabelDescription.Location = new System.Drawing.Point(19, 14);
            this.materialLabelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDescription.Name = "materialLabelDescription";
            this.materialLabelDescription.Size = new System.Drawing.Size(247, 34);
            this.materialLabelDescription.TabIndex = 11;
            this.materialLabelDescription.Text = "Description";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.materialLabelDescription);
            this.panel2.Controls.Add(this.materialButtonYes);
            this.panel2.Controls.Add(this.materialLabelTitle);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.materialButtonNo);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 123);
            this.panel2.TabIndex = 16;
            // 
            // FormDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(287, 183);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDialogBox_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMessageBox_Paint);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabelTitle;
        private MaterialSkin.Controls.MaterialButton materialButtonNo;
        private MaterialSkin.Controls.MaterialButton materialButtonYes;
        private MaterialSkin.Controls.MaterialLabel materialLabelDescription;
        private Panel panel2;
    }
}