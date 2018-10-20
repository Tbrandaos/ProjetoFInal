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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblForgetPassword = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(147, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(147, 83);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Senha:";
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblForgetPassword.Location = new System.Drawing.Point(236, 99);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(143, 17);
            this.lblForgetPassword.TabIndex = 2;
            this.lblForgetPassword.Text = "Esqueci minha senha";
            this.lblForgetPassword.Click += new System.EventHandler(this.lblForgetPassword_Click);
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(204, 41);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(128, 23);
            this.tbxName.TabIndex = 3;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(204, 76);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(128, 23);
            this.tbxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(204, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRecover
            // 
            this.btnRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecover.Location = new System.Drawing.Point(204, 94);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(100, 23);
            this.btnRecover.TabIndex = 8;
            this.btnRecover.Text = "Próximo";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Visible = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.Location = new System.Drawing.Point(1, 222);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(100, 50);
            this.pbxBack.TabIndex = 9;
            this.pbxBack.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(501, 274);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblForgetPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Name = "LoginForm";
            this.Text = "Login";
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
    }
}