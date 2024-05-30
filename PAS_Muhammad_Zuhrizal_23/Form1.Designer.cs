namespace PAS_Muhammad_Zuhrizal_23
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtUsername.Location = new Point(342, 175);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 32);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(342, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 32);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.Location = new Point(168, 175);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 2;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.Location = new Point(168, 224);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(362, 67);
            label3.Name = "label3";
            label3.Size = new Size(119, 34);
            label3.TabIndex = 4;
            label3.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(493, 227);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(97, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
    }
}
