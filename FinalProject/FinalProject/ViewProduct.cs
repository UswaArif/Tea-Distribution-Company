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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductDL.ProductList;
        }
    }
}
