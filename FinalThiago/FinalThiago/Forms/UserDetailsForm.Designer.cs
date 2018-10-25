namespace FinalThiago.Forms
{
	partial class UserDetailsForm
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
			this.lblName = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblConfirmPassword = new System.Windows.Forms.Label();
			this.lblProfile = new System.Windows.Forms.Label();
			this.lblActive = new System.Windows.Forms.Label();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
			this.tbxPassword = new System.Windows.Forms.TextBox();
			this.tbxEmail = new System.Windows.Forms.TextBox();
			this.cmbProfile = new System.Windows.Forms.ComboBox();
			this.cbxActive = new System.Windows.Forms.CheckBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pbxBack = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(258, 36);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(67, 24);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Nome:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.BackColor = System.Drawing.Color.Transparent;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(258, 85);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(62, 24);
			this.lblEmail.TabIndex = 1;
			this.lblEmail.Text = "Email:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(258, 132);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(70, 24);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Senha:";
			// 
			// lblConfirmPassword
			// 
			this.lblConfirmPassword.AutoSize = true;
			this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirmPassword.Location = new System.Drawing.Point(175, 180);
			this.lblConfirmPassword.Name = "lblConfirmPassword";
			this.lblConfirmPassword.Size = new System.Drawing.Size(153, 24);
			this.lblConfirmPassword.TabIndex = 3;
			this.lblConfirmPassword.Text = "Confirmar senha:";
			// 
			// lblProfile
			// 
			this.lblProfile.AutoSize = true;
			this.lblProfile.BackColor = System.Drawing.Color.Transparent;
			this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProfile.Location = new System.Drawing.Point(258, 229);
			this.lblProfile.Name = "lblProfile";
			this.lblProfile.Size = new System.Drawing.Size(56, 24);
			this.lblProfile.TabIndex = 4;
			this.lblProfile.Text = "Perfil:";
			// 
			// lblActive
			// 
			this.lblActive.AutoSize = true;
			this.lblActive.BackColor = System.Drawing.Color.Transparent;
			this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActive.Location = new System.Drawing.Point(258, 278);
			this.lblActive.Name = "lblActive";
			this.lblActive.Size = new System.Drawing.Size(56, 24);
			this.lblActive.TabIndex = 5;
			this.lblActive.Text = "Ativo:";
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(346, 38);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(100, 22);
			this.tbxName.TabIndex = 1;
			// 
			// tbxConfirmPassword
			// 
			this.tbxConfirmPassword.Location = new System.Drawing.Point(346, 180);
			this.tbxConfirmPassword.Name = "tbxConfirmPassword";
			this.tbxConfirmPassword.Size = new System.Drawing.Size(100, 22);
			this.tbxConfirmPassword.TabIndex = 4;
			// 
			// tbxPassword
			// 
			this.tbxPassword.Location = new System.Drawing.Point(346, 132);
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.Size = new System.Drawing.Size(100, 22);
			this.tbxPassword.TabIndex = 3;
			// 
			// tbxEmail
			// 
			this.tbxEmail.Location = new System.Drawing.Point(346, 85);
			this.tbxEmail.Name = "tbxEmail";
			this.tbxEmail.Size = new System.Drawing.Size(100, 22);
			this.tbxEmail.TabIndex = 2;
			// 
			// cmbProfile
			// 
			this.cmbProfile.FormattingEnabled = true;
			this.cmbProfile.Location = new System.Drawing.Point(346, 229);
			this.cmbProfile.Name = "cmbProfile";
			this.cmbProfile.Size = new System.Drawing.Size(121, 24);
			this.cmbProfile.TabIndex = 5;
			// 
			// cbxActive
			// 
			this.cbxActive.AutoSize = true;
			this.cbxActive.Location = new System.Drawing.Point(346, 285);
			this.cbxActive.Name = "cbxActive";
			this.cbxActive.Size = new System.Drawing.Size(18, 17);
			this.cbxActive.TabIndex = 6;
			this.cbxActive.UseVisualStyleBackColor = true;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.BackgroundImage = global::FinalThiago.Properties.Resources.SaveIcon;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Location = new System.Drawing.Point(621, 395);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(76, 43);
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = global::FinalThiago.Properties.Resources.DeleteIcon;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(712, 395);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(76, 43);
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// pbxBack
			// 
			this.pbxBack.BackColor = System.Drawing.Color.Transparent;
			this.pbxBack.BackgroundImage = global::FinalThiago.Properties.Resources.BackIcon;
			this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxBack.Location = new System.Drawing.Point(12, 388);
			this.pbxBack.Name = "pbxBack";
			this.pbxBack.Size = new System.Drawing.Size(76, 43);
			this.pbxBack.TabIndex = 6;
			this.pbxBack.TabStop = false;
			// 
			// UserDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbxActive);
			this.Controls.Add(this.cmbProfile);
			this.Controls.Add(this.tbxEmail);
			this.Controls.Add(this.tbxPassword);
			this.Controls.Add(this.tbxConfirmPassword);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pbxBack);
			this.Controls.Add(this.lblActive);
			this.Controls.Add(this.lblProfile);
			this.Controls.Add(this.lblConfirmPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblName);
			this.Name = "UserDetailsForm";
			this.Text = "UserDetailsForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblProfile;
		private System.Windows.Forms.Label lblActive;
		private System.Windows.Forms.PictureBox pbxBack;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.TextBox tbxConfirmPassword;
		private System.Windows.Forms.TextBox tbxPassword;
		private System.Windows.Forms.TextBox tbxEmail;
		private System.Windows.Forms.ComboBox cmbProfile;
		private System.Windows.Forms.CheckBox cbxActive;
		private System.Windows.Forms.Label lblConfirmPassword;
	}
}