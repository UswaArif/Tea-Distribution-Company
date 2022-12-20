using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BL;
using Project.DL;

namespace FinalProject
{
    public partial class EmployeeSalaryStatus : Form
    {
        public EmployeeSalaryStatus()
        {
            InitializeComponent();
        }
        private void Donebtn_Click(object sender, EventArgs e)
        {
            int salary = 0;
            EmployeeBL emp = EmployeeDL.searchEmployee(IDtxt.Text);
            if (PayCheckBox.Checked == true)
            {
                if (BonusYesCheckBox.Checked == true)
                {
                    salary = emp.EmpSalary1 + 150000;
                }
                else
                {
                    salary = emp.EmpSalary1;
                }
                emp.IsSalaryPaid = true;
                //EmployeeDL.storeAllEmployeeIntoFile("");
                Salarylbl.Text = salary.ToString();
            }
        }
    }
}
