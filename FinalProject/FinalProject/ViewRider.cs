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
using Project.DL;
using Project.BL;

namespace FinalProject
{
    public partial class ViewRider : Form
    {
        public ViewRider()
        {
            InitializeComponent();
        }

        private void btnViewRiderAdd_Click(object sender, EventArgs e)
        {
            Form addrider = new AddRider();
            addrider.ShowDialog();
            //RiderDL.storeAllRiderIntoFile("RiderData.txt");
            BindData();
        }

        private void btnViewRiderBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindData()
        {
            gvRider.DataSource = null;
            gvRider.AutoGenerateColumns = true;
            gvRider.DataSource = RiderDL.RiderList;
            gvRider.Refresh();
        }

        private void gvRider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = "RiderData.txt";
            RiderBL r1 = (RiderBL)gvRider.CurrentRow.DataBoundItem;
            if (gvRider.Columns["Delete"].Index == e.ColumnIndex)
            {
                RiderDL.checkIsDeleted(r1);
                RiderDL.storeAllRiderIntoFile(path);
                BindData();
                //this.gvRider.Columns["Discount"].Visible = false;
                //this.gvProducts.Columns["Discountprice"].Visible = false;
                int idx = 1;
                foreach (DataGridViewRow row in gvRider.Rows)
                {
                    row.Cells[0].Value = idx;
                    idx++;
                }
            }

            else if (gvRider.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditRider editrider = new EditRider(r1);
                editrider.ShowDialog();
                RiderDL.storeAllRiderIntoFile(path);
                BindData();
                //this.gvRider.Columns["Discount"].Visible = false;
                //this.gvProducts.Columns["Discountprice"].Visible = false;
                int idx = 1;
                foreach (DataGridViewRow row in gvRider.Rows)
                {
                    row.Cells[0].Value = idx;
                    idx++;
                }

            }
        }

        private void ViewRider_Load(object sender, EventArgs e)
        {
            RiderDL.readfromFile("RiderData.txt");
            //int idx = 1;
            List<RiderBL> list = new List<RiderBL>(RiderDL.RiderList);
            gvRider.DataSource = list;
            MessageBox.Show(list[0].EmpName1);
            //this.gvRider.Rows.Add();
            //this.gvProducts.Columns["Discount"].Visible = false;
            //this.gvProducts.Columns["Discountprice"].Visible = false;

            /*foreach (DataGridViewRow row in gvRider.Rows)
            {
                row.Cells[0].Value = idx;
                idx++;
            }*/
        }
    }
}
