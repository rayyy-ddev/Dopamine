namespace Dopamine
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.labelProductName = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.labelProductCost = new System.Windows.Forms.Label();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelProductInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonShowPhone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductName.Location = new System.Drawing.Point(22, 19);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(220, 32);
            this.labelProductName.TabIndex = 11;
            this.labelProductName.Text = "ProductName";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            this.pictureBoxPreview.Location = new System.Drawing.Point(28, 97);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(355, 355);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 14;
            this.pictureBoxPreview.TabStop = false;
            // 
            // labelProductCost
            // 
            this.labelProductCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductCost.AutoSize = true;
            this.labelProductCost.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductCost.Location = new System.Drawing.Point(386, 19);
            this.labelProductCost.Name = "labelProductCost";
            this.labelProductCost.Size = new System.Drawing.Size(99, 32);
            this.labelProductCost.TabIndex = 15;
            this.labelProductCost.Text = "999 ₽";
            this.labelProductCost.Click += new System.EventHandler(this.labelProductCost_Click);
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendMessage.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendMessage.FlatAppearance.BorderSize = 0;
            this.buttonSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendMessage.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendMessage.ForeColor = System.Drawing.Color.White;
            this.buttonSendMessage.Location = new System.Drawing.Point(392, 163);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(210, 60);
            this.buttonSendMessage.TabIndex = 16;
            this.buttonSendMessage.Text = "Связаться с продавцом";
            this.buttonSendMessage.UseVisualStyleBackColor = false;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.Location = new System.Drawing.Point(389, 268);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(213, 45);
            this.labelUserName.TabIndex = 17;
            this.labelUserName.Text = "UserName";
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            this.labelUserName.MouseEnter += new System.EventHandler(this.labelUserName_MouseEnter);
            this.labelUserName.MouseLeave += new System.EventHandler(this.labelUserName_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Адрес";
            // 
            // labelAdress
            // 
            this.labelAdress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdress.Location = new System.Drawing.Point(25, 522);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(358, 42);
            this.labelAdress.TabIndex = 19;
            this.labelAdress.Text = "Adress";
            // 
            // labelProductInfo
            // 
            this.labelProductInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductInfo.Location = new System.Drawing.Point(25, 611);
            this.labelProductInfo.Name = "labelProductInfo";
            this.labelProductInfo.Size = new System.Drawing.Size(358, 224);
            this.labelProductInfo.TabIndex = 21;
            this.labelProductInfo.Text = "Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Описание";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(24, 60);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(70, 23);
            this.labelStatus.TabIndex = 22;
            this.labelStatus.Text = "Status";
            // 
            // buttonShowPhone
            // 
            this.buttonShowPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowPhone.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonShowPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowPhone.FlatAppearance.BorderSize = 0;
            this.buttonShowPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowPhone.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowPhone.ForeColor = System.Drawing.Color.White;
            this.buttonShowPhone.Location = new System.Drawing.Point(392, 97);
            this.buttonShowPhone.Name = "buttonShowPhone";
            this.buttonShowPhone.Size = new System.Drawing.Size(210, 60);
            this.buttonShowPhone.TabIndex = 24;
            this.buttonShowPhone.Text = "Показать телефон";
            this.buttonShowPhone.UseVisualStyleBackColor = false;
            this.buttonShowPhone.Click += new System.EventHandler(this.buttonShowPhone_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(389, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Продавец";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(759, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowPhone);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelProductInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.labelProductCost);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.labelProductName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(775, 593);
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label labelProductCost;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelProductInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonShowPhone;
        private System.Windows.Forms.Label label1;
    }
}