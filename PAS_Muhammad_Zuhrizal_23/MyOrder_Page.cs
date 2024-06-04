using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PAS_Muhammad_Zuhrizal_23
{
    public partial class MyOrder_Page : Form
    {
        private Dictionary<string, int> bookPrices = new Dictionary<string, int>
        {
            { "Atomic Habits", 105000 },
            { "The Psychology Of Money", 95000 },
            { "Subtle Art Of Not Giving A Fuck", 63000 },
            { "Good Vibes, Good Life", 85000 },
            { "How To Respect Myself", 90000 },
            { "Learning How To Learn", 100000 }
        };

        public MyOrder_Page()
        {
            InitializeComponent();

            RadioButton_CheckedChanged();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton_CheckedChanged()
        {
            if (rdPinjam.Checked)
            {
                MessageBox.Show("RadioButton1 is selected");
            }
            else if (rdBeli.Checked)
            {
                MessageBox.Show("RadioButton2 is selected");
            }
        }


        private void MyOrder_Page_Load(object sender, EventArgs e)
        {
            cmbBook.Items.Clear();
            cmbBook.Items.AddRange(new object[]
       {
                "Atomic Habits",
                "The Psychology Of Money",
                "Subtle Art Of Not Giving A Fuck",
                "Good Vibes, Good Life",
                "How To Respect Myself",
                "Learning How To Learn"
       });
            cmbBook.SelectedIndex = -1;
            cmbBook.Text = "";

            nudQuantity.Minimum = 0;
            nudQuantity.Maximum = 100;
            nudQuantity.Value = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Profile_Page profilePage = new Profile_Page(UserInfo.Username, UserInfo.Password);
                profilePage.Show();
                this.Hide();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Please fill out your name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdBeli.Checked && !rdPinjam.Checked)
            {
                MessageBox.Show("Please select an option.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbBook.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudQuantity.Value == 0)
            {
                MessageBox.Show("Please select a quantity", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCheckPrice.Text))
            {
                MessageBox.Show("Please check the price first", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nama = txtNama.Text;
            string selectedBook = cmbBook.SelectedItem.ToString();
            int quantity = (int)nudQuantity.Value;
            string option = rdBeli.Checked ? "Beli" : "Pinjam";
            string harga = txtCheckPrice.Text;

            using (SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=PAS_Project;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string query = "INSERT INTO data_penjualan(nama, buku, jumlah, tipe, harga) VALUES (@nama, @buku, @jumlah, @tipe, @harga)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@buku", selectedBook);
                        cmd.Parameters.AddWithValue("@jumlah", quantity);
                        cmd.Parameters.AddWithValue("@tipe", option);
                        cmd.Parameters.AddWithValue("@harga", harga);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Data could not be saved. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Connection to the database could not be established. Please try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCekPrice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Please fill out your name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdBeli.Checked && !rdPinjam.Checked)
            {
                MessageBox.Show("Please select an option.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedBook = cmbBook.SelectedItem.ToString();
            int quantity = (int)nudQuantity.Value;

            if (quantity > 0 && rdBeli.Checked)
            {
                int price = bookPrices[selectedBook];
                int totalPrice = price * quantity;
                txtCheckPrice.Text = $"Rp.{totalPrice}";
            }
            else
            {
                txtCheckPrice.Text = $"FREE";
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=PAS_Project;Integrated Security=True;Trust Server Certificate=True"))
            {
                string query = "SELECT * FROM data_penjualan";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please fill out the ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Please fill out your name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdBeli.Checked && !rdPinjam.Checked)
            {
                MessageBox.Show("Please select an option.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbBook.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudQuantity.Value == 0)
            {
                MessageBox.Show("Please select a quantity", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCheckPrice.Text))
            {
                MessageBox.Show("Please check the price first", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = txtId.Text;
            string nama = txtNama.Text;
            string selectedBook = cmbBook.SelectedItem.ToString();
            int quantity = (int)nudQuantity.Value;
            string option = rdBeli.Checked ? "Beli" : "Pinjam";
            string harga = txtCheckPrice.Text;

            using (SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=PAS_Project;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string query = "UPDATE data_penjualan SET jumlah = @jumlah, tipe = @tipe, harga = @harga, buku = @buku, nama = @nama WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@buku", selectedBook);
                        cmd.Parameters.AddWithValue("@jumlah", quantity);
                        cmd.Parameters.AddWithValue("@tipe", option);
                        cmd.Parameters.AddWithValue("@harga", harga);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Data could not be update. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Connection to the database could not be established. Please try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please fill out the ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = txtId.Text;

                using (SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=PAS_Project;Integrated Security=True;Trust Server Certificate=True"))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        string query = "DELETE FROM data_penjualan WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No record found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Connection to the database could not be established. Please try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Buy_Page buyPage = new Buy_Page();
            buyPage.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNama.Clear();
            cmbBook.SelectedIndex = -1;
            nudQuantity.Value = 0;
            rdBeli.Checked = false;
            rdPinjam.Checked = false;
            txtCheckPrice.Clear();
        }
    }
}