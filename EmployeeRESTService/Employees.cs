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


        public IEnumerable<Employee> GetEmployeeByLastName(string lastNameFragment)
        {
            return employees.Where(e => e.LastName.ToLower().Contains(lastNameFragment.ToLower()));
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

        public bool UpdateEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                int employeeIndex = employees.FindIndex(e => e.Id == employee.Id);

                if (employeeIndex == -1)
                {
                    return false;
                }
                else
                {
                    employees.RemoveAt(employeeIndex);
                    employees.Add(employee);
                    return true;
                }
            }

        }

        public bool DeleteEmployee(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                int idToDelete = employees.FindIndex(e => e.Id == Convert.ToInt32(id));

                if (idToDelete == -1)
                {
                    return false;
                }
                else
                {
                    employees.RemoveAt(idToDelete);
                    return true;
                }
            }
        }

        private List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id = 1, FirstName = "Kim", LastName = "Olsen", PhoneNumber = 12345678, Position = "Boss father" },
            new Employee() { Id = 2, FirstName = "Tine", LastName = "Olsen", PhoneNumber = 12345678, Position = "Worker mother" },
            new Employee() { Id = 3, FirstName = "Louie", LastName = "Olsen", PhoneNumber = 12345678, Position = "wonderkid" },
            new Employee() { Id = 4, FirstName = "Victoria", LastName = "Egholm", PhoneNumber = 12345678, Position = "Lazy cousine" },
            new Employee() { Id = 5, FirstName = "Isabella", LastName = "Egholm", PhoneNumber = 12345678, Position = "Noise cousine" },
            new Employee() { Id = 6, FirstName = "Eva", LastName = "Leisted Kroll", PhoneNumber = 12345678, Position = "Grandmother" }
        };  
    }
}