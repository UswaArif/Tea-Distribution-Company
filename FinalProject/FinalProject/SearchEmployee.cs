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
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            List<EmployeeBL> EmployeeList = new List<EmployeeBL>();
            EmployeeList = EmployeeDL.searchEmployee(CNICtxt.Text);
            dataGridView1.DataSource = EmployeeList;
        }
    }
}
