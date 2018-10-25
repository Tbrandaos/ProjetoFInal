namespace FinalThiago.Forms
{
	partial class ProductDetailsForm
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
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.tbxPrice = new System.Windows.Forms.TextBox();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.lblActive = new System.Windows.Forms.Label();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
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
			this.cbxActive.Location = new System.Drawing.Point(337, 272);
			this.cbxActive.Name = "cbxActive";
			this.cbxActive.Size = new System.Drawing.Size(18, 17);
			this.cbxActive.TabIndex = 4;
			this.cbxActive.UseVisualStyleBackColor = true;
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(337, 226);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(121, 24);
			this.cmbCategory.TabIndex = 3;
			// 
			// tbxPrice
			// 
			this.tbxPrice.Location = new System.Drawing.Point(337, 178);
			this.tbxPrice.Name = "tbxPrice";
			this.tbxPrice.Size = new System.Drawing.Size(100, 22);
			this.tbxPrice.TabIndex = 2;
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(337, 134);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(100, 22);
			this.tbxName.TabIndex = 1;
			// 
			// lblActive
			// 
			this.lblActive.AutoSize = true;
			this.lblActive.BackColor = System.Drawing.Color.Transparent;
			this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActive.Location = new System.Drawing.Point(230, 266);
			this.lblActive.Name = "lblActive";
			this.lblActive.Size = new System.Drawing.Size(56, 24);
			this.lblActive.TabIndex = 20;
			this.lblActive.Text = "Ativo:";
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.BackColor = System.Drawing.Color.Transparent;
			this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCategory.Location = new System.Drawing.Point(230, 226);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(95, 24);
			this.lblCategory.TabIndex = 19;
			this.lblCategory.Text = "Categoria:";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.BackColor = System.Drawing.Color.Transparent;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.Location = new System.Drawing.Point(230, 178);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(65, 24);
			this.lblPrice.TabIndex = 18;
			this.lblPrice.Text = "Preço:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(230, 134);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(67, 24);
			this.lblName.TabIndex = 15;
			this.lblName.Text = "Nome:";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.BackgroundImage = global::FinalThiago.Properties.Resources.SaveIcon;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Location = new System.Drawing.Point(610, 395);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(76, 43);
			this.pictureBox3.TabIndex = 23;
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
			this.pictureBox2.TabIndex = 22;
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
			this.pbxBack.TabIndex = 21;
			this.pbxBack.TabStop = false;
			// 
			// ProductDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbxActive);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.tbxPrice);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pbxBack);
			this.Controls.Add(this.lblActive);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.lblName);
			this.Name = "ProductDetailsForm";
			this.Text = "ProductDetailsForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbxActive;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.TextBox tbxPrice;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pbxBack;
		private System.Windows.Forms.Label lblActive;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblName;
	}
}