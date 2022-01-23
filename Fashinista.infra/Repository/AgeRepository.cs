using Dapper;
using Fashinista.core.common;
using Fashinista.core.Data;
using Fashinista.core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fashinista.infra.Repository
{
   public class AgeRepository : IAgeRepository
    {
        private readonly IdbContext context;
        public AgeRepository(IdbContext context)
        {
            this.context = context;
        }
        public bool Delete_Age(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID_Age", p, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Age_Package.Delete_Age", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public Age Get_Age_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID_Age", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Age>("Age_Package.Get_Age_By_Id", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public List<Age> GET_All_Age()
        {
            IEnumerable<Age> result = context.connection.Query<Age>("Age_Package.GET_All_Age", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string Insert_Age(Age age)
        {
            var p = new DynamicParameters();
            
            p.Add("Age_Group ", age.AgePeriod, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("StartAge", age.StartAge, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("EndAge", age.EndAge, dbType: DbType.Date, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Age_Package.Insert_Age", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool Update_Age(Age age)
        {
            var p = new DynamicParameters();

            p.Add("Age_Group ", age.AgePeriod, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("StartAge", age.StartAge, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("EndAge", age.EndAge, dbType: DbType.Date, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Age_Package.Insert_Age", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
