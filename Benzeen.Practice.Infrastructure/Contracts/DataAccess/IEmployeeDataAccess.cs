using Benzeen.Practice.Data.Entities.Employee;
using Benzeen.Practice.Infrastructure.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Infrastructure.Contracts.DataAccess
{
    public interface IEmployeeDataAccess
    {
        List<EmployeeDetailsEntities> GetAll();
        EmployeeDetailsEntities GetById(int id);
        public int Post(EmployeeRequest employeeRequest);
        public int Update(EmployeeRequest employeeRequest);
        public int Delete(int Id);
        public EmployeeResponse Multi();
    }
}
    