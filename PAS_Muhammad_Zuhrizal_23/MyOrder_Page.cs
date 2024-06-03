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
    public partial class MyOrder_Page : Form
    {
        private string username;
        private string password;
        public MyOrder_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Buy_Page buyPage = new Buy_Page();
            buyPage.Show();
            this.Close();
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

        }
    }
}
