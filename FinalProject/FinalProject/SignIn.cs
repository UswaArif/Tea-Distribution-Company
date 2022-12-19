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

        private void clearDataFromForm()
        {
            UserNametxt.Text = "";
            UserPasswordtxt.Text = "";
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            //UserBL newUser = new UserBL(UserNametxt.Text, UserPasswordtxt.Text);
            //UserBL Checkresult = UserDL.checkUser(newUser);
            //if (Checkresult != null)
            //{
                //if(Checkresult.isAdmin());
            //}
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

        private void SignIn_Load(object sender, EventArgs e)
        {
            Passwordlbl.Hide();
            Userlbl.Hide();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form moreForm = new ForgetPassword();
            //moreForm.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form moreForm = new SignUp();
            moreForm.Show();

        }

        private void UserNametxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string UserName = UserNametxt.Text;
            string Password = UserPasswordtxt.Text;
            UserBL user = new UserBL(UserName, Password);
            UserBL ValidUser = UserDL.checkUser(user);
            if(ValidUser != null)
            {
                MessageBox.Show("User is Valid");
                if (ValidUser.isEmployee())
                {
                    Form moreForm = new EmployeeMenu();
                    moreForm.Show();
                }
                else if (ValidUser.isManager())
                {
                    Form moreForm = new ManagerMenu();
                    moreForm.Show();
                }
                else
                {
                    Form moreForm = new RiderMenu();
                    moreForm.Show();
                }
            }
            else
            {
                Userlbl.Show();
                Passwordlbl.Show();
                //MessageBox.Show("User is not valid.");
            }
            clearDataFromForm();
        }
    }
}
