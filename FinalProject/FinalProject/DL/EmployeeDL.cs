using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using System.IO;

namespace Project.DL
{
    class EmployeeDL
    {
        private static LinkedList<EmployeeBL> EmpList = new LinkedList<EmployeeBL>();
        public static LinkedList<EmployeeBL> EmpList1 { get => EmpList; set => EmpList = value; }

        public static void addIntoList(EmployeeBL e1)
        {
            EmpList.AddLast(e1);
        }

        public static EmployeeBL isEmployeeExists(string Id)
        {
            foreach (EmployeeBL e1 in EmpList1)
            {
                if (e1.EmpId1 == Id)
                {
                    return e1;
                }
            }
            return null;
        }

        internal static void storeAllEmployeeIntoFile(EmployeeBL newEmployee)
        {
            throw new NotImplementedException();
        }

        public static EmployeeBL searchEmployee(string CNIC)
        {
            foreach (EmployeeBL e1 in EmpList1)
            {
                if (e1.EmpCnic1 == CNIC)
                {
                    return e1;
                }
            }
            return null;
        }

        public static void editEmployee(EmployeeBL previous, EmployeeBL updated)
        {
            foreach (EmployeeBL e1 in EmpList1)
            {
                if (e1.EmpName1 == previous.EmpName1 && e1.EmpCnic1 == previous.EmpCnic1 && e1.EmpPhone1 == previous.EmpPhone1 && e1.EmpId1 == previous.EmpId1 && e1.EmpSalary1 == previous.EmpSalary1)
                {
                    e1.EmpName1 = updated.EmpName1;
                    e1.EmpCnic1 = updated.EmpCnic1;
                    e1.EmpPhone1 = updated.EmpPhone1;
                    e1.EmpId1 = updated.EmpId1;
                    e1.EmpSalary1 = updated.EmpSalary1;
                }
            }
        }

        public static void deleteEmployee(EmployeeBL delete)
        {
            if (delete != null)
            {
                foreach (EmployeeBL e1 in EmpList1)
                {
                    if (e1.EmpName1 == delete.EmpName1 && e1.EmpCnic1 == delete.EmpCnic1 && e1.EmpPhone1 == delete.EmpPhone1 && e1.EmpId1 == delete.EmpId1 && e1.EmpSalary1 == delete.EmpSalary1)
                    {
                        EmpList1.Remove(e1);
                    }
                }
            }
        }

        public static bool readEmployeefromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string Id = splittedRecord[1];
                    string phoneNumber = splittedRecord[2];
                    int salary = int.Parse(splittedRecord[3]);
                    string CNIC = splittedRecord[4];
                    bool isSalaryPaid = bool.Parse(splittedRecord[5]);
                                
                    EmployeeBL e = new EmployeeBL(name, CNIC, phoneNumber, Id, salary,isSalaryPaid);
                    addIntoList(e);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void storeIntoFile(string path, EmployeeBL e)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(e.EmpName1 + "," + e.EmpId1 + "," + e.EmpPhone1 + "," + e.EmpSalary1 + "," + e.EmpCnic1 + "," + e.IsSalaryPaid);
            f.Flush();
            f.Close();
        }

        public static void storeAllEmployeeIntoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (EmployeeBL storedemployee in EmpList1)
            {
                f.WriteLine(storedemployee.EmpName1 + "," + storedemployee.EmpId1 + "," + storedemployee.EmpPhone1 + "," + storedemployee.EmpSalary1 + "," + storedemployee.EmpCnic1 + "," + storedemployee.IsSalaryPaid);
            }
            f.Flush();

            f.Close();
        }
    }
}
