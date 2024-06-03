namespace PAS_Muhammad_Zuhrizal_23
{
    partial class Buy_Page
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtNama = new TextBox();
            cmbBook = new ComboBox();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            nudJumlah = new NumericUpDown();
            btnCO = new Button();
            label9 = new Label();
            txtCheckPrice = new TextBox();
            pictureBox1 = new PictureBox();
            btnCekPrice = new Button();
            label10 = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            rdBeli = new RadioButton();
            rdPinjam = new RadioButton();
            label7 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 82);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "NAMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 128);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "BUKU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 177);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "JUMLAH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 128);
            label5.Name = "label5";
            label5.Size = new Size(12, 20);
            label5.TabIndex = 4;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 82);
            label6.Name = "label6";
            label6.Size = new Size(12, 20);
            label6.TabIndex = 5;
            label6.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 177);
            label8.Name = "label8";
            label8.Size = new Size(12, 20);
            label8.TabIndex = 7;
            label8.Text = ":";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(272, 78);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(251, 27);
            txtNama.TabIndex = 8;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // cmbBook
            // 
            cmbBook.FormattingEnabled = true;
            cmbBook.Items.AddRange(new object[] { "Atomic Habits", "The Psychology Of Money", "Subtle Art Of Not Giving A Fuck", "Good Vibes, Good Life", "How To Respect Myself", "Learning How To Learn" });
            cmbBook.Location = new Point(272, 122);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(251, 28);
            cmbBook.TabIndex = 12;
            cmbBook.SelectedIndexChanged += cmbBook_SelectedIndexChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // nudJumlah
            // 
            nudJumlah.BackColor = Color.White;
            nudJumlah.Location = new Point(272, 177);
            nudJumlah.Name = "nudJumlah";
            nudJumlah.Size = new Size(64, 27);
            nudJumlah.TabIndex = 13;
            nudJumlah.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCO
            // 
            btnCO.Location = new Point(384, 362);
            btnCO.Name = "btnCO";
            btnCO.Size = new Size(121, 44);
            btnCO.TabIndex = 14;
            btnCO.Text = "Check Out!";
            btnCO.UseVisualStyleBackColor = true;
            btnCO.Click += btnCO_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(385, 9);
            label9.Name = "label9";
            label9.Size = new Size(58, 28);
            label9.TabIndex = 16;
            label9.Text = "BUY!";
            // 
            // txtCheckPrice
            // 
            txtCheckPrice.Location = new Point(275, 301);
            txtCheckPrice.Name = "txtCheckPrice";
            txtCheckPrice.Size = new Size(125, 27);
            txtCheckPrice.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(570, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 196);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnCekPrice
            // 
            btnCekPrice.Location = new Point(132, 301);
            btnCekPrice.Name = "btnCekPrice";
            btnCekPrice.Size = new Size(101, 29);
            btnCekPrice.TabIndex = 19;
            btnCekPrice.Text = "Check Price";
            btnCekPrice.UseVisualStyleBackColor = true;
            btnCekPrice.Click += btnCekPrice_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(240, 308);
            label10.Name = "label10";
            label10.Size = new Size(12, 20);
            label10.TabIndex = 20;
            label10.Text = ":";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(13, 340);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 29);
            btnBack.TabIndex = 21;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(-1, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 396);
            panel1.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(13, 199);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 24;
            button1.Text = "My Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(label9);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 57);
            panel2.TabIndex = 23;
            // 
            // rdBeli
            // 
            rdBeli.AutoSize = true;
            rdBeli.Location = new Point(272, 259);
            rdBeli.Name = "rdBeli";
            rdBeli.Size = new Size(58, 24);
            rdBeli.TabIndex = 27;
            rdBeli.TabStop = true;
            rdBeli.Text = "BELI";
            rdBeli.UseVisualStyleBackColor = true;
            // 
            // rdPinjam
            // 
            rdPinjam.AutoSize = true;
            rdPinjam.Location = new Point(272, 229);
            rdPinjam.Name = "rdPinjam";
            rdPinjam.Size = new Size(81, 24);
            rdPinjam.TabIndex = 26;
            rdPinjam.TabStop = true;
            rdPinjam.Text = "PINJAM";
            rdPinjam.UseVisualStyleBackColor = true;
            rdPinjam.CheckedChanged += rdPinjam_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 229);
            label7.Name = "label7";
            label7.Size = new Size(12, 20);
            label7.TabIndex = 25;
            label7.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 229);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 24;
            label4.Text = "TIPE";
            // 
            // Buy_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdBeli);
            Controls.Add(rdPinjam);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(btnCekPrice);
            Controls.Add(pictureBox1);
            Controls.Add(txtCheckPrice);
            Controls.Add(btnCO);
            Controls.Add(nudJumlah);
            Controls.Add(cmbBook);
            Controls.Add(txtNama);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Buy_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buy_Page";
            Load += Buy_Page_Load;
            ((System.ComponentModel.ISupportInitialize)nudJumlah).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox txtNama;
        private ComboBox cmbBook;
        private ImageList imageList1;
        private ImageList imageList2;
        private NumericUpDown nudJumlah;
        private Button btnCO;
        private Label label9;
        private TextBox txtCheckPrice;
        private PictureBox pictureBox1;
        private Button btnCekPrice;
        private Label label10;
        private Button btnBack;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private RadioButton rdBeli;
        private RadioButton rdPinjam;
        private Label label7;
        private Label label4;
    }
}