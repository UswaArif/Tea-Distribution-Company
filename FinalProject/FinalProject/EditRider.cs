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
            area newAREA = new area(float.Parse(Latitudetxt.Text), float.Parse(Logitutidetxt.Text));
            RiderBL newRider = new RiderBL(RiderNametxt.Text, RiderCinictxt.Text, RiderPhonetxt.Text, RiderIDtxt.Text, int.Parse(RiderSalarytxt.Text), RiderVechiletxt.Text, 0, newAREA);
            RiderDL.editRider(r, newRider);
        }
    }
}
