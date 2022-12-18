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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerBL Customer = CustomerDL.CheckCus(txtCustomerName.Text);
            RiderBL rider = RiderDL.searchRider(txtRidrName.Text);
            ProductBL product = ProductDL.checkProduct(txtProductName.Text);
            LinkedList<ProductBL> p = new LinkedList<ProductBL>();
            p.AddLast(product);
            OrderBL addOrder = new OrderBL(txtOrderId.Text, Customer, p, txtMonth.Text, false, rider, txtDeliveryDate.Text);
            OrderDL.enQueueOrder(addOrder);
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
