using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIEntities.Entities;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]/[action]")]
    public class EmployeeController:ControllerBase
    {
        private readonly IEmployeeComponent _employeeComponent;
        public EmployeeController(IEmployeeComponent employeeComponent)
        {
            _employeeComponent = employeeComponent;
        }
        [HttpGet]
        public IActionResult GetEmployee()
        {
            var result = _employeeComponent.GetEmployees();
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetEmployeeById(long id)
        {
            var result = _employeeComponent.GetEmployeeById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateEmployee(Employee emp)
        {
            _employeeComponent.InsertNewEmployee(emp);
            return Ok("Record inserted Successfully!");
        }
        [HttpDelete]
        public IActionResult RemoveEmployee(long id)
        {
            _employeeComponent.DeleteEmployee(id);
            return Ok("Recod Deleted Successfully!");
        }
        [HttpPut]
        public IActionResult UpdateEmployee(Employee emp)
        {
            _employeeComponent.UpdateEmployee(emp);
            return Ok("Record Updated Successfully");
        }

    }
}
