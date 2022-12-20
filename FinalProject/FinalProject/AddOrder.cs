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
        LinkedList<ProductBL> p = new LinkedList<ProductBL>();
        LinkedList<RiderBL> r = new LinkedList<RiderBL>();
        int TotalPayment=0;
        bool OrderPaid = false;
        public AddOrder()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerBL Customer = CustomerDL.CheckCus(CustomerNametxt.SelectedItem.ToString());
            r = RiderDL.ReturnSpecificAreaRider(Customer.CusAddress1);
            if (r.Count() != 0)
            {
                foreach(RiderBL riderReturned in r) {
                    RiderComboBox.Items.Add(riderReturned.EmpId1);
                }
                RiderBL rider = RiderDL.searchRider(RiderComboBox.SelectedItem.ToString());
                foreach (ProductBL product in p)
                {
                    TotalPayment = product.ProductPrice1 + TotalPayment;
                }
                if (PaidYesCheckBox.Checked)
                {
                    Customer.CusLedger1 = Customer.CusLedger1 + TotalPayment;
                    OrderPaid = true;
                }
                OrderBL addOrder = new OrderBL(OrderIdtxt.Text, Customer, p, Monthtxt.Text, OrderPaid, rider, DeliveryDate.Text, TotalPayment);
                OrderDL.enQueueOrder(addOrder);
                OrderDL.StoreIntoFile("OrderData", addOrder);
            }
            else
            {
                MessageBox.Show("No Rider of This Area");
            }
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            DeliveryDate.Format = DateTimePickerFormat.Custom;
            DeliveryDate.CustomFormat = "dd-MM-yyyy";
            foreach (ProductBL p in ProductDL.ProductList)
            {
                productComboBox.Items.Add(p.ProductSize1);
            }
            foreach(CustomerBL c in CustomerDL.CusList)
            {
                CustomerNametxt.Items.Add(c.CusCinic1);
            }
        }

        private void AddMorebtn_Click(object sender, EventArgs e)
        {
            ProductBL product = ProductDL.checkProduct(productComboBox.Text);
            p.AddLast(product);
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
