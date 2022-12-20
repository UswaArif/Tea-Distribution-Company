using Project.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.BL
{
    public class OrderBL
    {
        private string OrderID;
        private CustomerBL OrderCustomer;
        private LinkedList<ProductBL> OrderProduct;
        private string OrderMonth;
        private bool OrderPaid;
        private bool OrderDelivered;
        private RiderBL OrderRider;
        private string OrderDeliveryDate;
        private int OrderPayment;

        public OrderBL(string orderID, CustomerBL orderCustomer, LinkedList<ProductBL> orderProduct, string orderMonth, bool orderPaid, RiderBL orderRider, string orderDeliveryDate,int OrderPayment)
        {
            OrderID1 = orderID;
            OrderCustomer1 = orderCustomer;
            OrderProduct1 = orderProduct;
            OrderMonth1 = orderMonth;
            OrderPaid1 = orderPaid;
            OrderDelivered1 = false;
            OrderRider1 = orderRider;
            OrderDeliveryDate1 = orderDeliveryDate;
            OrderPayment1 = OrderPayment;
        }
        public string OrderID1 { get => OrderID; set => OrderID = value; }
        public string OrderMonth1 { get => OrderMonth; set => OrderMonth = value; }
        public bool OrderPaid1 { get => OrderPaid; set => OrderPaid = value; }
        public bool OrderDelivered1 { get => OrderDelivered; set => OrderDelivered = value; }
        public string OrderDeliveryDate1 { get => OrderDeliveryDate; set => OrderDeliveryDate = value; }
        internal CustomerBL OrderCustomer1 { get => OrderCustomer; set => OrderCustomer = value; }
        internal LinkedList<ProductBL> OrderProduct1 { get => OrderProduct; set => OrderProduct = value; }
        internal RiderBL OrderRider1 { get => OrderRider; set => OrderRider = value; }
        public int OrderPayment1 { get => OrderPayment; set => OrderPayment = value; }

        public void isPaid(bool value)
        {
            this.OrderPaid = value;
        }
        public void isDelivered()
        {
            this.OrderDelivered = true;
        }
    }
}
