
using Benzeen.Practice.Data.Entities.Department;
using Benzeen.Practice.Infrastructure.Common;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.DTO.Department;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.DataAccess
{
    public class DepartmentDataAccess:BaseDataAccess,IDepartmentDataAccess
    {
        public DepartmentDataAccess(IConfiguration config) : base(config)
        {
        }

        public List<DepartmentDetailsEntities> GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var result = connection.Query<DepartmentDetailsEntities>(Constants.StoredProcedureDepartment.GetAll, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public List<DepartmentandEmployee> GetAllMix()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var result = connection.Query<DepartmentandEmployee>(Constants.StoredProcedureDepartment.GetAllMix,commandType:CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public DepartmentDetailsEntities GetById(int Id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add(Constants.SQLParameterName.Id, Id);
                var result = connection.Query<DepartmentDetailsEntities>(Constants.StoredProcedureDepartment.GetById,parameter,commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public int Post(DepartmentRequest departmentRequest)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameter = new DynamicParameters();   
                parameter.Add(Constants.SQLParameterDepartment.HeadOfDepartment, departmentRequest.HeadOfDepartment);
                parameter.Add(Constants.SQLParameterDepartment.departmentname, departmentRequest.DepartmentName);
                parameter.Add(Constants.SQLParameterDepartment.NumberOfEmployee, departmentRequest.NumberOfEmployee);
                var result = connection.Execute(Constants.StoredProcedureDepartment.Post, parameter, commandType: CommandType.StoredProcedure);
                return result;

            }  
        }
        public int Update(DepartmentRequest departmentRequest)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add(Constants.SQLParameterDepartment.ID, departmentRequest.ID);
                parameter.Add(Constants.SQLParameterDepartment.HeadOfDepartment, departmentRequest.HeadOfDepartment);
                parameter.Add(Constants.SQLParameterDepartment.departmentname, departmentRequest.DepartmentName);
                parameter.Add(Constants.SQLParameterDepartment.NumberOfEmployee, departmentRequest.NumberOfEmployee);
                var result = connection.Execute(Constants.StoredProcedureDepartment.Put,parameter, commandType: CommandType.StoredProcedure);
                return result;

            }
        }
        public int Delete(int Id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add(Constants.SQLParameterDepartment.ID, Id);
                var result = connection.Execute(Constants.StoredProcedureDepartment.Delete,parameter,commandType: CommandType.StoredProcedure);
                return result;

            }
        }
        
       public DepartmentResponse Multi()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var departmentMulti = new DepartmentResponse();
                var result = connection.QueryMultiple(Constants.StoredProcedureDepartment.TwoResult, commandType: CommandType.StoredProcedure);
                departmentMulti.Departmentlist = result.Read<DepartmentDetailsResponse>().AsList();
                departmentMulti.Count = result.Read<int>().FirstOrDefault();
                return departmentMulti;


            }
        }

    
    }
}
