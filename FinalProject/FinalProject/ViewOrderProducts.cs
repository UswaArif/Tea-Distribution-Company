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
    public partial class ViewOrderProducts : Form
    {
        OrderBL order;
        public ViewOrderProducts(OrderBL order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void ViewOrderProducts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = order.OrderProduct1;
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
