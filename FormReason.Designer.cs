using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Dopamine
{
    partial class FormReason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReason));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonOK = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonCancel = new MaterialSkin.Controls.MaterialButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 111);
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
            this.materialLabelTitle.Size = new System.Drawing.Size(247, 44);
            this.materialLabelTitle.TabIndex = 14;
            this.materialLabelTitle.Text = "Title";
            this.materialLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabelTitle.Visible = false;
            // 
            // materialButtonOK
            // 
            this.materialButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonOK.AutoSize = false;
            this.materialButtonOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonOK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonOK.Depth = 0;
            this.materialButtonOK.HighEmphasis = true;
            this.materialButtonOK.Icon = null;
            this.materialButtonOK.Location = new System.Drawing.Point(183, 120);
            this.materialButtonOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonOK.Name = "materialButtonOK";
            this.materialButtonOK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonOK.Size = new System.Drawing.Size(85, 28);
            this.materialButtonOK.TabIndex = 12;
            this.materialButtonOK.Text = "ОК";
            this.materialButtonOK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonOK.UseAccentColor = false;
            this.materialButtonOK.UseVisualStyleBackColor = true;
            this.materialButtonOK.Click += new System.EventHandler(this.materialButtonOK_Click);
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
            this.materialLabelDescription.Text = "Укажите причину блокировки";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.materialTextBox21);
            this.panel2.Controls.Add(this.materialLabelDescription);
            this.panel2.Controls.Add(this.materialButtonOK);
            this.panel2.Controls.Add(this.materialLabelTitle);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.materialButtonCancel);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 161);
            this.panel2.TabIndex = 16;
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.Hint = "Причина";
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(20, 51);
            this.materialTextBox21.MaxLength = 45;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(246, 36);
            this.materialTextBox21.TabIndex = 16;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            this.materialTextBox21.UseTallSize = false;
            // 
            // materialButtonCancel
            // 
            this.materialButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonCancel.AutoSize = false;
            this.materialButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCancel.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCancel.Depth = 0;
            this.materialButtonCancel.HighEmphasis = true;
            this.materialButtonCancel.Icon = null;
            this.materialButtonCancel.Location = new System.Drawing.Point(78, 118);
            this.materialButtonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCancel.Name = "materialButtonCancel";
            this.materialButtonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCancel.Size = new System.Drawing.Size(97, 28);
            this.materialButtonCancel.TabIndex = 13;
            this.materialButtonCancel.Text = "Отменить";
            this.materialButtonCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButtonCancel.UseAccentColor = false;
            this.materialButtonCancel.UseVisualStyleBackColor = true;
            this.materialButtonCancel.Click += new System.EventHandler(this.materialButtonCancel_Click);
            // 
            // FormReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(287, 221);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReason";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блокировка";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReason_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMessageBox_Paint);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabelTitle;
        private MaterialSkin.Controls.MaterialButton materialButtonOK;
        private MaterialSkin.Controls.MaterialLabel materialLabelDescription;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialButton materialButtonCancel;
    }
}