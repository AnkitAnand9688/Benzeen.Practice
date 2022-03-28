using AutoMapper;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Infrastructure.DTO.Employee;
using System.Linq;

namespace Benzeen.Practice.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeDataAccess _employeeDataAccess;
        private readonly IMapper _mapper;
       public EmployeeService(IEmployeeDataAccess employeeDataAccess , IMapper mapper)
        {
            _employeeDataAccess = employeeDataAccess;
            _mapper = mapper;
        }
        public List<EmployeeDetailsResponse> GetAll()
        {
            var employeeEntity = _employeeDataAccess.GetAll();
            var emoployeeresponse = _mapper.Map<List<EmployeeDetailsResponse>>(employeeEntity);
            return emoployeeresponse;
        }
        public EmployeeDetailsResponse GetById(int ID)
        {
            var emoployeeEntity = _employeeDataAccess.GetById(ID);
            var employeeResponce = _mapper.Map<EmployeeDetailsResponse>(emoployeeEntity);
            return employeeResponce;
        }
        public int Post(EmployeeRequest employeeRequest)
        {
            var employeeEntity = _employeeDataAccess.Post(employeeRequest);
            return employeeEntity;
        }
        public int Update(EmployeeRequest employeeRequest)
        {
            var employeeEntity = _employeeDataAccess.Update(employeeRequest);
            return employeeEntity;
        }
        public int Delete(int Id)
        {
            var employeeEntity = _employeeDataAccess.Delete(Id);
            return employeeEntity;
        }
        public EmployeeResponse Multi()
        {
            var employeeMulti = _employeeDataAccess.Multi();
            return employeeMulti;
        }
        
    }
}