using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.Infrastructure.Common
{
    public class Constants
    {
        public class StoredProcedureName
        {
            public const string GetAll = "getall";
            public const string GetById = "getbyid";
            public const string Post = "post";
            public const string Put = "Update";
            public const string Delete = "deleteid";
            public const string TwoResult = "multi";


        }
        public class StoredProcedureDepartment
        {
            public const string GetAll = "getalldepartment";
            public const string GetById = "getbyiddepartment";
            public const string Post = "postdepartment";
            public const string Put = "updatedepartment";
            public const string Delete = "deletedepartment";
            public const string TwoResult = "ToResult";
            public const string GetAllMix = "JoinTable";

        }
        public class SQLParameterName
        {
            public const string Id = "@id";
            public const string Name = "@Name";
            public const string Department = "@Department";
            public const string City = "@City";
            public const string Gender = "@Gender";
        }
        public class SQLParameterDepartment
        {
            public const string ID = "@ID";
            public const string HeadOfDepartment = "@HeadOfDepartment";
            public const string departmentname = "@departmentname";
            public const string NumberOfEmployee = "@NumberOfEMployee";

        }
    }
}
