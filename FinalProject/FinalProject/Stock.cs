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
    public partial class Stock : Form
    {
        List<string> productName = new List<string>();
        List<string> OutOfStock = new List<string>();
        List<string> Expired = new List<string>();
        public Stock()
        {
            InitializeComponent();
            foreach(ProductBL p in ProductDL.ProductList) { productName.Add(p.ProductName1);
                if (p.ProductThreshold1 <= p.ProductStock1) { OutOfStock.Add("Yes"); }
                else { OutOfStock.Add("No"); }
                if ((DateTime.Now.ToString("dd-MM-yyyy")) == p.ProductExpire1) { Expired.Add("yes"); }
                else { Expired.Add("no"); }
            }

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            for(int i=0; i<=ProductDL.ProductList.Count()-1; i++)
            {
               //
            }
        }
    }
}
