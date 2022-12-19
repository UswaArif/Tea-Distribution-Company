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
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form moreForm = new EmployeeProfile();
            moreForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form moreForm = new AddRider();
            moreForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form moreForm = new ViewRider();
            moreForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form moreForm = new SearchRider();
            moreForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form moreForm = new ViewOrder();
            moreForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form moreForm = new RiderSalaryStatus();
            moreForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
