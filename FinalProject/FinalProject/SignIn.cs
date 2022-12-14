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
using SignIn.DL;

namespace FinalProject
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            UserBL newUser = new UserBL(UserNametxt.Text, UserPasswordtxt.Text);
            UserBL Checkresult = UserDL.checkUser(newUser);
            if (Checkresult != null)
            {
                //if(Checkresult.isAdmin());
            }
            else
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form moreForm = new ForgetPassword();
            //moreForm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form moreForm = new SignUp();
            moreForm.Show();
        }
    }
}
