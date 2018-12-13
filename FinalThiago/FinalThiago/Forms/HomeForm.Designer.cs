namespace FinalThiago.Forms
{
    partial class HomeForm
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
			this.lblProduct = new System.Windows.Forms.Label();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblUserProfile = new System.Windows.Forms.Label();
			this.lblLog = new System.Windows.Forms.Label();
			this.pbxLog = new System.Windows.Forms.PictureBox();
			this.pbxCategory = new System.Windows.Forms.PictureBox();
			this.pbxUser = new System.Windows.Forms.PictureBox();
			this.pbxUserProfile = new System.Windows.Forms.PictureBox();
			this.pbxBack = new System.Windows.Forms.PictureBox();
			this.pbxProduct = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbxLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.BackColor = System.Drawing.Color.Transparent;
			this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProduct.Location = new System.Drawing.Point(181, 98);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(76, 24);
			this.lblProduct.TabIndex = 6;
			this.lblProduct.Text = "Produto";
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.BackColor = System.Drawing.Color.Transparent;
			this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCategory.Location = new System.Drawing.Point(563, 98);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(90, 24);
			this.lblCategory.TabIndex = 7;
			this.lblCategory.Text = "Categoria";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.BackColor = System.Drawing.Color.Transparent;
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(181, 316);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(74, 24);
			this.lblUser.TabIndex = 8;
			this.lblUser.Text = "Usuário";
			// 
			// lblUserProfile
			// 
			this.lblUserProfile.AutoSize = true;
			this.lblUserProfile.BackColor = System.Drawing.Color.Transparent;
			this.lblUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserProfile.Location = new System.Drawing.Point(535, 316);
			this.lblUserProfile.Name = "lblUserProfile";
			this.lblUserProfile.Size = new System.Drawing.Size(147, 24);
			this.lblUserProfile.TabIndex = 9;
			this.lblUserProfile.Text = "Perfil de Usuário";
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.BackColor = System.Drawing.Color.Transparent;
			this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLog.Location = new System.Drawing.Point(387, 210);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(37, 20);
			this.lblLog.TabIndex = 11;
			this.lblLog.Text = "Log";
			// 
			// pbxLog
			// 
			this.pbxLog.BackgroundImage = global::FinalThiago.Properties.Resources.LogIcon;
			this.pbxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxLog.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxLog.Location = new System.Drawing.Point(341, 146);
			this.pbxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxLog.Name = "pbxLog";
			this.pbxLog.Size = new System.Drawing.Size(133, 62);
			this.pbxLog.TabIndex = 11;
			this.pbxLog.TabStop = false;
			this.pbxLog.Click += new System.EventHandler(this.pbxLog_Click);
			this.pbxLog.MouseEnter += new System.EventHandler(this.pbxLog_MouseEnter);
			this.pbxLog.MouseLeave += new System.EventHandler(this.pbxLog_MouseLeave);
			// 
			// pbxCategory
			// 
			this.pbxCategory.BackColor = System.Drawing.Color.Transparent;
			this.pbxCategory.BackgroundImage = global::FinalThiago.Properties.Resources.CategoryIcon2;
			this.pbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxCategory.Location = new System.Drawing.Point(539, 33);
			this.pbxCategory.Margin = new System.Windows.Forms.Padding(4);
			this.pbxCategory.Name = "pbxCategory";
			this.pbxCategory.Size = new System.Drawing.Size(133, 62);
			this.pbxCategory.TabIndex = 5;
			this.pbxCategory.TabStop = false;
			this.pbxCategory.Click += new System.EventHandler(this.pbxCategory_Click);
			this.pbxCategory.MouseEnter += new System.EventHandler(this.pbxCategory_MouseEnter);
			this.pbxCategory.MouseLeave += new System.EventHandler(this.pbxCategory_MouseLeave);
			// 
			// pbxUser
			// 
			this.pbxUser.BackColor = System.Drawing.Color.Transparent;
			this.pbxUser.BackgroundImage = global::FinalThiago.Properties.Resources.UserIcon;
			this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxUser.Location = new System.Drawing.Point(151, 250);
			this.pbxUser.Margin = new System.Windows.Forms.Padding(4);
			this.pbxUser.Name = "pbxUser";
			this.pbxUser.Size = new System.Drawing.Size(133, 62);
			this.pbxUser.TabIndex = 4;
			this.pbxUser.TabStop = false;
			this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
			this.pbxUser.MouseEnter += new System.EventHandler(this.pbxUser_MouseEnter);
			this.pbxUser.MouseLeave += new System.EventHandler(this.pbxUser_MouseLeave);
			// 
			// pbxUserProfile
			// 
			this.pbxUserProfile.BackColor = System.Drawing.Color.Transparent;
			this.pbxUserProfile.BackgroundImage = global::FinalThiago.Properties.Resources.UserProfileIcon;
			this.pbxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxUserProfile.Location = new System.Drawing.Point(539, 250);
			this.pbxUserProfile.Margin = new System.Windows.Forms.Padding(4);
			this.pbxUserProfile.Name = "pbxUserProfile";
			this.pbxUserProfile.Size = new System.Drawing.Size(133, 62);
			this.pbxUserProfile.TabIndex = 3;
			this.pbxUserProfile.TabStop = false;
			this.pbxUserProfile.Click += new System.EventHandler(this.pbxUserProfile_Click);
			this.pbxUserProfile.MouseEnter += new System.EventHandler(this.pbxUserProfile_MouseEnter);
			this.pbxUserProfile.MouseLeave += new System.EventHandler(this.pbxUserProfile_MouseLeave);
			// 
			// pbxBack
			// 
			this.pbxBack.BackColor = System.Drawing.Color.Transparent;
			this.pbxBack.BackgroundImage = global::FinalThiago.Properties.Resources.BackIcon;
			this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxBack.Location = new System.Drawing.Point(13, 394);
			this.pbxBack.Margin = new System.Windows.Forms.Padding(4);
			this.pbxBack.Name = "pbxBack";
			this.pbxBack.Size = new System.Drawing.Size(99, 43);
			this.pbxBack.TabIndex = 1;
			this.pbxBack.TabStop = false;
			this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
			// 
			// pbxProduct
			// 
			this.pbxProduct.BackColor = System.Drawing.Color.Transparent;
			this.pbxProduct.BackgroundImage = global::FinalThiago.Properties.Resources.ProductIcon;
			this.pbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxProduct.Location = new System.Drawing.Point(151, 33);
			this.pbxProduct.Margin = new System.Windows.Forms.Padding(4);
			this.pbxProduct.Name = "pbxProduct";
			this.pbxProduct.Size = new System.Drawing.Size(133, 62);
			this.pbxProduct.TabIndex = 0;
			this.pbxProduct.TabStop = false;
			this.pbxProduct.Click += new System.EventHandler(this.pbxProduct_Click);
			this.pbxProduct.MouseEnter += new System.EventHandler(this.pbxProduct_MouseEnter);
			this.pbxProduct.MouseLeave += new System.EventHandler(this.pbxProduct_MouseLeave);
			// 
			// HomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pbxLog);
			this.Controls.Add(this.lblLog);
			this.Controls.Add(this.lblUserProfile);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.lblProduct);
			this.Controls.Add(this.pbxCategory);
			this.Controls.Add(this.pbxUser);
			this.Controls.Add(this.pbxUserProfile);
			this.Controls.Add(this.pbxBack);
			this.Controls.Add(this.pbxProduct);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "HomeForm";
			this.Text = "Home";
			((System.ComponentModel.ISupportInitialize)(this.pbxLog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxProduct;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxUserProfile;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox pbxCategory;
		private System.Windows.Forms.Label lblProduct;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblUserProfile;
		private System.Windows.Forms.Label lblLog;
		private System.Windows.Forms.PictureBox pbxLog;
	}
}