using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPIEntities.Entities;

namespace DataAccessLayer
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        private readonly EmployeeDbContext _context;
        public EmployeeDataAccess(EmployeeDbContext context)
        {
            _context = context;
        }
        public int InsertNewEmployee(Employee emp)
        {
            _context.Employee.Add(emp);
            return _context.SaveChanges();
        }
        public List<Employee> GetEmployees()
        {
            return _context.Employee.ToList();
            //return (List<Employee>)_context.Employee.Select(x => new { x.EmpId,x.EmpName,x.Age,x.Email,x.Designation,x.Gender,x.Salary,x.JoiningDate });
        }
        public Employee GetEmployeeById(long empId)
        {
            return _context.Employee.FirstOrDefault(e => e.EmpId == empId);
        }
        public int DeleteEmployee(long empId)
        {
            Employee emp = _context.Employee.FirstOrDefault(x => x.EmpId == empId);
            _context.Employee.Remove(emp);
            return _context.SaveChanges();
        }
        public int UpdateEmployee(Employee emp)
        {
            var employee = _context.Employee.FirstOrDefault(x => x.EmpId == emp.EmpId);
            employee.EmpName = emp.EmpName;
            employee.Age = emp.Age;
            employee.Designation = emp.Designation;
            employee.Salary = emp.Salary;
            employee.Gender = emp.Gender;
            employee.Email = emp.Email;
            employee.JoiningDate = emp.JoiningDate;
            return _context.SaveChanges();
        }

        public List<User> GetUsers()
        {
            return _context.User.ToList();
        }
    }
}
