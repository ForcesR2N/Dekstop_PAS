using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PAS_Muhammad_Zuhrizal_23
{
    public partial class Form1 : Form
    {
        private string Username;
        private string Password;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = ASUS; Initial Catalog = PAS_Project; Integrated Security = True; Trust Server Certificate = True");
            conn.Open();
            string query = "SELECT COUNT(*) FROM DBO.login WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username",txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0 )
            {
                MessageBox.Show("Login Succesfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserInfo.Username = txtUsername.Text;
                UserInfo.Password = txtPassword.Text;

                Profile_Page profilePage = new Profile_Page(UserInfo.Username, UserInfo.Password);
                profilePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
