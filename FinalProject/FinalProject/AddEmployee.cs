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
using Project.BL;
using Project.DL;

namespace FinalProject
{
    public partial class AddEmployee : Form
    {

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            
            EmployeeBL newEmployee = new EmployeeBL(Nametxt.Text, IDtxt.Text, CNICtxt.Text, Phonetxt.Text, int.Parse(Salarytxt.Text), false);
            EmployeeDL.addIntoList(newEmployee);
            EmployeeDL.storeAllEmployeeIntoFile("D:\\FinalTerm\\cs261f22finalpid33\\FinalProject\\FinalProject\\EmployeeData.txt");
            MessageBox.Show("Employee Added Successfully");
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
