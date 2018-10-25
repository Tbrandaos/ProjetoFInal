namespace FinalThiago.Forms
{
	partial class LogForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.pbxBack = new System.Windows.Forms.PictureBox();
			this.pbxClear = new System.Windows.Forms.PictureBox();
			this.pbxSearch = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxClear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 64);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(776, 329);
			this.dataGridView1.TabIndex = 17;
			// 
			// tbxSearch
			// 
			this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxSearch.Location = new System.Drawing.Point(111, 9);
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(169, 28);
			this.tbxSearch.TabIndex = 10;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(12, 13);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(98, 24);
			this.lblSearch.TabIndex = 9;
			this.lblSearch.Text = "Pesquisar:";
			// 
			// pbxBack
			// 
			this.pbxBack.BackgroundImage = global::FinalThiago.Properties.Resources.BackIcon;
			this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxBack.Location = new System.Drawing.Point(12, 399);
			this.pbxBack.Name = "pbxBack";
			this.pbxBack.Size = new System.Drawing.Size(76, 43);
			this.pbxBack.TabIndex = 16;
			this.pbxBack.TabStop = false;
			// 
			// pbxClear
			// 
			this.pbxClear.BackgroundImage = global::FinalThiago.Properties.Resources.ClearIcon;
			this.pbxClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxClear.Location = new System.Drawing.Point(373, 9);
			this.pbxClear.Name = "pbxClear";
			this.pbxClear.Size = new System.Drawing.Size(57, 28);
			this.pbxClear.TabIndex = 15;
			this.pbxClear.TabStop = false;
			// 
			// pbxSearch
			// 
			this.pbxSearch.BackgroundImage = global::FinalThiago.Properties.Resources.SearchIcon;
			this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxSearch.Location = new System.Drawing.Point(297, 9);
			this.pbxSearch.Name = "pbxSearch";
			this.pbxSearch.Size = new System.Drawing.Size(57, 28);
			this.pbxSearch.TabIndex = 11;
			this.pbxSearch.TabStop = false;
			// 
			// LogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pbxBack);
			this.Controls.Add(this.pbxClear);
			this.Controls.Add(this.pbxSearch);
			this.Controls.Add(this.tbxSearch);
			this.Controls.Add(this.lblSearch);
			this.Name = "LogForm";
			this.Text = "LogForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxClear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pbxBack;
		private System.Windows.Forms.PictureBox pbxClear;
		private System.Windows.Forms.PictureBox pbxSearch;
		private System.Windows.Forms.TextBox tbxSearch;
		private System.Windows.Forms.Label lblSearch;
	}
}