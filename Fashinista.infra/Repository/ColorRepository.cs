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
   public class ColorRepository: IColorRepository
    {
        private readonly IdbContext context;
        public ColorRepository(IdbContext context)
        {
            this.context = context;
        }

        public string Insert_Color(Color color) {

            var p = new DynamicParameters();
            p.Add("Color_Of_Product ", color.Color_Product, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Color_Package.insert_Color ", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }
        public bool Delete_Color_By_Id(int id) {

            var p = new DynamicParameters();
            p.Add("Color_ID ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Color_Package.delete_Color", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool Update_Color(Color color) {
            var p = new DynamicParameters();
            p.Add("Color_Of_Product ", color.Color_Product, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Color_Package.update_Color", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Color> GET_All_Color() {


            IEnumerable<Color> result = context.connection.Query<Color>("Color_Package.getall_Color", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public Color Get_Color_By_Id(int id) {

            var p = new DynamicParameters();
            p.Add("Color_ID  ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Color>("Color_Package.get_Color_By_id", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
    }
}
