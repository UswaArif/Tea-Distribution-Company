using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.BL
{
    public class UserBL
    {
        private string UserRole;
        private string UserName;
        private string UserPassword;
        private string ReEnter;

        public string UserRole1 { get => UserRole; set => UserRole = value; }
        public string UserName1 { get => UserName; set => UserName = value; }
        public string UserPassword1 { get => UserPassword; set => UserPassword = value; }
        public string ReEnter1 { get => ReEnter; set => ReEnter = value; }
        public UserBL(string UserRole, string UserName, string UserPassword, string ReEnter)
        {
            this.UserRole = UserRole;
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.ReEnter = ReEnter;
        }
        public UserBL(string UserName, string UserPassword)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
        }
        public bool isEmployee()
        {
            if (this.UserRole == "employee")
            {
                return true;
            }
            return false;
        }
        public bool isManager()
        {
            if (this.UserRole == "manager")
            {
                return true;
            }
            return false;
        }
     
    }
}
