using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignIn.BL;

namespace FinalProject
{
    public partial class ForgetPassword : Form
    {
        UserBL newUser;
        public ForgetPassword(UserBL u)
        {
            InitializeComponent();
            newUser = u;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            if (Passwordtxt.Text == ReEnterPasswordtxt.Text)
            {
                newUser.UserPassword1 = Passwordtxt.Text;
            }
            else
            {
                MessageBox.Show("InCorrect Password");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
