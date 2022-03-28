using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Infrastructure.DTO.Department
{
    public class DepartmentRequest
    {
        public int ID { get; set; }
        public string HeadOfDepartment { get; set; }
        public string DepartmentName { get; set; }
        public int NumberOfEmployee { get; set; }
    }
    public class DepartmentandEmployee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? City { get; set; }
        public string? Department { get; set; }
        public int DepartmentID { get; set; }
        public string HeadOfDepartment { get; set; }
        public string DepartmentName { get; set; }
        public int NumberOfEmployee { get; set; }

       

    }
}
