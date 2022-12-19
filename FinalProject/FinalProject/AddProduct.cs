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
            string date = dateTimePicker.Text;
            //date = date.Replace(@"\", "-");
            ProductBL newProduct = new ProductBL(ProductNametxt.Text,int.Parse(ProductStocktxt.Text), int.Parse(ProductThresholdtxt.Text),int.Parse(ProductPricetxt.Text) ,int.Parse(TotalProductSelledtxt.Text),date, SizeCombox.Text);
            ProductDL.addIntoProductList(newProduct);
            ProductDL.storeProductIntoFile("C:\\3rd semester final project\\cs261f22finalpid33\\FinalProject\\FinalProject\\bin\\Debug\\ProductData.txt");
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd-MM-yyyy";
            //ProductDL.readProductFromFile("C:\\3rd semester final project\\cs261f22finalpid33\\FinalProject\\FinalProject\\bin\\Debug\\ProductData.txt");
        }
    }
}
