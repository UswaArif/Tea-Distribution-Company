﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignIn.BL;

namespace Project.BL
{
    public class RiderBL : EmployeeBL
    {
        private area RiderArea;
        private string VehicleId;
        private int TotalDelivery;
        public string VehicleId1 { get => VehicleId; set => VehicleId = value; }
        public int TotalDelivery1 { get => TotalDelivery; set => TotalDelivery = value; }
        internal area RiderArea1 { get => RiderArea; set => RiderArea = value; }

        public RiderBL(string name, string CNIC, string phoneNumber,string Id, int salary, string vehicleAssign,int totalDelivery,bool isSalaryPaid, area RiderArea):base(name,CNIC,phoneNumber,Id,salary,isSalaryPaid)
        {
            this.EmpName1 = name;
            this.EmpCnic1 = CNIC;
            this.EmpPhone1 = phoneNumber;
            this.EmpId1 = Id;
            this.EmpSalary1 = salary;
            this.VehicleId1 = vehicleAssign;
            this.RiderArea1 = RiderArea;
            this.IsSalaryPaid = isSalaryPaid;
            this.TotalDelivery1 = totalDelivery;
        } 
    }
}
