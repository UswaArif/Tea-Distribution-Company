using FinalProject.DL;
using Project.BL;
using Project.DL;
using SignIn.BL;
using SignIn.DL;
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
    public partial class ExpenseManagementUI : Form
    {
        List<int> profit = new List<int>();
        List<string> Months = new List<string>();
        List<int> loss = new List<int>();
        int EmployeeSalary, RiderSalary,OrderEarnedAmount,count=0,earned=0;

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ExpenseManagementUI()
        {
            InitializeComponent();
        }

        private void ExpenseManagement_Load(object sender, EventArgs e)
        {
            foreach (EmployeeBL emp in EmployeeDL.EmpList1) { EmployeeSalary = EmployeeSalary + emp.EmpSalary1; }
            foreach (RiderBL r in RiderDL.RiderList) { RiderSalary = RiderSalary + r.EmpSalary1; }
            ExpenseManagement expense = new ExpenseManagement();
            foreach (OrderBL o in OrderDL.OrderList1) 
            { 
                OrderEarnedAmount = OrderEarnedAmount + o.OrderPayment1; 
                Months.Add(o.OrderMonth1);
                earned = OrderEarnedAmount - EmployeeSalary - RiderSalary - expense.MonthlyElectricity1 - expense.MonthlyFuelExpense1 - expense.MonthlyVechileManagementExpense1;
                if (earned >= 0) { profit.Add(earned);loss.Add(0); }
                if (earned <= 0) { profit.Add(0); loss.Add(earned); }
            }
            for(int i=0; i<=Months.Count()-1; i++)
            {
                dataGridView1.Rows.Add(Months[i], profit[i], loss[i]);
            }
        }
    }
}
