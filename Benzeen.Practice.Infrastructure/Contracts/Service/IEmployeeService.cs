using Benzeen.Practice.Infrastructure.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Infrastructure.Contracts.Service
{
     public interface IEmployeeService
    {
        List<EmployeeDetailsResponse> GetAll(); 
        EmployeeDetailsResponse GetById(int ID);
        int Post(EmployeeRequest employeeRequest);
        int Update(EmployeeRequest employeeRequest);
        int Delete(int Id);
        public EmployeeResponse Multi();
        
    }
}
