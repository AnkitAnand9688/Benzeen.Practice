using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Data.Entities.Department
{
    public class DepartmentEntities
    {
        public List<DepartmentDetailsEntities> Departmentlist { get; set; }
        public int Count { get; set; }
    }
    public class DepartmentDetailsEntities
    {
        public int Id { get; set; }
        public string HeadOfDepartment { get; set; }
        public string DepartmentName { get; set; }
        public int NumberOfEmployee { get; set; }
    }
}
