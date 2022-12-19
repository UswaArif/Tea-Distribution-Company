using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignIn.BL;
using SignIn.DL;

namespace FinalProject
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            ProductBL newProduct = new ProductBL(ProductPricetxt.Text, int.Parse(ProductStocktxt.Text), int.Parse(ProductThresholdtxt.Text), int.Parse(TotalProductSelledtxt.Text), int.Parse(ProductNametxt.Text), ProductStocktxt.Text, SizeCombox.Text);
            ProductDL.addIntoProductList(newProduct);
            //ProductDL.storeProductIntoFile;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
