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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IdbContext context;
        public CategoryRepository(IdbContext context)
        {
            this.context = context;
        }
        public bool Delete_OF_Category_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Category", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Category_Package.Delete_Category_By_Id", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Category> GET_All_OF_Category()
        {
            IEnumerable<Category> result = context.connection.Query<Category>("Category_Package.GET_All_Category", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Category Get_OF_Category_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Category", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Category>("Category_Package.Get_Category_By_Id", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();

        }

        public Category Get_OF_Category_By_Name(string Name_Category)
        {
            var p = new DynamicParameters();
            p.Add("Name_OF_Category  ", Name_Category, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Category>("Category_Package.Get_Category_By_Name", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public string Insert_OF_Category(Category category)
        {
            var p = new DynamicParameters();
            p.Add("Name_OF_Category", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Image", category.IMAGE_PATH, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Category_Package.Insert_Category", p, commandType: CommandType.StoredProcedure);
            return "valid";

        }
        public bool Update_OF_Category(Category category)
        {
            var p = new DynamicParameters();
            p.Add("Name_OF_Category", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Image", category.IMAGE_PATH, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Category_Package.Update_Category", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
