using System;
using System.Collections.Generic;
using System.Text;
using WebAPIEntities.Entities;

namespace BusinessLayer.Interface
{
    public interface IEmployeeComponent
    {
        int InsertNewEmployee(Employee emp);
        List<Employee> GetEmployees();
        int DeleteEmployee(long empId);
        int UpdateEmployee(Employee emp);
        Employee GetEmployeeById(long empId);
        List<User> GetUsers();
    }
}
