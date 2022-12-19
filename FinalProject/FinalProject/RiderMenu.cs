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
    public partial class RiderMenu : Form
    {
        public RiderMenu()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form moreForm = new RiderProfile();
            moreForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form moreForm = new AddOrder();
            moreForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form moreForm = new ViewOrder();
            moreForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form moreForm = new SearchOrder();
            moreForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form moreForm = new OrderedProducts();
            moreForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form moreForm = new SearchRider();
            moreForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
