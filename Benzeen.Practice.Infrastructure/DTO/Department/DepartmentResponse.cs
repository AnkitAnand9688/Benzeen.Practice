using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Infrastructure.DTO.Department
{
    public class DepartmentResponse
    {
        public List<DepartmentDetailsResponse> Departmentlist { get; set; }
        public int Count { get; set; }

    }
    public class DepartmentDetailsResponse
    {
        public int ID { get; set; }
        public string HeadOfDepartment { get; set; }
        public string DepartmentName { get; set; }
        public int NumberOfEmployee { get; set; }
    }

}
