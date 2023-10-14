using DotNet6.API.Model;
using Microsoft.AspNetCore.SignalR;

namespace DotNet6.API.Interface
{
    public interface IEmployee
    {
        Employee GetEmployeeById(int empId);
        List<Employee> GetEmployees();
    }
}
