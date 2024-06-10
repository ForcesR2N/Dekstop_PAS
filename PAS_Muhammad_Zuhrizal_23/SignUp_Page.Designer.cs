namespace PAS_Muhammad_Zuhrizal_23
{
    partial class SignUp_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_Page));
            label6 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(124, 207, 244);
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(262, 452);
            label6.Name = "label6";
            label6.Size = new Size(52, 18);
            label6.TabIndex = 23;
            label6.Text = "Login";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(124, 207, 244);
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(62, 452);
            label5.Name = "label5";
            label5.Size = new Size(199, 18);
            label5.TabIndex = 22;
            label5.Text = "Already have an account?";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(432, 411);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(432, 411);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 79);
            label4.Name = "label4";
            label4.Size = new Size(216, 53);
            label4.TabIndex = 19;
            label4.Text = "account";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(37, 176, 239);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(201, 571);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 57);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Create";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 26);
            label3.Name = "label3";
            label3.Size = new Size(346, 53);
            label3.TabIndex = 16;
            label3.Text = "Create a new";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(124, 207, 244);
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 368);
            label2.Name = "label2";
            label2.Size = new Size(239, 25);
            label2.TabIndex = 15;
            label2.Text = "CREATE PASSWORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(124, 207, 244);
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 259);
            label1.Name = "label1";
            label1.Size = new Size(233, 25);
            label1.TabIndex = 14;
            label1.Text = "CREATE USERNAME";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ButtonHighlight;
            txtPassword.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(62, 407);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(411, 32);
            txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtUsername.Location = new Point(62, 301);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(411, 32);
            txtUsername.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 800);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // SignUp_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 753);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "SignUp_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label4;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
    }
}