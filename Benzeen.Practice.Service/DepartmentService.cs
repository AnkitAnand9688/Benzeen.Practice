using AutoMapper;
using Benzeen.Practice.DataAccess;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Infrastructure.DTO.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Service
{
    public class DepartmentService:IDepartmentService
    {
        private readonly IDepartmentDataAccess _departmentDataAccess;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentDataAccess departmentDataAccess,IMapper mapper)
        {
            _departmentDataAccess = departmentDataAccess;
            _mapper = mapper;
        }
        public List<DepartmentDetailsResponse> GetAll()
        {
            var departmentEntities  = _departmentDataAccess.GetAll();
            var departmentResponse = _mapper.Map<List<DepartmentDetailsResponse>>(departmentEntities);
            return departmentResponse;

        }
        public List<DepartmentandEmployee> GetAllMix()
        {
            var departmentEmployee = _departmentDataAccess.GetAllMix();
            return departmentEmployee;
        }
        public DepartmentDetailsResponse GetById(int id)
        {
            var departmentEntities = _departmentDataAccess.GetById(id);
            var departmentResponse = _mapper.Map<DepartmentDetailsResponse>(departmentEntities);
            return departmentResponse;
        }
        public int Post(DepartmentRequest departmentRequest)
        {
            var departmentEntity = _departmentDataAccess.Post(departmentRequest);
            return departmentEntity;
        }

        

        public int Update(DepartmentRequest departmentRequest)
        {
            var departmentEntity = _departmentDataAccess.Update(departmentRequest);
            return departmentEntity;
        }
        public int Delete(int Id)
        {
            var departmentEntity = _departmentDataAccess.Delete(Id);
            return departmentEntity;
        }
        public DepartmentResponse Multi()
        {
            var DepartmentMulti = _departmentDataAccess.Multi();
            return DepartmentMulti;
        }
    }
}
