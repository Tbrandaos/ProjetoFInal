namespace FinalThiago.Forms
{
	partial class ProductAllForm
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
			this.lblSearch = new System.Windows.Forms.Label();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.pbxBack = new System.Windows.Forms.PictureBox();
			this.pbxClear = new System.Windows.Forms.PictureBox();
			this.pbxDelete = new System.Windows.Forms.PictureBox();
			this.pbxEdit = new System.Windows.Forms.PictureBox();
			this.pbxAdd = new System.Windows.Forms.PictureBox();
			this.pbxSearch = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxClear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(12, 9);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(98, 24);
			this.lblSearch.TabIndex = 0;
			this.lblSearch.Text = "Pesquisar:";
			// 
			// tbxSearch
			// 
			this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxSearch.Location = new System.Drawing.Point(111, 5);
			this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(169, 28);
			this.tbxSearch.TabIndex = 1;
			// 
			// dgvProduct
			// 
			this.dgvProduct.AllowUserToAddRows = false;
			this.dgvProduct.AllowUserToDeleteRows = false;
			this.dgvProduct.AllowUserToResizeColumns = false;
			this.dgvProduct.AllowUserToResizeRows = false;
			this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvProduct.Location = new System.Drawing.Point(12, 60);
			this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvProduct.MultiSelect = false;
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.RowTemplate.Height = 24;
			this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProduct.Size = new System.Drawing.Size(776, 329);
			this.dgvProduct.TabIndex = 8;
			// 
			// pbxBack
			// 
			this.pbxBack.BackgroundImage = global::FinalThiago.Properties.Resources.BackIcon;
			this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxBack.Location = new System.Drawing.Point(12, 395);
			this.pbxBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxBack.Name = "pbxBack";
			this.pbxBack.Size = new System.Drawing.Size(76, 43);
			this.pbxBack.TabIndex = 7;
			this.pbxBack.TabStop = false;
			this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
			// 
			// pbxClear
			// 
			this.pbxClear.BackgroundImage = global::FinalThiago.Properties.Resources.ClearIcon;
			this.pbxClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxClear.Location = new System.Drawing.Point(373, 5);
			this.pbxClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxClear.Name = "pbxClear";
			this.pbxClear.Size = new System.Drawing.Size(57, 28);
			this.pbxClear.TabIndex = 6;
			this.pbxClear.TabStop = false;
			this.pbxClear.Click += new System.EventHandler(this.pbxClear_Click);
			// 
			// pbxDelete
			// 
			this.pbxDelete.BackgroundImage = global::FinalThiago.Properties.Resources.DeleteIcon;
			this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxDelete.Location = new System.Drawing.Point(579, 395);
			this.pbxDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxDelete.Name = "pbxDelete";
			this.pbxDelete.Size = new System.Drawing.Size(76, 43);
			this.pbxDelete.TabIndex = 5;
			this.pbxDelete.TabStop = false;
			this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
			// 
			// pbxEdit
			// 
			this.pbxEdit.BackgroundImage = global::FinalThiago.Properties.Resources.EditIcon;
			this.pbxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxEdit.Location = new System.Drawing.Point(685, 395);
			this.pbxEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxEdit.Name = "pbxEdit";
			this.pbxEdit.Size = new System.Drawing.Size(76, 43);
			this.pbxEdit.TabIndex = 4;
			this.pbxEdit.TabStop = false;
			this.pbxEdit.Click += new System.EventHandler(this.pbxEdit_Click);
			// 
			// pbxAdd
			// 
			this.pbxAdd.BackgroundImage = global::FinalThiago.Properties.Resources.AddIcon;
			this.pbxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxAdd.Location = new System.Drawing.Point(483, 395);
			this.pbxAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxAdd.Name = "pbxAdd";
			this.pbxAdd.Size = new System.Drawing.Size(76, 43);
			this.pbxAdd.TabIndex = 3;
			this.pbxAdd.TabStop = false;
			this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
			// 
			// pbxSearch
			// 
			this.pbxSearch.BackgroundImage = global::FinalThiago.Properties.Resources.SearchIcon;
			this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxSearch.Location = new System.Drawing.Point(297, 5);
			this.pbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxSearch.Name = "pbxSearch";
			this.pbxSearch.Size = new System.Drawing.Size(57, 28);
			this.pbxSearch.TabIndex = 2;
			this.pbxSearch.TabStop = false;
			this.pbxSearch.Click += new System.EventHandler(this.pbxSearch_Click);
			// 
			// ProductAllForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvProduct);
			this.Controls.Add(this.pbxBack);
			this.Controls.Add(this.pbxClear);
			this.Controls.Add(this.pbxDelete);
			this.Controls.Add(this.pbxEdit);
			this.Controls.Add(this.pbxAdd);
			this.Controls.Add(this.pbxSearch);
			this.Controls.Add(this.tbxSearch);
			this.Controls.Add(this.lblSearch);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ProductAllForm";
			this.Text = "Produto";
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxClear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox tbxSearch;
		private System.Windows.Forms.PictureBox pbxSearch;
		private System.Windows.Forms.PictureBox pbxAdd;
		private System.Windows.Forms.PictureBox pbxEdit;
		private System.Windows.Forms.PictureBox pbxDelete;
		private System.Windows.Forms.PictureBox pbxClear;
		private System.Windows.Forms.PictureBox pbxBack;
		private System.Windows.Forms.DataGridView dgvProduct;
	}
}