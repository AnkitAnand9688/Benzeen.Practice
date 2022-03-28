using Benzeen.Practice.Data.Entities.Department;
using Benzeen.Practice.Infrastructure.DTO.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Infrastructure.Contracts.DataAccess
{
    public interface IDepartmentDataAccess
    {
        List<DepartmentDetailsEntities> GetAll();
        List<DepartmentandEmployee> GetAllMix();
        DepartmentDetailsEntities GetById(int id);
        public int Post(DepartmentRequest departmentRequest);
        public int Update(DepartmentRequest departmentRequest);
        public int Delete(int id);
        DepartmentResponse Multi();
    }
}
