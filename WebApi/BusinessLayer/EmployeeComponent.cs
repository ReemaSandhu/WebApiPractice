using BusinessLayer.Interface;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using WebAPIEntities.Entities;

namespace BusinessLayer
{
    public class EmployeeComponent : IEmployeeComponent
    {
        private readonly IEmployeeDataAccess _employeeDataAccess;
        public EmployeeComponent(IEmployeeDataAccess employeeDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
        }

        public int DeleteEmployee(long empId)
        {
            return _employeeDataAccess.DeleteEmployee(empId);
        }

        public Employee GetEmployeeById(long empId)
        {
            return _employeeDataAccess.GetEmployeeById(empId);
        }

        public List<Employee> GetEmployees()
        {
            return _employeeDataAccess.GetEmployees();
        }

        public List<User> GetUsers()
        {
            return _employeeDataAccess.GetUsers();
        }

        public int InsertNewEmployee(Employee emp)
        {
            return _employeeDataAccess.InsertNewEmployee(emp);
        }

        public int UpdateEmployee(Employee emp)
        {
            return _employeeDataAccess.UpdateEmployee(emp);
        }
    }
}
