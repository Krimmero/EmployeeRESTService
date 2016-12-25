using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        private List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id = 1, FirstName = "Kim", LastName = "Olsen", PhoneNumber = 12345678, Position = "Boss" },
            new Employee() { Id = 2, FirstName = "Tine", LastName = "Olsen", PhoneNumber = 12345678, Position = "Worker" },
            new Employee() { Id = 3, FirstName = "Louie", LastName = "Olsen", PhoneNumber = 12345678, Position = "Worker" }
        };  
    }
}