using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignIn.BL;

namespace Project.BL
{
    class RiderBL : EmployeeBL
    {
        private area RiderArea;
        private string VehicleId;
        private int TotalDelivery;
        public string VehicleId1 { get => VehicleId; set => VehicleId = value; }
        public int TotalDelivery1 { get => TotalDelivery; set => TotalDelivery = value; }
        internal area RiderArea1 { get => RiderArea; set => RiderArea = value; }

        public RiderBL(string name, string CNIC, string phoneNumber,string Id, int salary, string vehicleAssign,int totalDelivery,bool isSalarypaid,area RiderArea):base(name,CNIC,phoneNumber,Id,salary,isSalarypaid)
        {
            this.EmpName1 = name;
            this.EmpCnic1 = CNIC;
            this.EmpPhone1 = phoneNumber;
            this.EmpId1 = Id;
            this.EmpSalary1 = salary;
            this.VehicleId1 = vehicleAssign;
            this.TotalDelivery1 = totalDelivery;
            this.IsSalaryPaid = isSalarypaid;
            this.RiderArea1 = RiderArea;
        } 
    }
}
