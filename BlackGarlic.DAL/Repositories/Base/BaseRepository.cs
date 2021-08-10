using ConnectionTool;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Repositories.Base
{
    public class BaseRepository
    {
        internal Connection _connection;
        IConfiguration _config;

        public BaseRepository(IConfiguration config)
        {
            _config = config;
            _connection = new Connection(_config.GetConnectionString("default"));
        }
    }
}
