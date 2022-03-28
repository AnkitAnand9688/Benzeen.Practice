using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzeen.Practice.DataAccess
{
   public class BaseDataAccess
    {
        private readonly IConfiguration _config;
        public BaseDataAccess(IConfiguration config)
        {
            _config = config;
        }
        public string ConnectionString
        {
            get
            {
                return _config.GetConnectionString("ConnectionString");
            }
        }
    }
}
