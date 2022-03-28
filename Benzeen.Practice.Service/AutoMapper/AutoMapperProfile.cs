using AutoMapper;
using Benzeen.Practice.Data.Entities.Department;
using Benzeen.Practice.Data.Entities.Employee;
using Benzeen.Practice.Infrastructure.DTO.Department;
using Benzeen.Practice.Infrastructure.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Service.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeDetailsEntities, EmployeeDetailsResponse>();
             CreateMap<EmployeeEntities , EmployeeRequest>();
            CreateMap<DepartmentDetailsEntities, DepartmentDetailsResponse>();
            CreateMap<DepartmentEntities, DepartmentRequest>();    
        }
    }
}
