namespace PAS_Muhammad_Zuhrizal_23
{
    partial class Profile_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Page));
            label1 = new Label();
            label2 = new Label();
            btnBuy = new Button();
            pictureBox1 = new PictureBox();
            btnOrder = new Button();
            label3 = new Label();
            label4 = new Label();
            label_username = new Label();
            label_password = new Label();
            button1 = new Button();
            panel2 = new Panel();
            label9 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            btnBack = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 121);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 167);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 1;
            label2.Text = "password :";
            // 
            // btnBuy
            // 
            btnBuy.BackgroundImage = (Image)resources.GetObject("btnBuy.BackgroundImage");
            btnBuy.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuy.Location = new Point(604, 302);
            btnBuy.Margin = new Padding(5, 4, 5, 4);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(53, 42);
            btnBuy.TabIndex = 2;
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.COMMS_RIZALP1_BGWHITE;
            pictureBox1.Location = new Point(115, 96);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.BackgroundImage = (Image)resources.GetObject("btnOrder.BackgroundImage");
            btnOrder.BackgroundImageLayout = ImageLayout.Zoom;
            btnOrder.Location = new Point(441, 306);
            btnOrder.Margin = new Padding(5, 4, 5, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(46, 38);
            btnOrder.TabIndex = 4;
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 311);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 5;
            label3.Text = "MY ORDER";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 311);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 6;
            label4.Text = "BUY";
            label4.Click += label4_Click;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(472, 121);
            label_username.Name = "label_username";
            label_username.Size = new Size(185, 25);
            label_username.TabIndex = 7;
            label_username.Text = "username_user";
            label_username.Click += label_username_Click;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(472, 167);
            label_password.Name = "label_password";
            label_password.Size = new Size(184, 25);
            label_password.TabIndex = 8;
            label_password.Text = "password_user";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(545, 222);
            button1.Name = "button1";
            button1.Size = new Size(113, 34);
            button1.TabIndex = 9;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(label9);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 57);
            panel2.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(277, 10);
            label9.Name = "label9";
            label9.Size = new Size(276, 41);
            label9.TabIndex = 16;
            label9.Text = "Welcome Readers!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-1, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(87, 396);
            panel1.TabIndex = 25;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 197);
            button2.Name = "button2";
            button2.Size = new Size(74, 35);
            button2.TabIndex = 26;
            button2.Text = "Order";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1, 354);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 29);
            btnBack.TabIndex = 26;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 238);
            button3.Name = "button3";
            button3.Size = new Size(84, 29);
            button3.TabIndex = 26;
            button3.Text = "My Order";
            button3.UseVisualStyleBackColor = true;
            // 
            // Profile_Page
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label_password);
            Controls.Add(label_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnOrder);
            Controls.Add(pictureBox1);
            Controls.Add(btnBuy);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Profile_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBuy;
        private PictureBox pictureBox1;
        private Button btnOrder;
        private Label label3;
        private Label label4;
        private Label label_username;
        private Label label_password;
        private Button button1;
        private Panel panel2;
        private Label label9;
        private Panel panel1;
        private Button button2;
        private Button btnBack;
        private Button button3;
    }
}