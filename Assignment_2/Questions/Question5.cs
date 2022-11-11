using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Questions
{
    internal class Employees
    {
            public int emp_id;
            public string Emp_Name;
            public int Emp_Salary;
            public string Emp_Department;


            public void ShowData()
            {
                List<Employees> employee = new List<Employees>()
                {
                    new Employees{emp_id = 101, Emp_Name = "Abhishek",
                             Emp_Salary = 50000,Emp_Department = "XYZ"},
                    new Employees{emp_id = 102, Emp_Name = "Ruturaj",
                             Emp_Salary = 65000,Emp_Department = "ABC"},
                    new Employees{emp_id = 103, Emp_Name = "Sonam",
                             Emp_Salary = 45000,Emp_Department = "ABC"},
                    new Employees{emp_id = 104, Emp_Name = "Damodhar",
                             Emp_Salary = 20000,Emp_Department = "XYZ"},
                    new Employees{emp_id = 105, Emp_Name = "Sandhya",
                             Emp_Salary = 70000,Emp_Department = "ABC"},
                    new Employees{emp_id = 106, Emp_Name = "Sagar",
                             Emp_Salary = 40000,Emp_Department = "XYZ"},
                };

                var query = employee.Where(emp => emp.Emp_Department == "XYZ").OrderByDescending(
                                            sal => sal.Emp_Salary);
                foreach (Employees emp in query)
                    {
                        Console.WriteLine(emp.emp_id + " " +
                        emp.Emp_Name + " " +
                        emp.Emp_Salary + " " +
                        emp.Emp_Department);
                    }
            }
    }
    }


