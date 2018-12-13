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
			this.pbxSave = new System.Windows.Forms.PictureBox();
			this.pbxDelete = new System.Windows.Forms.PictureBox();
			this.pbxBack = new System.Windows.Forms.PictureBox();
			this.lblId = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxActive
			// 
			this.cbxActive.AutoSize = true;
			this.cbxActive.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxActive.Location = new System.Drawing.Point(337, 272);
			this.cbxActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbxActive.Name = "cbxActive";
			this.cbxActive.Size = new System.Drawing.Size(18, 17);
			this.cbxActive.TabIndex = 4;
			this.cbxActive.UseVisualStyleBackColor = true;
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(337, 226);
			this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(121, 24);
			this.cmbCategory.TabIndex = 3;
			// 
			// tbxPrice
			// 
			this.tbxPrice.Location = new System.Drawing.Point(337, 178);
			this.tbxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbxPrice.Name = "tbxPrice";
			this.tbxPrice.Size = new System.Drawing.Size(100, 22);
			this.tbxPrice.TabIndex = 2;
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(337, 134);
			this.tbxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(100, 22);
			this.tbxName.TabIndex = 1;
			// 
			// lblActive
			// 
			this.lblActive.AutoSize = true;
			this.lblActive.BackColor = System.Drawing.Color.Transparent;
			this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActive.Location = new System.Drawing.Point(229, 266);
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
			this.lblCategory.Location = new System.Drawing.Point(229, 226);
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
			this.lblPrice.Location = new System.Drawing.Point(229, 178);
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
			this.lblName.Location = new System.Drawing.Point(229, 134);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(67, 24);
			this.lblName.TabIndex = 15;
			this.lblName.Text = "Nome:";
			// 
			// pbxSave
			// 
			this.pbxSave.BackColor = System.Drawing.Color.Transparent;
			this.pbxSave.BackgroundImage = global::FinalThiago.Properties.Resources.SaveIcon;
			this.pbxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxSave.Location = new System.Drawing.Point(611, 395);
			this.pbxSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxSave.Name = "pbxSave";
			this.pbxSave.Size = new System.Drawing.Size(76, 43);
			this.pbxSave.TabIndex = 23;
			this.pbxSave.TabStop = false;
			this.pbxSave.Click += new System.EventHandler(this.pbxSave_Click);
			// 
			// pbxDelete
			// 
			this.pbxDelete.BackColor = System.Drawing.Color.Transparent;
			this.pbxDelete.BackgroundImage = global::FinalThiago.Properties.Resources.DeleteIcon;
			this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxDelete.Location = new System.Drawing.Point(712, 395);
			this.pbxDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxDelete.Name = "pbxDelete";
			this.pbxDelete.Size = new System.Drawing.Size(76, 43);
			this.pbxDelete.TabIndex = 22;
			this.pbxDelete.TabStop = false;
			this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
			// 
			// pbxBack
			// 
			this.pbxBack.BackColor = System.Drawing.Color.Transparent;
			this.pbxBack.BackgroundImage = global::FinalThiago.Properties.Resources.BackIcon;
			this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxBack.Location = new System.Drawing.Point(12, 395);
			this.pbxBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxBack.Name = "pbxBack";
			this.pbxBack.Size = new System.Drawing.Size(76, 43);
			this.pbxBack.TabIndex = 21;
			this.pbxBack.TabStop = false;
			this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.BackColor = System.Drawing.Color.Transparent;
			this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblId.Location = new System.Drawing.Point(229, 36);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(0, 24);
			this.lblId.TabIndex = 24;
			this.lblId.Visible = false;
			// 
			// ProductDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.cbxActive);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.tbxPrice);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.pbxSave);
			this.Controls.Add(this.pbxDelete);
			this.Controls.Add(this.pbxBack);
			this.Controls.Add(this.lblActive);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.lblName);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ProductDetailsForm";
			this.Text = "Produto";
			((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbxActive;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.TextBox tbxPrice;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.PictureBox pbxSave;
		private System.Windows.Forms.PictureBox pbxDelete;
		private System.Windows.Forms.PictureBox pbxBack;
		private System.Windows.Forms.Label lblActive;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
    }
}