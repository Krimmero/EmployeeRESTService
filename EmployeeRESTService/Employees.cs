using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EmployeeRESTService
{
    public partial class Employees
    {
        private static readonly Employees _instance = new Employees();

        private Employees()
        {
            
        }

        public static Employees Instance
        {
            get { return _instance; }
        }
        
        public List<Employee> EmployeeList
        {
            get { return employees; }
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.Find(e => e.Id == id);
        }

        public Employee AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                employees.Add(employee);
                return employee;
            }
        }

        private List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id = 1, FirstName = "Kim", LastName = "Olsen", PhoneNumber = 12345678, Position = "Boss" },
            new Employee() { Id = 2, FirstName = "Tine", LastName = "Olsen", PhoneNumber = 12345678, Position = "Worker" },
            new Employee() { Id = 3, FirstName = "Louie", LastName = "Olsen", PhoneNumber = 12345678, Position = "Worker" }
        };  
    }
}