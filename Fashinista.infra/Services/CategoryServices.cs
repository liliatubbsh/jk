using Fashinista.core.Data;
using Fashinista.core.Repository;
using Fashinista.core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.infra.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryServices(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public bool Delete_OF_Category_By_Id(int id)
        {
            return categoryRepository.Delete_OF_Category_By_Id(id);
        }

        public List<Category> GET_All_OF_Category()
        {
            return categoryRepository.GET_All_OF_Category();
        }

        public Category Get_OF_Category_By_Id(int id)
        {
            return categoryRepository.Get_OF_Category_By_Id(id);
        }

        public Category Get_OF_Category_By_Name(string Name_Category)
        {
            return categoryRepository.Get_OF_Category_By_Name(Name_Category);
        }

        public string Insert_OF_Category(Category category)
        {
            return categoryRepository.Insert_OF_Category(category);
        }

        public bool Update_OF_Category(Category category)
        {
            return categoryRepository.Update_OF_Category(category);
        }
    }
}
