using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Dopamine
{
    partial class FormForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxLogin = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialCard7);
            this.panel1.Controls.Add(this.materialButtonSave);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 218);
            this.panel1.TabIndex = 16;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel2.Location = new System.Drawing.Point(16, 18);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(239, 45);
            this.materialLabel2.TabIndex = 37;
            this.materialLabel2.Text = "Введите email, который Вы вводили при регистрации";
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialTextBoxLogin);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(14, 66);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(241, 36);
            this.materialCard7.TabIndex = 36;
            // 
            // materialTextBoxLogin
            // 
            this.materialTextBoxLogin.AnimateReadOnly = false;
            this.materialTextBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLogin.Depth = 0;
            this.materialTextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLogin.HideSelection = true;
            this.materialTextBoxLogin.Hint = "Почта";
            this.materialTextBoxLogin.LeadingIcon = null;
            this.materialTextBoxLogin.LeaveOnEnterKey = true;
            this.materialTextBoxLogin.Location = new System.Drawing.Point(2, 2);
            this.materialTextBoxLogin.MaxLength = 45;
            this.materialTextBoxLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLogin.Name = "materialTextBoxLogin";
            this.materialTextBoxLogin.PasswordChar = '\0';
            this.materialTextBoxLogin.PrefixSuffixText = null;
            this.materialTextBoxLogin.ReadOnly = false;
            this.materialTextBoxLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxLogin.SelectedText = "";
            this.materialTextBoxLogin.SelectionLength = 0;
            this.materialTextBoxLogin.SelectionStart = 0;
            this.materialTextBoxLogin.ShortcutsEnabled = true;
            this.materialTextBoxLogin.Size = new System.Drawing.Size(239, 36);
            this.materialTextBoxLogin.TabIndex = 19;
            this.materialTextBoxLogin.TabStop = false;
            this.materialTextBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLogin.TrailingIcon = null;
            this.materialTextBoxLogin.UseSystemPasswordChar = false;
            this.materialTextBoxLogin.UseTallSize = false;
            // 
            // materialButtonSave
            // 
            this.materialButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonSave.AutoSize = false;
            this.materialButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSave.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSave.Depth = 0;
            this.materialButtonSave.HighEmphasis = true;
            this.materialButtonSave.Icon = null;
            this.materialButtonSave.Location = new System.Drawing.Point(145, 165);
            this.materialButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSave.Name = "materialButtonSave";
            this.materialButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSave.Size = new System.Drawing.Size(110, 30);
            this.materialButtonSave.TabIndex = 14;
            this.materialButtonSave.Text = "Отправить";
            this.materialButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSave.UseAccentColor = false;
            this.materialButtonSave.UseVisualStyleBackColor = true;
            this.materialButtonSave.Click += new System.EventHandler(this.materialButtonSave_Click);
            // 
            // FormForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 286);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormForgotPass";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Восстановление аккаунта";
            this.panel1.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButtonSave;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}