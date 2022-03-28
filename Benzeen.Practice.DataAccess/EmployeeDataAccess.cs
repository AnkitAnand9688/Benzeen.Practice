using Benzeen.Practice.Data.Entities.Employee;
using Benzeen.Practice.Infrastructure.Common;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.DTO.Employee;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Benzeen.Practice.Infrastructure.Common;
using Microsoft.Extensions.Configuration;

namespace Benzeen.Practice.DataAccess
{
    public class EmployeeDataAccess : BaseDataAccess, IEmployeeDataAccess
    {
        public EmployeeDataAccess(IConfiguration config) : base(config)
        {
        }

        public List<EmployeeDetailsEntities> GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var result = connection.Query<EmployeeDetailsEntities>(Constants.StoredProcedureName.GetAll, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public EmployeeDetailsEntities GetById(int ID)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add(Constants.SQLParameterName.Id, ID);
                var result = connection.Query<EmployeeDetailsEntities>(Constants.StoredProcedureName.GetById,parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public int Post(EmployeeRequest employeeRequest)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add(Constants.SQLParameterName.Id, employeeRequest.Id);
                parameters.Add(Constants.SQLParameterName.Name, employeeRequest.Name);
                parameters.Add(Constants.SQLParameterName.Department, employeeRequest.Department);
                parameters.Add(Constants.SQLParameterName.City, employeeRequest.City);
                parameters.Add(Constants.SQLParameterName.Gender, employeeRequest.Gender);
                var result = connection.Execute(Constants.StoredProcedureName.Post, parameters, commandType: CommandType.StoredProcedure);
                return result;
            }

        }
        public int Update(EmployeeRequest employeeRequest)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parametear = new  DynamicParameters();
                parametear.Add(Constants.SQLParameterName.Id, employeeRequest.Id);
                parametear.Add(Constants.SQLParameterName.Name, employeeRequest.Name);
                parametear.Add(Constants.SQLParameterName.City, employeeRequest.City);
                var result = connection.Execute(Constants.StoredProcedureName.Put,parametear, commandType: CommandType.StoredProcedure);
                return result;

            }
        }
        public int Delete(int Id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add(Constants.SQLParameterName.Id, Id);
                var result = connection.Execute(Constants.StoredProcedureName.Delete, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public EmployeeResponse Multi()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var employeemulti = new EmployeeResponse();
                var result = connection.QueryMultiple(Constants.StoredProcedureName.TwoResult,commandType: CommandType.StoredProcedure);
                employeemulti.Employeeslist = result.Read<EmployeeDetailsResponse>().AsList();
                employeemulti.Count = result.Read<int>().FirstOrDefault();
                return employeemulti;

            }
        }
    }
}