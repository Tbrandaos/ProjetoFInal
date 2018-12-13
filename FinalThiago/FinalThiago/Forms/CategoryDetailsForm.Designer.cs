namespace FinalThiago.Forms
{
	partial class CategoryDetailsForm
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
			this.PbxSave = new System.Windows.Forms.PictureBox();
			this.pbxDelete = new System.Windows.Forms.PictureBox();
			this.pbxBack = new System.Windows.Forms.PictureBox();
			this.lblId = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PbxSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxActive
			// 
			this.cbxActive.AutoSize = true;
			this.cbxActive.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxActive.Location = new System.Drawing.Point(315, 193);
			this.cbxActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbxActive.Name = "cbxActive";
			this.cbxActive.Size = new System.Drawing.Size(18, 17);
			this.cbxActive.TabIndex = 2;
			this.cbxActive.UseVisualStyleBackColor = true;
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(315, 132);
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
			this.lblActive.Location = new System.Drawing.Point(229, 187);
			this.lblActive.Name = "lblActive";
			this.lblActive.Size = new System.Drawing.Size(56, 24);
			this.lblActive.TabIndex = 33;
			this.lblActive.Text = "Ativo:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(229, 132);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(67, 24);
			this.lblName.TabIndex = 30;
			this.lblName.Text = "Nome:";
			// 
			// PbxSave
			// 
			this.PbxSave.BackColor = System.Drawing.Color.Transparent;
			this.PbxSave.BackgroundImage = global::FinalThiago.Properties.Resources.SaveIcon;
			this.PbxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PbxSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PbxSave.Location = new System.Drawing.Point(629, 395);
			this.PbxSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PbxSave.Name = "PbxSave";
			this.PbxSave.Size = new System.Drawing.Size(76, 43);
			this.PbxSave.TabIndex = 36;
			this.PbxSave.TabStop = false;
			this.PbxSave.Click += new System.EventHandler(this.PbxSave_Click);
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
			this.pbxDelete.TabIndex = 35;
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
			this.pbxBack.TabIndex = 34;
			this.pbxBack.TabStop = false;
			this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.BackColor = System.Drawing.Color.Transparent;
			this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblId.Location = new System.Drawing.Point(229, 11);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(0, 24);
			this.lblId.TabIndex = 37;
			this.lblId.Visible = false;
			// 
			// CategoryDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.cbxActive);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.PbxSave);
			this.Controls.Add(this.pbxDelete);
			this.Controls.Add(this.pbxBack);
			this.Controls.Add(this.lblActive);
			this.Controls.Add(this.lblName);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "CategoryDetailsForm";
			this.Text = "Categoria";
			((System.ComponentModel.ISupportInitialize)(this.PbxSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbxActive;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.PictureBox PbxSave;
		private System.Windows.Forms.PictureBox pbxDelete;
		private System.Windows.Forms.PictureBox pbxBack;
		private System.Windows.Forms.Label lblActive;
		private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
    }
}