using SignIn.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Project.BL;

namespace SignIn.DL
{
    class OrderDL
    {
        private static LinkedList<OrderBL> OrderList = new LinkedList<OrderBL>();

        public static LinkedList<OrderBL> OrderList1 { get => OrderList; set => OrderList = value; }
        public static void enQueueOrder(OrderBL o)
        {
            OrderList1.AddFirst(o);
        }
        public static void deQueueOrer()
        {
            OrderList1.RemoveLast();
        }

        public static bool editOrder(OrderBL previous, OrderBL updated)
        {
            foreach (OrderBL o1 in OrderList1)
            {
                if (o1.OrderID1 == previous.OrderID1)
                {
                    previous.OrderCustomer1 = updated.OrderCustomer1;
                    previous.OrderID1 = updated.OrderID1;
                    previous.OrderProduct1 = updated.OrderProduct1;
                    previous.OrderPaid1 = updated.OrderPaid1;
                    previous.OrderDeliveryDate1 = updated.OrderDeliveryDate1;

                    return true;
                }
            }
            return false;
        }

        public static OrderBL searchOrder(string Id)
        {
            foreach (OrderBL o1 in OrderList1)
            {
                if (o1.OrderID1 == Id)
                {
                    return o1;
                }
            }
            return null;
        }

        public static void StoreIntoFile(string path, OrderBL o1)
        {
            StreamWriter f = new StreamWriter(path, true);
            string product = "";

            foreach (ProductBL p1 in o1.OrderProduct1)
            {
                product = product + p1.ProductName1 + ";";
            }
            product = product + o1.OrderProduct1.ElementAt(o1.OrderProduct1.Count - 1).ProductName1;
            f.WriteLine(o1.OrderID1 + "," + o1.OrderCustomer1.CusName1 + "," + o1.OrderCustomer1.CusEmail1 + "," + o1.OrderCustomer1.CusLedger1 + "," + o1.OrderCustomer1.IsFrequenter1 +","+o1.OrderCustomer1.CusTotalOrder1+"," + o1.OrderCustomer1.CusCinic1 + "," + o1.OrderCustomer1.CusAddress1.Latitude1 + "," + o1.OrderCustomer1.CusAddress1.Longitude1  + "," + o1.OrderPaid1 + "," + o1.OrderMonth1 + "," + o1.OrderDeliveryDate1+","+o1.OrderPayment1 + "," + o1.OrderRider1.EmpName1 +","+o1.OrderRider1.EmpCnic1+ "," +","+o1.OrderRider1.EmpPhone1+","+o1.OrderRider1.EmpId1+","+o1.OrderRider1.EmpSalary1+"," +o1.OrderRider1.VehicleId1+","+o1.OrderRider1.TotalDelivery1+","+o1.OrderRider1.IsSalaryPaid+","+o1.OrderRider1.RiderArea1.Latitude1+","+o1.OrderRider1.RiderArea1.Longitude1+","+product);
            f.Flush();
            f.Close();
        }

        public static bool readIntoFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;

            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string OrderId = splittedRecord[0];
                    string CustomerName = splittedRecord[1];
                    string CustomerEmail = splittedRecord[2];
                    int CustomerLedge = int.Parse(splittedRecord[3]);
                    bool CustomerIsFrequenter = bool.Parse(splittedRecord[4]);
                    int CustomerTotalOrders = int.Parse(splittedRecord[5]);
                    string CustomerCNIC = splittedRecord[6];
                    float AreaLatitude = float.Parse(splittedRecord[7]);
                    float AreaLongitude = float.Parse(splittedRecord[8]);
                    area CustomerArea = new area(AreaLatitude, AreaLongitude);
                    CustomerBL customer = new CustomerBL(CustomerName, CustomerEmail, CustomerLedge, CustomerIsFrequenter, CustomerTotalOrders, CustomerCNIC, CustomerArea); string OrderMonth = splittedRecord[8];
                    bool OrderPaid = bool.Parse(splittedRecord[9]);
                    string OrderMonths = splittedRecord[10];
                    string DeilveryMonth = splittedRecord[11];
                    int OrderPayment = int.Parse(splittedRecord[12]);
                    string RiderName = splittedRecord[13];
                    string RiderCinic = splittedRecord[14];
                    string RiderPhone = splittedRecord[15];
                    string RiderID = splittedRecord[16];
                    int RiderSalary = int.Parse(splittedRecord[17]);
                    string RiderVechileId = splittedRecord[18];
                    int RiderTotalDelivery = int.Parse(splittedRecord[19]);
                    bool RiderIsSalary = bool.Parse(splittedRecord[20]);
                    float AreaLatitudeRider = float.Parse(splittedRecord[21]);
                    float AreaLongitudeRider = float.Parse(splittedRecord[22]);
                    area RiderArea = new area(AreaLatitudeRider, AreaLongitudeRider);
                    RiderBL rider = new RiderBL(RiderName, RiderCinic, RiderPhone, RiderID, RiderSalary, RiderVechileId, RiderTotalDelivery, RiderIsSalary, RiderArea);
                    //public RiderBL(string name, string CNIC, string phoneNumber,string Id, int salary, string vehicleAssign,int totalDelivery,bool isSalaryPaid, area RiderArea):base(name,CNIC,phoneNumber,Id,salary,isSalaryPaid)
                    string[] splittedRecordForProducts = splittedRecord[23].Split(';');
                    LinkedList<ProductBL> product = new LinkedList<ProductBL>();
                    for (int index = 0; index <= splittedRecordForProducts.Length; index++)
                    {
                        ProductBL products = ProductDL.checkProduct(splittedRecordForProducts[index]);
                        if (products != null)
                        {
                            product.AddLast(products);
                        }
                    }
                    OrderBL order = new OrderBL(OrderId, customer, product, OrderMonths, OrderPaid, rider, DeilveryMonth, OrderPayment);
                    enQueueOrder(order);
                    return true;
                    //public OrderBL(string orderID, CustomerBL orderCustomer, LinkedList<ProductBL> orderProduct, string orderMonth, bool orderPaid, RiderBL orderRider, string orderDeliveryDate,int OrderPayment)

                }
            }
            return false;
        }
    }
}
