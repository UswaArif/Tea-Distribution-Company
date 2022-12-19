using SignIn.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.DL
{
    class UserDL
    {
        private static LinkedList<UserBL> MyUserList = new LinkedList<UserBL>();

        public static LinkedList<UserBL> MyUserList1 { get => MyUserList; set => MyUserList = value; }
        public static void addIntoList(UserBL u)
        {
            MyUserList1.AddLast(u);
        }
        public static void storeUserIntoFile(UserBL user, string UserPath)
        {
            StreamWriter file = new StreamWriter(UserPath, true);
            foreach (UserBL storeUser in MyUserList1)
            {
                file.WriteLine(storeUser.UserRole1 + "," + storeUser.UserName1 + "," + storeUser.UserPassword1 + "," + storeUser.ReEnter1);
            }
            file.Flush();
            file.Close();
        }
        public static bool readUserFromFile(string UserPath)
        {
            StreamReader file = new StreamReader(UserPath);
            string record;
            if (File.Exists(UserPath))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string userRole = splittedRecord[0];
                    string userName = splittedRecord[1];
                    string userPassword = splittedRecord[2];
                    string ReEnter = splittedRecord[3];
                    UserBL newUser = new UserBL(userRole, userName, userPassword, ReEnter);
                    addIntoList(newUser);

                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void deleteUser(UserBL user)
        {
            for (int index = 0; index < MyUserList1.Count; index++)
            {
                if (MyUserList1.ElementAt(index).UserName1 == user.UserName1 && MyUserList1.ElementAt(index).UserPassword1 == user.UserPassword1)
                {
                    MyUserList1.Remove(MyUserList1.ElementAt(index));
                }
            }
        }
        public static void editUser(UserBL previous, UserBL Updated)
        {
            foreach (UserBL user in MyUserList1)
            {
                if (user.UserName1 == previous.UserName1 && user.UserPassword1 == previous.UserPassword1)
                {
                    user.UserName1 = Updated.UserName1;
                    user.UserPassword1 = Updated.UserPassword1;
                    user.UserRole1 = Updated.UserRole1;
                }
            }
        }
        public static bool checkUser(string value)
        {
            foreach (UserBL check in MyUserList1)
            {
                if (value == check.UserName1)
                {
                    return false;
                }
            }
            return true;
        }
        public static UserBL checkUser(UserBL U)
        {
            foreach (UserBL check in MyUserList1)
            {
                if (U.UserName1 == check.UserName1 && U.UserPassword1 == check.UserPassword1)
                {
                    return check;
                }
            }
            return null;
        }
    }
}
