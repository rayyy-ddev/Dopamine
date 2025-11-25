namespace Dopamine
{
    partial class FormChangeMessenger
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.comboBoxMessenger = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLink
            // 
            this.textBoxLink.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLink.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxLink.Location = new System.Drawing.Point(22, 50);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(256, 21);
            this.textBoxLink.TabIndex = 2;
            this.textBoxLink.Text = "Ссылка";
            this.textBoxLink.Click += new System.EventHandler(this.textBoxLink_Click);
            this.textBoxLink.Enter += new System.EventHandler(this.textBoxLink_Click);
            this.textBoxLink.Leave += new System.EventHandler(this.textBoxLink_Leave);
            // 
            // comboBoxMessenger
            // 
            this.comboBoxMessenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMessenger.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMessenger.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxMessenger.FormattingEnabled = true;
            this.comboBoxMessenger.Items.AddRange(new object[] {
            "WhatsApp",
            "Telegram",
            "Viber",
            "VK",
            "Одноклассники"});
            this.comboBoxMessenger.Location = new System.Drawing.Point(22, 23);
            this.comboBoxMessenger.Name = "comboBoxMessenger";
            this.comboBoxMessenger.Size = new System.Drawing.Size(256, 21);
            this.comboBoxMessenger.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(180, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormChangeMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 127);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxMessenger);
            this.Controls.Add(this.textBoxLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeMessenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить мессенджер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddMessenger_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.ComboBox comboBoxMessenger;
        private System.Windows.Forms.Button button3;
    }
}