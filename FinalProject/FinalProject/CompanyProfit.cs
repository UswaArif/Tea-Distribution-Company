using FinalProject.DL;
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
    public partial class CompanyProfit : Form
    {
        public CompanyProfit()
        {
            InitializeComponent();
        }

        private void CompanyProfit_Load(object sender, EventArgs e)
        {
            ExpenseManagement expense = new ExpenseManagement();
            int CountOrders = OrderDL.OrderList1.Count();
            TotalSalestxt.Text = CountOrders.ToString();
            FuelExpensestxt.Text = expense.MonthlyFuelExpense1.ToString();
            Vehicletxt.Text = expense.MonthlyVechileManagementExpense1.ToString();
            Salarytxt.Text = (expense.RiderSalary1 + expense.EmployeeSalary1).ToString();
            int Total = expense.OrderEarnedAmount1 - expense.RiderSalary1 - expense.EmployeeSalary1 - expense.MonthlyElectricity1 - expense.MonthlyFuelExpense1 - expense.MonthlyVechileManagementExpense1;
            Amountlbl.Text = Total.ToString();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
