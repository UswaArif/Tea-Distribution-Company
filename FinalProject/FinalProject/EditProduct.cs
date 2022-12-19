﻿using SignIn.BL;
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

        private void Editbtn_Click(object sender, EventArgs e)
        {
            ProductBL newProduct = new ProductBL(ProductNametxt.Text, int.Parse(ProductStocktxt.Text), int.Parse(ProductThresholdtxt.Text), int.Parse(ProductPricetxt.Text), int.Parse(ProductTotalSelledtxt.Text), ProductStocktxt.Text, SizeComboBox.Text);
            ProductDL.addIntoProductList(newProduct);
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
