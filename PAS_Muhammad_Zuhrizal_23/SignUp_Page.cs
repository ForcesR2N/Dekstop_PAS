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

namespace PAS_Muhammad_Zuhrizal_23
{
    public partial class SignUp_Page : Form
    {
        public SignUp_Page()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                pictureBox2.Show();
                pictureBox3.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                pictureBox3.Show();
                pictureBox2.Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter username.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = new SqlConnection("Data Source = ASUS; Initial Catalog = PAS_Project; Integrated Security = True; Trust Server Certificate = True");
            conn.Open();
            string query = "INSERT INTO DBO.login(username, password) VALUES (@username, @password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > -1)
            {
                MessageBox.Show("Account created successfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserInfo.Username = txtUsername.Text;
                UserInfo.Password = txtPassword.Text;
                conn.Close();

                Profile_Page profilePage = new Profile_Page(UserInfo.Username, UserInfo.Password);
                profilePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account creation failed!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Login Page?", "Login Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }
    }
}
