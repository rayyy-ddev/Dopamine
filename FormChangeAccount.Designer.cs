using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Dopamine
{
    partial class FormChangeAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeAccount));
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButtonSelectPhoto = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonRegister = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxChkPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxLogin = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxPhone = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            this.pictureBoxPreview.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(129, 129);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 22;
            this.pictureBoxPreview.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.materialButtonSelectPhoto);
            this.panel1.Controls.Add(this.materialButtonRegister);
            this.panel1.Controls.Add(this.materialTextBoxChkPassword);
            this.panel1.Controls.Add(this.materialTextBoxPassword);
            this.panel1.Controls.Add(this.materialTextBoxLogin);
            this.panel1.Controls.Add(this.materialTextBoxName);
            this.panel1.Controls.Add(this.materialTextBoxPhone);
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 327);
            this.panel1.TabIndex = 32;
            // 
            // materialButtonSelectPhoto
            // 
            this.materialButtonSelectPhoto.AutoSize = false;
            this.materialButtonSelectPhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSelectPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonSelectPhoto.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSelectPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSelectPhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSelectPhoto.Depth = 0;
            this.materialButtonSelectPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonSelectPhoto.HighEmphasis = true;
            this.materialButtonSelectPhoto.Icon = null;
            this.materialButtonSelectPhoto.Location = new System.Drawing.Point(254, 161);
            this.materialButtonSelectPhoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSelectPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSelectPhoto.Name = "materialButtonSelectPhoto";
            this.materialButtonSelectPhoto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSelectPhoto.Size = new System.Drawing.Size(133, 34);
            this.materialButtonSelectPhoto.TabIndex = 27;
            this.materialButtonSelectPhoto.Text = "Выбрать фото";
            this.materialButtonSelectPhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSelectPhoto.UseAccentColor = false;
            this.materialButtonSelectPhoto.UseVisualStyleBackColor = false;
            this.materialButtonSelectPhoto.Click += new System.EventHandler(this.buttonSelectPhone_Click);
            // 
            // materialButtonRegister
            // 
            this.materialButtonRegister.AutoSize = false;
            this.materialButtonRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonRegister.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonRegister.Depth = 0;
            this.materialButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonRegister.HighEmphasis = true;
            this.materialButtonRegister.Icon = null;
            this.materialButtonRegister.Location = new System.Drawing.Point(23, 263);
            this.materialButtonRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonRegister.Name = "materialButtonRegister";
            this.materialButtonRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonRegister.Size = new System.Drawing.Size(127, 34);
            this.materialButtonRegister.TabIndex = 26;
            this.materialButtonRegister.Text = "Сохранить";
            this.materialButtonRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonRegister.UseAccentColor = false;
            this.materialButtonRegister.UseVisualStyleBackColor = false;
            this.materialButtonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // materialTextBoxChkPassword
            // 
            this.materialTextBoxChkPassword.AnimateReadOnly = false;
            this.materialTextBoxChkPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxChkPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxChkPassword.Depth = 0;
            this.materialTextBoxChkPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxChkPassword.HideSelection = true;
            this.materialTextBoxChkPassword.Hint = "Подтверждение";
            this.materialTextBoxChkPassword.LeadingIcon = null;
            this.materialTextBoxChkPassword.Location = new System.Drawing.Point(23, 202);
            this.materialTextBoxChkPassword.MaxLength = 25;
            this.materialTextBoxChkPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxChkPassword.Name = "materialTextBoxChkPassword";
            this.materialTextBoxChkPassword.PasswordChar = '●';
            this.materialTextBoxChkPassword.PrefixSuffixText = null;
            this.materialTextBoxChkPassword.ReadOnly = false;
            this.materialTextBoxChkPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxChkPassword.SelectedText = "";
            this.materialTextBoxChkPassword.SelectionLength = 0;
            this.materialTextBoxChkPassword.SelectionStart = 0;
            this.materialTextBoxChkPassword.ShortcutsEnabled = true;
            this.materialTextBoxChkPassword.Size = new System.Drawing.Size(214, 36);
            this.materialTextBoxChkPassword.TabIndex = 24;
            this.materialTextBoxChkPassword.TabStop = false;
            this.materialTextBoxChkPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxChkPassword.TrailingIcon = null;
            this.materialTextBoxChkPassword.UseSystemPasswordChar = true;
            this.materialTextBoxChkPassword.UseTallSize = false;
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
            this.materialTextBoxPassword.Location = new System.Drawing.Point(23, 157);
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
            this.materialTextBoxPassword.Size = new System.Drawing.Size(214, 36);
            this.materialTextBoxPassword.TabIndex = 23;
            this.materialTextBoxPassword.TabStop = false;
            this.materialTextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxPassword.TrailingIcon = null;
            this.materialTextBoxPassword.UseSystemPasswordChar = true;
            this.materialTextBoxPassword.UseTallSize = false;
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
            this.materialTextBoxLogin.Location = new System.Drawing.Point(23, 112);
            this.materialTextBoxLogin.MaxLength = 25;
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
            this.materialTextBoxLogin.Size = new System.Drawing.Size(214, 36);
            this.materialTextBoxLogin.TabIndex = 22;
            this.materialTextBoxLogin.TabStop = false;
            this.materialTextBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLogin.TrailingIcon = null;
            this.materialTextBoxLogin.UseSystemPasswordChar = false;
            this.materialTextBoxLogin.UseTallSize = false;
            // 
            // materialTextBoxName
            // 
            this.materialTextBoxName.AnimateReadOnly = false;
            this.materialTextBoxName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxName.Depth = 0;
            this.materialTextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxName.HideSelection = true;
            this.materialTextBoxName.Hint = "Имя";
            this.materialTextBoxName.LeadingIcon = null;
            this.materialTextBoxName.Location = new System.Drawing.Point(23, 67);
            this.materialTextBoxName.MaxLength = 45;
            this.materialTextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxName.Name = "materialTextBoxName";
            this.materialTextBoxName.PasswordChar = '\0';
            this.materialTextBoxName.PrefixSuffixText = null;
            this.materialTextBoxName.ReadOnly = false;
            this.materialTextBoxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxName.SelectedText = "";
            this.materialTextBoxName.SelectionLength = 0;
            this.materialTextBoxName.SelectionStart = 0;
            this.materialTextBoxName.ShortcutsEnabled = true;
            this.materialTextBoxName.Size = new System.Drawing.Size(214, 36);
            this.materialTextBoxName.TabIndex = 21;
            this.materialTextBoxName.TabStop = false;
            this.materialTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxName.TrailingIcon = null;
            this.materialTextBoxName.UseSystemPasswordChar = false;
            this.materialTextBoxName.UseTallSize = false;
            // 
            // materialTextBoxPhone
            // 
            this.materialTextBoxPhone.AnimateReadOnly = false;
            this.materialTextBoxPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxPhone.Depth = 0;
            this.materialTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxPhone.HideSelection = true;
            this.materialTextBoxPhone.Hint = "Телефон";
            this.materialTextBoxPhone.LeadingIcon = null;
            this.materialTextBoxPhone.Location = new System.Drawing.Point(23, 21);
            this.materialTextBoxPhone.MaxLength = 11;
            this.materialTextBoxPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPhone.Name = "materialTextBoxPhone";
            this.materialTextBoxPhone.PasswordChar = '\0';
            this.materialTextBoxPhone.PrefixSuffixText = "8";
            this.materialTextBoxPhone.ReadOnly = false;
            this.materialTextBoxPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxPhone.SelectedText = "";
            this.materialTextBoxPhone.SelectionLength = 0;
            this.materialTextBoxPhone.SelectionStart = 0;
            this.materialTextBoxPhone.ShortcutsEnabled = false;
            this.materialTextBoxPhone.Size = new System.Drawing.Size(214, 36);
            this.materialTextBoxPhone.TabIndex = 20;
            this.materialTextBoxPhone.TabStop = false;
            this.materialTextBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxPhone.TrailingIcon = null;
            this.materialTextBoxPhone.UseSystemPasswordChar = false;
            this.materialTextBoxPhone.UseTallSize = false;
            this.materialTextBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxPhone_KeyPress);
            this.materialTextBoxPhone.TextChanged += new System.EventHandler(this.materialTextBoxPhone_TextChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBoxPreview);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(254, 21);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(133, 133);
            this.materialCard1.TabIndex = 0;
            // 
            // FormChangeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 392);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeAccount";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настроить аккаунт";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormRegistration_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxChkPassword;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLogin;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxName;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxPhone;
        private MaterialSkin.Controls.MaterialButton materialButtonRegister;
        private MaterialSkin.Controls.MaterialButton materialButtonSelectPhoto;
    }
}