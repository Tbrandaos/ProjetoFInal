namespace FinalThiago.Forms
{
	partial class UserProfileDetails
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
			this.cbxActive = new System.Windows.Forms.CheckBox();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.lblActive = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pbxBack = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxActive
			// 
			this.cbxActive.AutoSize = true;
			this.cbxActive.Location = new System.Drawing.Point(315, 193);
			this.cbxActive.Name = "cbxActive";
			this.cbxActive.Size = new System.Drawing.Size(18, 17);
			this.cbxActive.TabIndex = 2;
			this.cbxActive.UseVisualStyleBackColor = true;
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(315, 132);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(100, 22);
			this.tbxName.TabIndex = 1;
			// 
			// lblActive
			// 
			this.lblActive.AutoSize = true;
			this.lblActive.BackColor = System.Drawing.Color.Transparent;
			this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActive.Location = new System.Drawing.Point(230, 187);
			this.lblActive.Name = "lblActive";
			this.lblActive.Size = new System.Drawing.Size(56, 24);
			this.lblActive.TabIndex = 42;
			this.lblActive.Text = "Ativo:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(230, 132);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(67, 24);
			this.lblName.TabIndex = 41;
			this.lblName.Text = "Nome:";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.BackgroundImage = global::FinalThiago.Properties.Resources.SaveIcon;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Location = new System.Drawing.Point(630, 395);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(76, 43);
			this.pictureBox3.TabIndex = 45;
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
			this.pictureBox2.TabIndex = 44;
			this.pictureBox2.TabStop = false;
			// 
			// pbxBack
			// 
			this.pbxBack.BackColor = System.Drawing.Color.Transparent;
			this.pbxBack.BackgroundImage = global::FinalThiago.Properties.Resources.BackIcon;
			this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxBack.Location = new System.Drawing.Point(12, 395);
			this.pbxBack.Name = "pbxBack";
			this.pbxBack.Size = new System.Drawing.Size(76, 43);
			this.pbxBack.TabIndex = 43;
			this.pbxBack.TabStop = false;
			// 
			// UserProfileDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbxActive);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pbxBack);
			this.Controls.Add(this.lblActive);
			this.Controls.Add(this.lblName);
			this.Name = "UserProfileDetails";
			this.Text = "UserProfileDetails";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbxActive;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pbxBack;
		private System.Windows.Forms.Label lblActive;
		private System.Windows.Forms.Label lblName;
	}
}