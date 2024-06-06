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
    public partial class Profile_Page : Form
    {
        private string Username;
        private string Password;

        public Profile_Page(string username, string password)
        {
            InitializeComponent();
            Username = username;
            Password = password;
            this.Load += new System.EventHandler(this.Profile_Page_Load);
        }

        private void Profile_Page_Load(object sender, EventArgs e)
        {
            label_username.Text = Username;
            label_password.Text = Password;
        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To My Order Page?", "My Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyOrder_Page myOrder = new MyOrder_Page();
                myOrder.Show();
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To My Order Page?", "My Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyOrder_Page myOrder = new MyOrder_Page();
                myOrder.Show();
                this.Close();
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Shop Page?", "SHOP PAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Buy_Page buy_Page = new Buy_Page();
                buy_Page.Show();
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Shop Page?", "SHOP PAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Buy_Page buy_Page = new Buy_Page();
                buy_Page.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Wanna Log Out?", "LOG OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyOrder_Page myOrder = new MyOrder_Page();
            myOrder.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buy_Page buyPage = new Buy_Page();
            buyPage.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To My Order Page?", "My Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyOrder_Page myOrder = new MyOrder_Page();
                myOrder.Show();
                this.Close();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Profile Page?", "Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Profile_Page profilePage = new Profile_Page(UserInfo.Username, UserInfo.Password);
                profilePage.Show();
                this.Hide();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Shop Page?", "SHOP PAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Buy_Page buy_Page = new Buy_Page();
                buy_Page.Show();
                this.Hide();
            }
        }
    }
}