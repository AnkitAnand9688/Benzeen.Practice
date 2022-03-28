using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Infrastructure.DTO.Employee
{
    public class EmployeeResponse
    {
        public List<EmployeeDetailsResponse> Employeeslist { get; set; }
        public int Count { get; set; }

    }
    public class EmployeeDetailsResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? City { get; set; }
        public string? Department { get; set; }   
    }
    
}
