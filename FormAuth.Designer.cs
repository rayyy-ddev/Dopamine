using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Dopamine
{
    partial class FormAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonReg = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonLogin = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialButtonForgot = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxLogin = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialButtonReg);
            this.panel1.Location = new System.Drawing.Point(0, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 103);
            this.panel1.TabIndex = 18;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel2.Location = new System.Drawing.Point(20, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(185, 17);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Нет аккаунта на Dopamine?";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialButtonReg
            // 
            this.materialButtonReg.AutoSize = false;
            this.materialButtonReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonReg.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonReg.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonReg.Depth = 0;
            this.materialButtonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonReg.HighEmphasis = true;
            this.materialButtonReg.Icon = null;
            this.materialButtonReg.Location = new System.Drawing.Point(23, 44);
            this.materialButtonReg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonReg.Name = "materialButtonReg";
            this.materialButtonReg.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonReg.Size = new System.Drawing.Size(171, 34);
            this.materialButtonReg.TabIndex = 22;
            this.materialButtonReg.Text = "Зарегистрироваться";
            this.materialButtonReg.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonReg.UseAccentColor = false;
            this.materialButtonReg.UseVisualStyleBackColor = false;
            this.materialButtonReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialButtonLogin
            // 
            this.materialButtonLogin.AutoSize = false;
            this.materialButtonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonLogin.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonLogin.Depth = 0;
            this.materialButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonLogin.HighEmphasis = true;
            this.materialButtonLogin.Icon = null;
            this.materialButtonLogin.Location = new System.Drawing.Point(23, 122);
            this.materialButtonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonLogin.Name = "materialButtonLogin";
            this.materialButtonLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonLogin.Size = new System.Drawing.Size(107, 34);
            this.materialButtonLogin.TabIndex = 1;
            this.materialButtonLogin.Text = "Войти";
            this.materialButtonLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonLogin.UseAccentColor = false;
            this.materialButtonLogin.UseVisualStyleBackColor = false;
            this.materialButtonLogin.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.materialButtonForgot);
            this.panel2.Controls.Add(this.materialCard1);
            this.panel2.Controls.Add(this.materialCard7);
            this.panel2.Controls.Add(this.materialButtonLogin);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 177);
            this.panel2.TabIndex = 22;
            // 
            // materialButtonForgot
            // 
            this.materialButtonForgot.AutoSize = false;
            this.materialButtonForgot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonForgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonForgot.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonForgot.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonForgot.Depth = 0;
            this.materialButtonForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonForgot.HighEmphasis = true;
            this.materialButtonForgot.Icon = null;
            this.materialButtonForgot.Location = new System.Drawing.Point(140, 122);
            this.materialButtonForgot.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonForgot.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonForgot.Name = "materialButtonForgot";
            this.materialButtonForgot.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonForgot.Size = new System.Drawing.Size(107, 34);
            this.materialButtonForgot.TabIndex = 37;
            this.materialButtonForgot.Text = "Восстановить";
            this.materialButtonForgot.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButtonForgot.UseAccentColor = false;
            this.materialButtonForgot.UseVisualStyleBackColor = false;
            this.materialButtonForgot.Click += new System.EventHandler(this.materialButtonForgot_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialTextBoxPassword);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 68);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(218, 36);
            this.materialCard1.TabIndex = 36;
            // 
            // materialTextBoxPassword
            // 
            this.materialTextBoxPassword.AnimateReadOnly = false;
            this.materialTextBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxPassword.Depth = 0;
            this.materialTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxPassword.HideSelection = true;
            this.materialTextBoxPassword.Hint = "Пароль";
            this.materialTextBoxPassword.LeadingIcon = null;
            this.materialTextBoxPassword.LeaveOnEnterKey = true;
            this.materialTextBoxPassword.Location = new System.Drawing.Point(2, 2);
            this.materialTextBoxPassword.MaxLength = 25;
            this.materialTextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPassword.Name = "materialTextBoxPassword";
            this.materialTextBoxPassword.PasswordChar = '●';
            this.materialTextBoxPassword.PrefixSuffixText = null;
            this.materialTextBoxPassword.ReadOnly = false;
            this.materialTextBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxPassword.SelectedText = "";
            this.materialTextBoxPassword.SelectionLength = 0;
            this.materialTextBoxPassword.SelectionStart = 0;
            this.materialTextBoxPassword.ShortcutsEnabled = true;
            this.materialTextBoxPassword.Size = new System.Drawing.Size(222, 36);
            this.materialTextBoxPassword.TabIndex = 20;
            this.materialTextBoxPassword.TabStop = false;
            this.materialTextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxPassword.TrailingIcon = null;
            this.materialTextBoxPassword.UseSystemPasswordChar = true;
            this.materialTextBoxPassword.UseTallSize = false;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialTextBoxLogin);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(23, 24);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(218, 36);
            this.materialCard7.TabIndex = 35;
            // 
            // materialTextBoxLogin
            // 
            this.materialTextBoxLogin.AnimateReadOnly = false;
            this.materialTextBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLogin.Depth = 0;
            this.materialTextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLogin.HideSelection = true;
            this.materialTextBoxLogin.Hint = "Логин";
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
            this.materialTextBoxLogin.Size = new System.Drawing.Size(222, 36);
            this.materialTextBoxLogin.TabIndex = 19;
            this.materialTextBoxLogin.TabStop = false;
            this.materialTextBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLogin.TrailingIcon = null;
            this.materialTextBoxLogin.UseSystemPasswordChar = false;
            this.materialTextBoxLogin.UseTallSize = false;
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 345);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuth";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAuth_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLogin;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxPassword;
        private MaterialSkin.Controls.MaterialButton materialButtonLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButtonReg;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialButton materialButtonForgot;
    }
}