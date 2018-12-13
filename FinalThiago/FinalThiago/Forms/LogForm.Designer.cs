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
			this.dgvLog = new System.Windows.Forms.DataGridView();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.pbxBack = new System.Windows.Forms.PictureBox();
			this.pbxClear = new System.Windows.Forms.PictureBox();
			this.pbxSearch = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxClear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvLog
			// 
			this.dgvLog.AllowUserToAddRows = false;
			this.dgvLog.AllowUserToDeleteRows = false;
			this.dgvLog.AllowUserToResizeColumns = false;
			this.dgvLog.AllowUserToResizeRows = false;
			this.dgvLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvLog.Location = new System.Drawing.Point(12, 64);
			this.dgvLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvLog.MultiSelect = false;
			this.dgvLog.Name = "dgvLog";
			this.dgvLog.RowTemplate.Height = 24;
			this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLog.Size = new System.Drawing.Size(776, 329);
			this.dgvLog.TabIndex = 17;
			// 
			// tbxSearch
			// 
			this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxSearch.Location = new System.Drawing.Point(111, 9);
			this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(169, 28);
			this.tbxSearch.TabIndex = 10;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(12, 14);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(98, 24);
			this.lblSearch.TabIndex = 9;
			this.lblSearch.Text = "Pesquisar:";
			// 
			// pbxBack
			// 
			this.pbxBack.BackgroundImage = global::FinalThiago.Properties.Resources.BackIcon;
			this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxBack.Location = new System.Drawing.Point(12, 399);
			this.pbxBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxBack.Name = "pbxBack";
			this.pbxBack.Size = new System.Drawing.Size(76, 43);
			this.pbxBack.TabIndex = 16;
			this.pbxBack.TabStop = false;
			this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
			// 
			// pbxClear
			// 
			this.pbxClear.BackgroundImage = global::FinalThiago.Properties.Resources.ClearIcon;
			this.pbxClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxClear.Location = new System.Drawing.Point(373, 9);
			this.pbxClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxClear.Name = "pbxClear";
			this.pbxClear.Size = new System.Drawing.Size(57, 28);
			this.pbxClear.TabIndex = 15;
			this.pbxClear.TabStop = false;
			this.pbxClear.Click += new System.EventHandler(this.pbxClear_Click);
			// 
			// pbxSearch
			// 
			this.pbxSearch.BackgroundImage = global::FinalThiago.Properties.Resources.SearchIcon;
			this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxSearch.Location = new System.Drawing.Point(297, 9);
			this.pbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbxSearch.Name = "pbxSearch";
			this.pbxSearch.Size = new System.Drawing.Size(57, 28);
			this.pbxSearch.TabIndex = 11;
			this.pbxSearch.TabStop = false;
			// 
			// LogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvLog);
			this.Controls.Add(this.pbxBack);
			this.Controls.Add(this.pbxClear);
			this.Controls.Add(this.pbxSearch);
			this.Controls.Add(this.tbxSearch);
			this.Controls.Add(this.lblSearch);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "LogForm";
			this.Text = "Log";
			((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxClear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvLog;
		private System.Windows.Forms.PictureBox pbxBack;
		private System.Windows.Forms.PictureBox pbxClear;
		private System.Windows.Forms.PictureBox pbxSearch;
		private System.Windows.Forms.TextBox tbxSearch;
		private System.Windows.Forms.Label lblSearch;
	}
}