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
    public partial class OrderedProducts : Form
    {
        public OrderedProducts()
        {
            InitializeComponent();
        }

        private void OrderedProducts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderDL.OrderList1;
            dataGridView1.Columns["OrderedProduct1"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns["ViewProduct"].Index == e.ColumnIndex)
            {
                ViewOrderProducts newfrm = new ViewOrderProducts(OrderDL.OrderList1.ElementAt(dataGridView1.Columns["ViewProduct"].Index));
                this.Close();
                newfrm.Show();
            }
        }
    }
}
