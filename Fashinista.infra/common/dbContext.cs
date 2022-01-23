using Fashinista.core.common;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Fashinista.infra.common
{
    public class dbContext : IdbContext
    {
        private DbConnection _connection;
        private readonly IConfiguration configuration;
        public dbContext(IConfiguration configuration)
        {
            this.configuration = configuration;

        }
        public DbConnection connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new OracleConnection(configuration[("ConnectionStrings:DefaultConnection")]);
                }
                else if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }

                return _connection;
            }
        }
    }
}
