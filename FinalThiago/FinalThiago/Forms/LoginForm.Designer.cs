namespace FinalThiago.Forms
{
    partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.lblName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblForgetPassword = new System.Windows.Forms.Label();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.tbxPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnRecover = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pbxBack = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(453, 113);
			this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(67, 24);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Nome:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(453, 150);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(70, 24);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Senha:";
			// 
			// lblForgetPassword
			// 
			this.lblForgetPassword.AutoSize = true;
			this.lblForgetPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblForgetPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblForgetPassword.Location = new System.Drawing.Point(594, 177);
			this.lblForgetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblForgetPassword.Name = "lblForgetPassword";
			this.lblForgetPassword.Size = new System.Drawing.Size(193, 24);
			this.lblForgetPassword.TabIndex = 2;
			this.lblForgetPassword.Text = "Esqueci minha senha";
			this.lblForgetPassword.Click += new System.EventHandler(this.lblForgetPassword_Click);
			// 
			// tbxName
			// 
			this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxName.Location = new System.Drawing.Point(531, 109);
			this.tbxName.Margin = new System.Windows.Forms.Padding(4);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(169, 28);
			this.tbxName.TabIndex = 3;
			// 
			// tbxPassword
			// 
			this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxPassword.Location = new System.Drawing.Point(531, 145);
			this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.Size = new System.Drawing.Size(169, 28);
			this.tbxPassword.TabIndex = 4;
			// 
			// btnLogin
			// 
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(531, 205);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(100, 32);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			// 
			// btnRecover
			// 
			this.btnRecover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRecover.Location = new System.Drawing.Point(531, 205);
			this.btnRecover.Margin = new System.Windows.Forms.Padding(4);
			this.btnRecover.Name = "btnRecover";
			this.btnRecover.Size = new System.Drawing.Size(133, 28);
			this.btnRecover.TabIndex = 8;
			this.btnRecover.Text = "Próximo";
			this.btnRecover.UseVisualStyleBackColor = true;
			this.btnRecover.Visible = false;
			this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(344, 449);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// pbxBack
			// 
			this.pbxBack.BackgroundImage = global::FinalThiago.Properties.Resources.BackIcon;
			this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxBack.Location = new System.Drawing.Point(351, 394);
			this.pbxBack.Margin = new System.Windows.Forms.Padding(4);
			this.pbxBack.Name = "pbxBack";
			this.pbxBack.Size = new System.Drawing.Size(98, 43);
			this.pbxBack.TabIndex = 9;
			this.pbxBack.TabStop = false;
			this.pbxBack.Visible = false;
			this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click_1);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pbxBack);
			this.Controls.Add(this.btnRecover);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.tbxPassword);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.lblForgetPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblName);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LoginForm";
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblForgetPassword;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.PictureBox pbxBack;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}