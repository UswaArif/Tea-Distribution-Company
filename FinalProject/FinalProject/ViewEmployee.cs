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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            EmployeeDL.readEmployeefromFile("D:\\FinalTerm\\cs261f22finalpid33\\FinalProject\\FinalProject\\EmployeeData.txt");
            List<EmployeeBL> ListToBeShown = new List<EmployeeBL>(EmployeeDL.EmpList1);
            dataGridView1.DataSource = ListToBeShown;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Form moreForm = new AddEmployee();
            moreForm.Show();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
