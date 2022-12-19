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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

        }

        private void clearDataFromForm()
        {
            Roletxt.Text = "";
            UserNametxt.Text = "";
            Passwordtxt.Text = "";
            ReEnterPasswordtxt.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            Rolelbl.Hide();
            Namelbl.Hide();
            Passwordlbl.Hide();
            ReEnterlbl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Role = Roletxt.Text;
            string userName = UserNametxt.Text;
            string password = Passwordtxt.Text;
            string ReEnter = ReEnterPasswordtxt.Text;

            string path = "UserData.txt";
            UserBL user = new UserBL(Role, userName, password, ReEnter);
            UserDL.addIntoList(user);
            UserDL.storeUserIntoFile(user, path);
            MessageBox.Show("User added successfully");
            clearDataFromForm();
          
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
