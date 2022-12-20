using Project.BL;
using Project.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            EmployeeBL newEmployee = new EmployeeBL(Nametxt.Text, IDtxt.Text, CNICtxt.Text, Phonetxt.Text, int.Parse(Salarytxt.Text), false);
            EmployeeDL.addIntoList(newEmployee);
            EmployeeDL.storeAllEmployeeIntoFile("D:\\FinalTerm\\cs261f22finalpid33\\FinalProject\\FinalProject\\EmployeeData.txt");
        }
    }
}
