using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BL;
using Project.DL;
using SignIn.BL;

namespace FinalProject
{
    public partial class EditRider : Form
    {
        RiderBL r;
        public EditRider(RiderBL rider)
        {
            InitializeComponent();
            r = rider;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            area newAREA = new area(float.Parse(Latitudetxt.Text), float.Parse(Longitudetxt.Text));
           // RiderBL newRider = new RiderBL(RiderNametxt.Text, RiderCNICtxt.Text, RiderPhonetxt.Text, RiderIDtxt.Text, int.Parse(RiderSalarytxt.Text), RiderVehicletxt.Text, 0, newAREA);
           // RiderDL.editRider(r, newRider);
        }

        private void EditRider_Load(object sender, EventArgs e)
        {

        }

        private void ProductTotalSelledtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
