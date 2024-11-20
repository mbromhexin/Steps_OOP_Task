namespace Steps_OOP_01
{



    /*
 By AbdelRazek mohamed
 All Method Need Alot Of Logic But I Tried To Implement Simple System regardless Complecated Logic

 */

    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee();
            //emp1.SetName("Abdelrazek Mohammed");
            //emp1.SetAddress("Assiut");
            //emp1.SetPhone("01855181632");
            //emp1.SetSalary(7500);

            EmployeeSystem EmpSystem = new EmployeeSystem();
            
            while (true) 
            {
                
                EmpSystem.ShowMenu();
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        //Console.WriteLine("Now Add Employee");
                        EmpSystem.AddEmployee();
                        break;
                    case 2:
                        //Console.WriteLine("Now Update");
                        Console.Clear();
                        //Console.WriteLine("Now Delete");
                        Console.Write("Enter Valid Id To Update: ");
                        int idForUpdate = Convert.ToInt32(Console.ReadLine());
                        Employee employeeForUpdate = EmpSystem.GetEmployee(idForUpdate);
                        EmpSystem.Update(employeeForUpdate);
                        break;
                    case 3:
                        Console.Clear();
                        //Console.WriteLine("Now Delete");
                        Console.Write("Enter Valid Id To Delete: ");
                        int employeeId = Convert.ToInt32(Console.ReadLine());
                        Employee employee = EmpSystem.GetEmployee(employeeId);
                        EmpSystem.Delete(employee);
                        break;
                    case 4:
                        Console.Clear();
                        //Console.WriteLine("Now Search");
                        Console.Write("Enter Search Value: ");
                        string searchValue = Console.ReadLine();
                        List<Employee> result = EmpSystem.Search(searchValue);
                        EmpSystem.ShowSearchList(result);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Now Display All Employee");
                        EmpSystem.ShowAllEmployee();
                        break;
                    case 6://Exit
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }




            
            


            


               

        }
    }
}
