using System;
using System.Collections.Generic;
using System.Text;
using WebAPIEntities.Entities;

namespace DataAccessLayer.Interface
{
    public interface IEmployeeDataAccess
    {
        int InsertNewEmployee(Employee emp);
        List<Employee> GetEmployees();
        Employee GetEmployeeById(long empId);
        int DeleteEmployee(long empId);
        int UpdateEmployee(Employee emp);
        List<User> GetUsers();
    }
}
