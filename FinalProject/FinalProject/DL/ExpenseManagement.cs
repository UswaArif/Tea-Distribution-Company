using Project.BL;
using Project.DL;
using SignIn.BL;
using SignIn.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DL
{
    class ExpenseManagement
    {
        private int MonthlyFuelExpense;
        private int MonthlyVechileManagementExpense;
        private int EmployeeSalary;
        private int RiderSalary;
        private int MonthlyElectricity;
        private int OrderEarnedAmount;
        private List<string> Months;

        public int MonthlyFuelExpense1 { get => MonthlyFuelExpense; set => MonthlyFuelExpense = value; }
        public int MonthlyVechileManagementExpense1 { get => MonthlyVechileManagementExpense; set => MonthlyVechileManagementExpense = value; }
        public int EmployeeSalary1 { get => EmployeeSalary; set => EmployeeSalary = value; }
        public int RiderSalary1 { get => RiderSalary; set => RiderSalary = value; }
        public int MonthlyElectricity1 { get => MonthlyElectricity; set => MonthlyElectricity = value; }
        public int OrderEarnedAmount1 { get => OrderEarnedAmount; set => OrderEarnedAmount = value; }
        public ExpenseManagement()
        {
            MonthlyFuelExpense1 = 90;
            MonthlyVechileManagementExpense=10;
            foreach(EmployeeBL e in EmployeeDL.EmpList1) { EmployeeSalary = EmployeeSalary + e.EmpSalary1; }
            foreach(RiderBL r in RiderDL.RiderList) { RiderSalary = RiderSalary + r.EmpSalary1; }
            MonthlyElectricity = 700;
            foreach(OrderBL o in OrderDL.OrderList1) { OrderEarnedAmount = OrderEarnedAmount + o.OrderPayment1; Months.Add(o.OrderMonth1); }
        }
    }
}
