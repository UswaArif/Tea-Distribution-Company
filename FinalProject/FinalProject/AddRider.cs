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
    public partial class AddRider : Form
    {
        public AddRider()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRiderAdd_Click(object sender, EventArgs e)
        {
            txtRiderLatitude.Text = RiderMap.SetValueForLatitude;
            txtRiderLongitude.Text = RiderMap.SetValueForLongitude;
            string path = "RiderData.txt";

            string Ridername = txtRiderName.Text;
            string RiderId = txtRiderID.Text;
            string RiderCNIC = txtRiderCNIC.Text;
            string RiderPhoneNumber = txtRiderPhone.Text;
            int RiderSalary = int.Parse(txtRiderSalary.Text);
            string VehicleId = txtRiderVehicle.Text;

            float latitude = float.Parse(txtRiderLatitude.Text);
            float longitude = float.Parse(txtRiderLongitude.Text);
            area a = new area(latitude, longitude);
            RiderBL r1 = new RiderBL(Ridername, RiderCNIC, RiderPhoneNumber, RiderId, RiderSalary, VehicleId, 0, false, a);
            RiderDL.addRiderIntoList(r1);

            RiderDL.storeIntoFile(path, r1);
            
            MessageBox.Show("Rider added successfully.");
            clearDataFromForm();
            Form addRider = new ViewRider();
            addRider.ShowDialog();
        }

        private void btnRiderMap_Click(object sender, EventArgs e)
        {
            Form ridermap = new RiderMap();

            ridermap.ShowDialog();
        }

        private void clearDataFromForm()
        {
            txtRiderName.Text = "";
            txtRiderID.Text = "00";
            txtRiderCNIC.Text = "XXXXX-XXXXXXX-X";
            txtRiderPhone.Text = "XXXX-XXXXXXX";
            txtRiderSalary.Text = "00";
            txtRiderVehicle.Text = "00";
            txtRiderLatitude.Text = "0.0";
            txtRiderLongitude.Text = "0.0";
        }

        private void AddRider_Load(object sender, EventArgs e)
        {
            txtRiderLatitude.Text = RiderMap.SetValueForLatitude;
            txtRiderLongitude.Text = RiderMap.SetValueForLongitude;
        }
    }
}
