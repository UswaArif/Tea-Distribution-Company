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
using Project.DL;

namespace FinalProject
{
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            
            //List<EmployeeBL> EmployeeList = new List<EmployeeBL>(EmployeeDL.EmpList1);
            //EmployeeBL e1 = new EmployeeBL();
            //e1 = EmployeeDL.searchEmployee(CNICtxt.Text);
            //dataGridView1.DataSource = EmployeeList;
        }
    }
}
