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
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            List<ProductBL> productList = new List<ProductBL>();
            productList = ProductDL.SearchBySize(Sizetxt.Text);
            dataGridView1.DataSource = productList;
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            //ProductDL.readProductFromFile("C:\\3rd semester final project\\cs261f22finalpid33\\FinalProject\\FinalProject\\bin\\Debug\\ProductData.txt");

        }
    }
}
