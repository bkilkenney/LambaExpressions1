using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Brad" },
                new Employee { ID = 102, Name = "Carol" },
                new Employee { ID = 103, Name = "Doris" },
                new Employee { ID = 104, Name = "Edgar" },
            };

            Employee employee = listEmployees.Find(Emp => Emp.ID == 101);  //EMP is anonymous method of type Employee
                                                                           //Find method being invoked on listEmployees object
                                                                          //Emp is inferred to be a listEmployees object
                                                                          //This expression is ultimately saying find me employee ID 101

            Console.WriteLine("The employee is {0} and the employee's ID is {1}", employee.Name, employee.ID);  //This is not linked to an object(employee)
            
        }
       

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }


        }
    }
}

