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
    public partial class RiderSalaryStatus : Form
    {
        public RiderSalaryStatus()
        {
            InitializeComponent();
        }

        private void Donebtn_Click(object sender, EventArgs e)
        {
            int salary = 0;
            RiderBL r = RiderDL.searchRider(IDtxt.Text);
            if (PayCheckBox.Checked == true)
            {
                if (BonusYesCheckBox.Checked == true)
                {
                    salary = r.EmpSalary1 + 150000;
                }
                else
                {
                    salary = r.EmpSalary1;
                }
                r.IsSalaryPaid = true;
                RiderDL.storeAllRiderIntoFile("RiderDatatxt");
                Salarylbl.Text = salary.ToString();
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
