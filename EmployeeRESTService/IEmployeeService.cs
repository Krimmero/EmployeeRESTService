using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   BodyStyle = WebMessageBodyStyle.Bare,
                   UriTemplate = "GetEmployeeList/")]
        List<Employee> GetEmployeeList();

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Json,
             RequestFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "GetEmployeeById/{id}")]
        Employee GetEmployeeById(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Json,
             RequestFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "GetEmployeeByLastName/{lastNameFragment}")]
        IEnumerable<Employee> GetEmployeeByLastName(string lastNameFragment);

        [OperationContract]
        [WebInvoke(Method = "POST",
             ResponseFormat = WebMessageFormat.Json,
             RequestFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "AddEmployee/")]
        string AddEmployee(Employee employee);

        [OperationContract]
        [WebInvoke(Method = "PUT",
             ResponseFormat = WebMessageFormat.Json,
             RequestFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "UpdateEmployee/{id}")]
        string UpdateEmployee(Employee employee, string id);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
              ResponseFormat = WebMessageFormat.Json,
              RequestFormat = WebMessageFormat.Json,
              BodyStyle = WebMessageBodyStyle.Bare,
              UriTemplate = "DeleteEmployee/{id}")]
        string DeleteEmployee(string id);
    }
}
