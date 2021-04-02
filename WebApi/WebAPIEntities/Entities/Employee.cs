using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPIEntities.Entities
{
    public partial class Employee
    {
        public long EmpId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public string Designation { get; set; }
        public string Gender { get; set; }
        public long Salary { get; set; }
        public DateTime? JoiningDate { get; set; }
    }
}
