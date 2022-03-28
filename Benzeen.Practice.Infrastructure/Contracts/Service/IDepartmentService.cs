using Benzeen.Practice.Infrastructure.DTO.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Infrastructure.Contracts.Service
{
    public interface IDepartmentService
    {
        List<DepartmentDetailsResponse> GetAll();
        List<DepartmentandEmployee> GetAllMix();
        DepartmentDetailsResponse GetById(int id);
        public int  Post(DepartmentRequest departmentRequest);
        int Update(DepartmentRequest departmentRequest);
        int Delete(int id);
        public DepartmentResponse Multi();
    }
}
