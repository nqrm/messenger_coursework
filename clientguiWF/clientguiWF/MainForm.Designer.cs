namespace clientguiWF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listMessages = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.fieldMessage = new System.Windows.Forms.TextBox();
            this.updateLoop = new System.Windows.Forms.Timer(this.components);
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMessages
            // 
            this.listMessages.FormattingEnabled = true;
            this.listMessages.Location = new System.Drawing.Point(12, 12);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(776, 329);
            this.listMessages.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(648, 352);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(140, 85);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message:";
            // 
            // fieldUsername
            // 
            this.fieldUsername.Location = new System.Drawing.Point(110, 360);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.ReadOnly = true;
            this.fieldUsername.Size = new System.Drawing.Size(293, 20);
            this.fieldUsername.TabIndex = 5;
            this.fieldUsername.Text = "You are not logged in";
            // 
            // fieldMessage
            // 
            this.fieldMessage.Location = new System.Drawing.Point(110, 396);
            this.fieldMessage.Multiline = true;
            this.fieldMessage.Name = "fieldMessage";
            this.fieldMessage.Size = new System.Drawing.Size(506, 41);
            this.fieldMessage.TabIndex = 6;
            // 
            // updateLoop
            // 
            this.updateLoop.Enabled = true;
            this.updateLoop.Interval = 500;
            this.updateLoop.Tick += new System.EventHandler(this.updateLoop_Tick);
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(200, 443);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(150, 45);
            this.btnAuth.TabIndex = 7;
            this.btnAuth.Text = "Authentification";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnauth_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(466, 443);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(150, 45);
            this.btnReg.TabIndex = 8;
            this.btnReg.Text = "Registration";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.fieldMessage);
            this.Controls.Add(this.fieldUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.listMessages);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldMessage;
        private System.Windows.Forms.Timer updateLoop;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnReg;
        public System.Windows.Forms.TextBox fieldUsername;
    }
}

