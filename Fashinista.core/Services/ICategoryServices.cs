using Fashinista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Services
{
   public interface ICategoryServices
    {
        public string Insert_OF_Category(Category category);
        public bool Delete_OF_Category_By_Id(int id);
        public bool Update_OF_Category(Category category);
        public List<Category> GET_All_OF_Category();
        public Category Get_OF_Category_By_Id(int id);
        public Category Get_Category_By_Name(string Name_Category);
    }
}
