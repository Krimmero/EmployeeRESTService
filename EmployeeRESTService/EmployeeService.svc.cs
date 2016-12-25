using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployeeList()
        {
            return Employees.Instance.EmployeeList;
        }

        public Employee GetEmployeeById(string id)
        {
            return Employees.Instance.GetEmployeeById(int.Parse(id));
        }

        public string AddEmployee(Employee employee)
        {
            Employee newEmployee = Employees.Instance.AddEmployee(employee);
            return "id: " + newEmployee.Id;
        }
    }
}
