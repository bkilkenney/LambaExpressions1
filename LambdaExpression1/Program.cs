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
            List<Employee> listEmployees = new List<Employee>();
            {
                new Employee { ID = 101, Name = "Brad" };
                new Employee { ID = 102, Name = "Carol" };
                new Employee { ID = 103, Name = "Doris" };
                new Employee { ID = 104, Name = "Edgar" };
            };

            Employee employee = listEmployees.Find(Emp => Emp.ID == 101);
            Console.WriteLine("ID: {0}, Name: {1}", employee.ID, employee.Name);  //This is not linked to an object(employee)
            
        }
       

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }


        }
    }
}

