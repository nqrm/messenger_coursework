namespace clientguiWF
{
    partial class RegistrationForm
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
            this.fieldPass1 = new System.Windows.Forms.TextBox();
            this.fieldPass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fieldUsername
            // 
            this.fieldUsername.Location = new System.Drawing.Point(15, 55);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(264, 20);
            this.fieldUsername.TabIndex = 0;
            // 
            // fieldPass1
            // 
            this.fieldPass1.Location = new System.Drawing.Point(15, 130);
            this.fieldPass1.Name = "fieldPass1";
            this.fieldPass1.PasswordChar = '*';
            this.fieldPass1.Size = new System.Drawing.Size(264, 20);
            this.fieldPass1.TabIndex = 1;
            // 
            // fieldPass2
            // 
            this.fieldPass2.Location = new System.Drawing.Point(15, 205);
            this.fieldPass2.Name = "fieldPass2";
            this.fieldPass2.PasswordChar = '*';
            this.fieldPass2.Size = new System.Drawing.Size(264, 20);
            this.fieldPass2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Retype Password:";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(314, 103);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(120, 88);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Registration";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 248);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldPass2);
            this.Controls.Add(this.fieldPass1);
            this.Controls.Add(this.fieldUsername);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fieldUsername;
        private System.Windows.Forms.TextBox fieldPass1;
        private System.Windows.Forms.TextBox fieldPass2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReg;
    }
}