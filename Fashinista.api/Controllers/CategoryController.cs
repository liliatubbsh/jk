using Fashinista.core.Data;
using Fashinista.core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fashinista.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices service;
        public CategoryController(ICategoryServices service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("InsertCategory")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_OF_Category([FromBody] Category category) {

            return service.Insert_OF_Category(category);
        }

        [HttpDelete]
        [Route("DeleteCategoryById/{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_OF_Category_By_Id(int id) {
            return service.Delete_OF_Category_By_Id(id);
        }

        [HttpPut]
        [Route("UpdateCategory")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_OF_Category([FromBody] Category category) {

            return service.Update_OF_Category(category);
        }

        [HttpGet]
        [Route("GETAllCategory")]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Category> GET_All_OF_Category() {
            return service.GET_All_OF_Category();
        }

        [HttpGet]
        [Route("GetCategoryById/{id}")]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Category Get_OF_Category_By_Id(int id) {
            return service.Get_OF_Category_By_Id(id);

        }

        [HttpGet]
        [Route("GetCategoryByName/{Name_Category}")]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Category Get_OF_Category_By_Name(string Name_Category) {

         return service.Get_OF_Category_By_Name(Name_Category);

                 }
    }
}
