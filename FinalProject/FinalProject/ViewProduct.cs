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
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();

        }
        private void ViewProduct_Load(object sender, EventArgs e)
        {
            ProductDL.readProductFromFile("C:\\3rd semester final project\\cs261f22finalpid33\\FinalProject\\FinalProject\\bin\\Debug\\ProductData.txt");
            List<ProductBL> ListToBeShown = new List<ProductBL>(ProductDL.ProductList);
            dataGridView1.DataSource = ListToBeShown;
        }
    }
}
