using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Fashinista.core.common;
using System.Data.Common;
using System.Text;


namespace Fashinista.infra.common
{
    public class dbContext : IdbContext
    {
        private DbConnection _connection;  // function oracle
        private readonly IConfiguration configuration; //to get connection string;
        public dbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DbConnection connection
        {
            get
            {

                //case 1 
                if (_connection == null)
                {
                    // to get connection string from appsettings.json please sure  about words include in appesttings.json 
                    //it must be same in appesttings.json 
                    _connection = new OracleConnection(configuration[("ConnectionStrings:DBConnectionString")]);
                    _connection.Open();
                }
                //case 2 
                else if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }
    }
}
