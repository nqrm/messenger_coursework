namespace clientguiWF
{
    partial class AuthentificationForm
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
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.fieldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fieldUsername
            // 
            this.fieldUsername.Location = new System.Drawing.Point(30, 47);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(244, 20);
            this.fieldUsername.TabIndex = 0;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(295, 47);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(127, 96);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // fieldPassword
            // 
            this.fieldPassword.Location = new System.Drawing.Point(30, 123);
            this.fieldPassword.Name = "fieldPassword";
            this.fieldPassword.PasswordChar = '*';
            this.fieldPassword.Size = new System.Drawing.Size(244, 20);
            this.fieldPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // AuthentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 191);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldPassword);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.fieldUsername);
            this.Name = "AuthentificationForm";
            this.Text = "AuthentificationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthentificationForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthentificationForm_FormClosed);
            this.Load += new System.EventHandler(this.AuthentificationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fieldUsername;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox fieldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}