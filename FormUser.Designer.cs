namespace Dopamine
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxAva = new System.Windows.Forms.PictureBox();
            this.buttonShowPhone = new System.Windows.Forms.Button();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.Location = new System.Drawing.Point(28, 240);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(194, 53);
            this.labelUserName.TabIndex = 12;
            this.labelUserName.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(279, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Объявления пользователя";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(283, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 359);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBoxAva
            // 
            this.pictureBoxAva.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxAva.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva.Image")));
            this.pictureBoxAva.Location = new System.Drawing.Point(32, 29);
            this.pictureBoxAva.Name = "pictureBoxAva";
            this.pictureBoxAva.Size = new System.Drawing.Size(208, 208);
            this.pictureBoxAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAva.TabIndex = 15;
            this.pictureBoxAva.TabStop = false;
            // 
            // buttonShowPhone
            // 
            this.buttonShowPhone.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonShowPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowPhone.FlatAppearance.BorderSize = 0;
            this.buttonShowPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowPhone.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowPhone.ForeColor = System.Drawing.Color.White;
            this.buttonShowPhone.Location = new System.Drawing.Point(33, 307);
            this.buttonShowPhone.Name = "buttonShowPhone";
            this.buttonShowPhone.Size = new System.Drawing.Size(207, 60);
            this.buttonShowPhone.TabIndex = 26;
            this.buttonShowPhone.Text = "Показать телефон";
            this.buttonShowPhone.UseVisualStyleBackColor = false;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendMessage.FlatAppearance.BorderSize = 0;
            this.buttonSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendMessage.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendMessage.ForeColor = System.Drawing.Color.White;
            this.buttonSendMessage.Location = new System.Drawing.Point(33, 373);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(207, 60);
            this.buttonSendMessage.TabIndex = 25;
            this.buttonSendMessage.Text = "Связаться с продавцом";
            this.buttonSendMessage.UseVisualStyleBackColor = false;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.buttonShowPhone);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBoxAva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 503);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxAva;
        private System.Windows.Forms.Button buttonShowPhone;
        private System.Windows.Forms.Button buttonSendMessage;
    }
}