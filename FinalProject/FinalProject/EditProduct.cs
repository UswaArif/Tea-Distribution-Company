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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

       
        private void Editbtn_Click_1(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            ProductBL newProduct = new ProductBL(ProductNametxt.Text, int.Parse(ProductStocktxt.Text), int.Parse(ProductThresholdtxt.Text), int.Parse(ProductPricetxt.Text), int.Parse(ProductTotalSelledtxt.Text),date, SizeComboBox.Text);
            ProductDL.addIntoProductList(newProduct);
            ProductDL.storeProductIntoFile("ProductData");
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }
    }
}
