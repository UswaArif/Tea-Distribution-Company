using SignIn.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            f.WriteLine(o1.OrderID1 + "," + o1.OrderCustomer1.CusName1 + "," + o1.OrderCustomer1.CusEmail1 + "," + o1.OrderCustomer1.CusLedger1 + "," + o1.OrderCustomer1.IsFrequenter1 + "," + o1.OrderCustomer1.CusAddress1.Latitude1 + "," + o1.OrderCustomer1.CusAddress1.Longitude1 + "," + o1.OrderCustomer1.CusCinic1 + "," + o1.OrderMonth1 + "," + o1.OrderPaid1 + "," + o1.OrderDeliveryDate1 + "," + o1.OrderRider1.EmpName1 + "," + o1.OrderRider1.EmpId1 + o1.OrderDeliveryDate1 + ";" + product);
            f.Flush();
            f.Close();
        }

        /*public static bool readIntoFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;

            if(File.Exists(path))
            {
                while((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    int OrderId = int.Parse(splittedRecord[0]);
                    string OrderCustomer = splittedRecord[1];
                    string CustomerEmail = splittedRecord[2];
                    int CustomerLedge = int.Parse(splittedRecord[3]);
                    int CustomerIsFrequenter = int.Parse(splittedRecord[4]);
                    float AreaLatitude = float.Parse(splittedRecord[5]);
                    float AreaLongitude = float.Parse(splittedRecord[6]);
                    string CustomerCNIC = splittedRecord[7];
                    string OrderMonth = splittedRecord[8];
                    bool OrderPaid = bool.Parse(splittedRecord[9]);

                    string[] splittedRecordForProducts = splittedRecord[10].Split(';');
                    string OrderDeliveredDate = splittedRecordForProducts[0];
                    LinkedList<ProductBL> product = new LinkedList<ProductBL>();

                    for(int index=0; index<= splittedRecordForProducts.Length; index++)
                    {
                        ProductBL p = splittedRecordForProducts[index];
                    }

                }
            }*/
        }
    }
