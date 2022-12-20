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
    public partial class SearchOrder : Form
    {
        OrderBL order;
        public SearchOrder()
        {
            InitializeComponent();
        }
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            order = OrderDL.searchOrder(IDtxt.Text);
            dataGridView1.DataSource = OrderDL.OrderList1;
            dataGridView1.Columns["OrderProduct1"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns["ViewProduct"].Index == e.ColumnIndex)
            {
                ViewOrderProducts newfrm = new ViewOrderProducts(order);
                this.Close();
                newfrm.Show();
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
