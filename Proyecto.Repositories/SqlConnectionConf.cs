using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Repositories
{
    public class SqlConnectionConf
    {
        public string ConnectionString { get; }
        public SqlConnectionConf(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
