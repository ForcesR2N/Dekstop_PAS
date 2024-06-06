namespace PAS_Muhammad_Zuhrizal_23
{
    partial class MyOrder_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrder_Page));
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnPrintPDF = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRead = new Button();
            btnCreate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNama = new TextBox();
            cmbBook = new ComboBox();
            nudQuantity = new NumericUpDown();
            btnClear = new Button();
            rdBeli = new RadioButton();
            rdPinjam = new RadioButton();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnCekPrice = new Button();
            txtCheckPrice = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtId = new TextBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel2 = new Panel();
            label13 = new Label();
            label1 = new Label();
            label14 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(576, 103);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 137);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(683, 270);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(238, 103);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(332, 27);
            txtSearch.TabIndex = 25;
            // 
            // btnPrintPDF
            // 
            btnPrintPDF.Cursor = Cursors.Hand;
            btnPrintPDF.Location = new Point(325, 415);
            btnPrintPDF.Margin = new Padding(5, 4, 5, 4);
            btnPrintPDF.Name = "btnPrintPDF";
            btnPrintPDF.Size = new Size(67, 29);
            btnPrintPDF.TabIndex = 30;
            btnPrintPDF.Text = "Print PDF";
            btnPrintPDF.UseVisualStyleBackColor = true;
            btnPrintPDF.Click += btnPrintPDF_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(248, 415);
            btnDelete.Margin = new Padding(5, 4, 5, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 29);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(171, 415);
            btnUpdate.Margin = new Padding(5, 4, 5, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(67, 29);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRead
            // 
            btnRead.Cursor = Cursors.Hand;
            btnRead.Location = new Point(94, 415);
            btnRead.Margin = new Padding(5, 4, 5, 4);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(67, 29);
            btnRead.TabIndex = 27;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnCreate
            // 
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Location = new Point(15, 415);
            btnCreate.Margin = new Padding(5, 4, 5, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(67, 29);
            btnCreate.TabIndex = 26;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 529);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 33;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 566);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 34;
            label3.Text = "Buku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 600);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 35;
            label4.Text = "Jumlah";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 530);
            label5.Name = "label5";
            label5.Size = new Size(12, 20);
            label5.TabIndex = 37;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 598);
            label6.Name = "label6";
            label6.Size = new Size(12, 20);
            label6.TabIndex = 38;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 564);
            label7.Name = "label7";
            label7.Size = new Size(12, 20);
            label7.TabIndex = 39;
            label7.Text = ":";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(94, 530);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(251, 27);
            txtNama.TabIndex = 4;
            // 
            // cmbBook
            // 
            cmbBook.FormattingEnabled = true;
            cmbBook.Items.AddRange(new object[] { "Atomic Habits", "The Psychology Of Money", "Subtle Art Of Not Giving A Fuck", "Good Vibes, Good Life", "How To Respect Myself", "Learning How To Learn" });
            cmbBook.Location = new Point(94, 563);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(251, 28);
            cmbBook.TabIndex = 32;
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.White;
            nudQuantity.Location = new Point(94, 597);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(64, 27);
            nudQuantity.TabIndex = 40;
            nudQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(555, 606);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 41;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // rdBeli
            // 
            rdBeli.AutoSize = true;
            rdBeli.Location = new Point(521, 528);
            rdBeli.Name = "rdBeli";
            rdBeli.Size = new Size(58, 24);
            rdBeli.TabIndex = 45;
            rdBeli.TabStop = true;
            rdBeli.Text = "BELI";
            rdBeli.UseVisualStyleBackColor = true;
            // 
            // rdPinjam
            // 
            rdPinjam.AutoSize = true;
            rdPinjam.Location = new Point(521, 498);
            rdPinjam.Name = "rdPinjam";
            rdPinjam.Size = new Size(81, 24);
            rdPinjam.TabIndex = 44;
            rdPinjam.TabStop = true;
            rdPinjam.Text = "PINJAM";
            rdPinjam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(488, 498);
            label8.Name = "label8";
            label8.Size = new Size(12, 20);
            label8.TabIndex = 43;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(417, 498);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 42;
            label9.Text = "TIPE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(489, 565);
            label10.Name = "label10";
            label10.Size = new Size(12, 20);
            label10.TabIndex = 48;
            label10.Text = ":";
            // 
            // btnCekPrice
            // 
            btnCekPrice.Location = new Point(381, 560);
            btnCekPrice.Name = "btnCekPrice";
            btnCekPrice.Size = new Size(101, 29);
            btnCekPrice.TabIndex = 47;
            btnCekPrice.Text = "Check Price";
            btnCekPrice.UseVisualStyleBackColor = true;
            btnCekPrice.Click += btnCekPrice_Click;
            // 
            // txtCheckPrice
            // 
            txtCheckPrice.Location = new Point(524, 560);
            txtCheckPrice.Name = "txtCheckPrice";
            txtCheckPrice.Size = new Size(125, 27);
            txtCheckPrice.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(76, 497);
            label11.Name = "label11";
            label11.Size = new Size(12, 20);
            label11.TabIndex = 51;
            label11.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 485);
            label12.Name = "label12";
            label12.Size = new Size(22, 20);
            label12.TabIndex = 50;
            label12.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(94, 497);
            txtId.Name = "txtId";
            txtId.Size = new Size(251, 27);
            txtId.TabIndex = 49;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            printPreviewDialog1.Click += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 176, 239);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 77);
            panel2.TabIndex = 52;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Hv BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(300, 27);
            label1.Name = "label1";
            label1.Size = new Size(72, 24);
            label1.TabIndex = 26;
            label1.Text = "HOME";
            label1.Click += label1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Swis721 Hv BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(145, 27);
            label14.Name = "label14";
            label14.Size = new Size(121, 24);
            label14.TabIndex = 25;
            label14.Text = "MY ORDER";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(13, 22);
            label15.Name = "label15";
            label15.Size = new Size(95, 31);
            label15.TabIndex = 16;
            label15.Text = "GraRizz";
            // 
            // MyOrder_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 207, 244);
            ClientSize = new Size(682, 753);
            Controls.Add(panel2);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(btnCekPrice);
            Controls.Add(txtCheckPrice);
            Controls.Add(rdBeli);
            Controls.Add(rdPinjam);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(btnClear);
            Controls.Add(nudQuantity);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbBook);
            Controls.Add(btnPrintPDF);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(btnCreate);
            Controls.Add(txtSearch);
            Controls.Add(txtNama);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Name = "MyOrder_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyOrder_Page";
            Load += MyOrder_Page_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnPrintPDF;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRead;
        private Button btnCreate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNama;
        private ComboBox cmbBook;
        private NumericUpDown nudQuantity;
        private Button btnClear;
        private RadioButton rdBeli;
        private RadioButton rdPinjam;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnCekPrice;
        private TextBox txtCheckPrice;
        private Label label11;
        private Label label12;
        private TextBox txtId;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel panel2;
        private Label label13;
        private Label label1;
        private Label label14;
        private Label label15;
    }
}