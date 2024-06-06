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
            btnBuy = new Button();
            pictureBox1 = new PictureBox();
            btnOrder = new Button();
            label3 = new Label();
            label4 = new Label();
            label_username = new Label();
            label_password = new Label();
            button1 = new Button();
            btnBack = new Button();
            panel2 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnBuy
            // 
            btnBuy.BackgroundImage = (Image)resources.GetObject("btnBuy.BackgroundImage");
            btnBuy.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuy.Location = new Point(446, 519);
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
            pictureBox1.Location = new Point(252, 174);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.BackgroundImage = (Image)resources.GetObject("btnOrder.BackgroundImage");
            btnOrder.BackgroundImageLayout = ImageLayout.Zoom;
            btnOrder.Location = new Point(443, 458);
            btnOrder.Margin = new Padding(5, 4, 5, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(53, 43);
            btnOrder.TabIndex = 4;
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(181, 456);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(12);
            label3.Size = new Size(318, 49);
            label3.TabIndex = 5;
            label3.Text = "PURCHASE HISTORY       ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(181, 516);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(12);
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(321, 49);
            label4.TabIndex = 6;
            label4.Text = "BUY BOOK                        ";
            label4.Click += label4_Click;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(280, 341);
            label_username.Name = "label_username";
            label_username.Size = new Size(185, 25);
            label_username.TabIndex = 7;
            label_username.Text = "username_user";
            label_username.Click += label_username_Click;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(280, 315);
            label_password.Name = "label_password";
            label_password.Size = new Size(184, 25);
            label_password.TabIndex = 8;
            label_password.Text = "password_user";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(181, 573);
            button1.Name = "button1";
            button1.Size = new Size(321, 34);
            button1.TabIndex = 9;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(742, 567);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 29);
            btnBack.TabIndex = 26;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 176, 239);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 77);
            panel2.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Swis721 Hv BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(410, 27);
            label13.Name = "label13";
            label13.Size = new Size(69, 24);
            label13.TabIndex = 29;
            label13.Text = "SHOP";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Swis721 Hv BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(300, 27);
            label12.Name = "label12";
            label12.Size = new Size(72, 24);
            label12.TabIndex = 26;
            label12.Text = "HOME";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Swis721 Hv BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(145, 27);
            label11.Name = "label11";
            label11.Size = new Size(121, 24);
            label11.TabIndex = 25;
            label11.Text = "MY ORDER";
            label11.Click += label11_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 22);
            label9.Name = "label9";
            label9.Size = new Size(95, 31);
            label9.TabIndex = 16;
            label9.Text = "GraRizz";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-9, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(700, 800);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // Profile_Page
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 207, 244);
            ClientSize = new Size(682, 753);
            Controls.Add(panel2);
            Controls.Add(btnBuy);
            Controls.Add(btnBack);
            Controls.Add(button1);
            Controls.Add(label_password);
            Controls.Add(label_username);
            Controls.Add(label4);
            Controls.Add(btnOrder);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Profile_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuy;
        private PictureBox pictureBox1;
        private Button btnOrder;
        private Label label3;
        private Label label4;
        private Label label_username;
        private Label label_password;
        private Button button1;
        private Button btnBack;
        private Panel panel2;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label9;
        private PictureBox pictureBox2;
    }
}