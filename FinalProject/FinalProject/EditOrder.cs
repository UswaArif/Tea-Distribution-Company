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
    public partial class EditOrder : Form
    {
        OrderBL newOrder;
        public EditOrder(OrderBL o)
        {
            InitializeComponent();
            newOrder = o;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CustomerBL Customer = CustomerDL.CheckCus(CustomerNametxt.Text);
            RiderBL rider = RiderDL.searchRider(RiderNametxt.Text);
            ProductBL product = ProductDL.checkProduct(ProductNametxt.Text);
            LinkedList<ProductBL> p = new LinkedList<ProductBL>();
            p.AddLast(product);
            OrderBL updateOrder = new OrderBL(OrderIdtxt.Text, Customer, p, Monthtxt.Text, false, rider, DeliveryDatetxt.Text);
            OrderDL.editOrder(newOrder, updateOrder);
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
