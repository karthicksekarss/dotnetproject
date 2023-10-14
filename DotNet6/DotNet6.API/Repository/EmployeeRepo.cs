using DotNet6.API.Interface;
using DotNet6.API.Model;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace DotNet6.API.Repository
{
    public class EmployeeRepo : IEmployee
    {
        public string guidCode = Guid.NewGuid().ToString();

        public Employee GetEmployeeById(int empId)
        {

            return new Employee
            {
                EmpId = empId,
                EmpName = "Employee User Name 1",
                EmpSalary = 1300000,
                GuidCode = guidCode

            };
        }

        public List<Employee> GetEmployees()
        {
            var emplist = new List<Employee>();
            emplist.Add(new Employee
            {
                EmpId = 1001,
                EmpName = "Employee User Name 1",
                EmpSalary = 1300000
            });

            emplist.Add(new Employee
            {
                EmpId = 1002,
                EmpName = "Employee User Name 2",
                EmpSalary = 1300001
            });

            return emplist;

        }
    }
}
