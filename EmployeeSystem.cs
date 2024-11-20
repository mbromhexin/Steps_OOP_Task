using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps_OOP_01
{

    /*
 By AbdelRazek mohamed
 All Method Need Alot Of Logic But I Tried To Implement Simple System regardless Complecated Logic

 */

    public class EmployeeSystem
    {
        public List<Employee> empList = new List<Employee>();

        
        public void ShowMenu()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*** Hello From Employee System *** ");
            Console.WriteLine($"*** We Have {empList.Count()} Employees *** ");
            Console.WriteLine("**********************************");
            Console.WriteLine("|1) Add Employee");
            Console.WriteLine("|2) Update");
            Console.WriteLine("|3) Delete");
            Console.WriteLine("|4) Search");
            Console.WriteLine("|5) Display All Employee");
            Console.WriteLine("|6) Exit");

           
        }

        public void AddEmployee() // Add Employee
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Employee Data");
            Console.Write("Name : ");
            employee.SetName(Console.ReadLine());
            Console.Write("Address : ");
            employee.SetAddress(Console.ReadLine());
            Console.Write("Phone : ");
            employee.SetPhone(Console.ReadLine());
            Console.Write("Salary : ");
            employee.SetSalary(Convert.ToDouble(Console.ReadLine()));
            empList.Add(employee);

            
        }

        public void Delete(int employeeID)
        {
            if(empList.Count > 0)
            {

            }
            else
            {
                Console.WriteLine("Delet Method Msg : There no Data");
            }
        }




        public Employee GetEmployee(int employeeID) 
        {
            Employee employee = new Employee();
            if(empList.Count > 0 && employeeID != null)
            {
                foreach (Employee emp in empList) 
                {
                    if(emp.GetId() == employeeID)
                    {
                        return emp;
                    }
                }
            }
            return employee;
        }



        public void Update(Employee employee)
        {
            if (empList.Count > 0 && employee != null)
            {
                Employee emp = empList.Find(e => e.GetId() == employee.GetId());
                Console.WriteLine("Enter New Name: ");
                string newName = Console.ReadLine();
                emp.SetName(newName);
                Console.WriteLine("Enter New Address: ");
                string newAddress = Console.ReadLine();
                emp.SetAddress(newAddress);
                Console.WriteLine("Enter New Phone: ");
                string newPhone = Console.ReadLine();
                emp.SetPhone(newPhone);
                Console.WriteLine("Enter New Salary: ");
                int newSalary =Convert.ToInt32(Console.ReadLine());
                emp.SetSalary(newSalary);

                Console.WriteLine($"Employee {emp.GetName()} Updated Succesfuly");

            }
            Console.WriteLine($"Update Method Error : Enter Valid Employee");
        }




        public void Delete(Employee employee)
        {
            if (empList.Count > 0 && employee != null) 
            { 
                empList.Remove(employee);
            }
        }
        


        public List<Employee> Search(string value)
        {
            List<Employee> searchList = new List<Employee>();
            if (!string.IsNullOrEmpty(value))
            {
                foreach (var emp in empList)
                {
                    if (emp.GetId().Equals(value) || emp.GetName().Equals(value) || emp.GetAddress().Equals(value) || emp.GetPhone().Equals(value) || emp.GetSalary().ToString().Equals(value))
                    {
                        searchList.Add(emp);
                    }
                }
                return searchList;
          
            }
            else
            {
                return searchList; 
            }
           
        }


        public void ShowSearchList(List<Employee> searchList)
        {
            if (searchList.Count > 0)
            {
                foreach(var emp in searchList)
                {
                    emp.DisplayInfo();
                }
            }
            else
            {
                Console.WriteLine("There Is Now Data From ShowSearchList Method");
            }
        }











        //Display All Employee
        public void ShowAllEmployee()
        {
            if (empList.Count > 0)
            {
                foreach (Employee emp in empList)
                {
                    emp.DisplayInfo();
                }
            }
            else 
            { 
                Console.WriteLine("There Is No Data"); 
            }
           
        }

      












    }
}
