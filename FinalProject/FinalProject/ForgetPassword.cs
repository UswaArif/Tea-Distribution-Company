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
            if (ForgotPasswordtxt.Text == ReEntertxt.Text)
            {
                newUser.UserPassword1 = ForgotPasswordtxt.Text;
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
    }
}
