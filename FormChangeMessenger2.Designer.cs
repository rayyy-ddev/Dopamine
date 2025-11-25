using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Dopamine
{
    partial class FormChangeMessenger2
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
            path.AddArc(bounds.X + 0.7f, bounds.Y + 0.7f, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - CornerRadius, bounds.Y + 1f, CornerRadius - 1.7f, CornerRadius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - CornerRadius - 2.7f, bounds.Y + bounds.Height - CornerRadius - 2.7f, CornerRadius + 1, CornerRadius + 1, 0, 90);
            path.AddArc(bounds.X + 0.7f, bounds.Y + bounds.Height - CornerRadius - 2f, CornerRadius - 1.7f, CornerRadius, 90, 90);
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxLink = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialComboBoxMessenger = new MaterialSkin.Controls.MaterialComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.materialButtonAdd);
            this.panel1.Controls.Add(this.materialTextBoxLink);
            this.panel1.Controls.Add(this.materialComboBoxMessenger);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 165);
            this.panel1.TabIndex = 16;
            // 
            // materialButtonAdd
            // 
            this.materialButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonAdd.AutoSize = false;
            this.materialButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAdd.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAdd.Depth = 0;
            this.materialButtonAdd.HighEmphasis = true;
            this.materialButtonAdd.Icon = null;
            this.materialButtonAdd.Location = new System.Drawing.Point(142, 113);
            this.materialButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAdd.Name = "materialButtonAdd";
            this.materialButtonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAdd.Size = new System.Drawing.Size(127, 34);
            this.materialButtonAdd.TabIndex = 15;
            this.materialButtonAdd.Text = "Изменить";
            this.materialButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAdd.UseAccentColor = false;
            this.materialButtonAdd.UseVisualStyleBackColor = true;
            this.materialButtonAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // materialTextBoxLink
            // 
            this.materialTextBoxLink.AnimateReadOnly = false;
            this.materialTextBoxLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLink.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLink.Depth = 0;
            this.materialTextBoxLink.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLink.HideSelection = true;
            this.materialTextBoxLink.Hint = "Ссылка";
            this.materialTextBoxLink.LeadingIcon = null;
            this.materialTextBoxLink.Location = new System.Drawing.Point(19, 59);
            this.materialTextBoxLink.MaxLength = 32767;
            this.materialTextBoxLink.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLink.Name = "materialTextBoxLink";
            this.materialTextBoxLink.PasswordChar = '\0';
            this.materialTextBoxLink.PrefixSuffixText = null;
            this.materialTextBoxLink.ReadOnly = false;
            this.materialTextBoxLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxLink.SelectedText = "";
            this.materialTextBoxLink.SelectionLength = 0;
            this.materialTextBoxLink.SelectionStart = 0;
            this.materialTextBoxLink.ShortcutsEnabled = true;
            this.materialTextBoxLink.Size = new System.Drawing.Size(250, 36);
            this.materialTextBoxLink.TabIndex = 1;
            this.materialTextBoxLink.TabStop = false;
            this.materialTextBoxLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLink.TrailingIcon = null;
            this.materialTextBoxLink.UseSystemPasswordChar = false;
            this.materialTextBoxLink.UseTallSize = false;
            // 
            // materialComboBoxMessenger
            // 
            this.materialComboBoxMessenger.AutoResize = false;
            this.materialComboBoxMessenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxMessenger.Depth = 0;
            this.materialComboBoxMessenger.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxMessenger.DropDownHeight = 118;
            this.materialComboBoxMessenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxMessenger.DropDownWidth = 121;
            this.materialComboBoxMessenger.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxMessenger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxMessenger.FormattingEnabled = true;
            this.materialComboBoxMessenger.Hint = "Мессенджер";
            this.materialComboBoxMessenger.IntegralHeight = false;
            this.materialComboBoxMessenger.ItemHeight = 29;
            this.materialComboBoxMessenger.Items.AddRange(new object[] {
            "WhatsApp",
            "Telegram",
            "Viber",
            "VK",
            "Одноклассники"});
            this.materialComboBoxMessenger.Location = new System.Drawing.Point(19, 18);
            this.materialComboBoxMessenger.MaxDropDownItems = 4;
            this.materialComboBoxMessenger.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxMessenger.Name = "materialComboBoxMessenger";
            this.materialComboBoxMessenger.Size = new System.Drawing.Size(250, 35);
            this.materialComboBoxMessenger.StartIndex = 0;
            this.materialComboBoxMessenger.TabIndex = 0;
            this.materialComboBoxMessenger.UseTallSize = false;
            // 
            // FormChangeMessenger2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 237);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeMessenger2";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить мессенджер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddMessenger_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLink;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxMessenger;
        private MaterialSkin.Controls.MaterialButton materialButtonAdd;
    }
}