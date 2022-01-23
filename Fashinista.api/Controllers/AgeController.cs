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
    public class AgeController : ControllerBase
    {
        private readonly IAgeServices service;
        public AgeController(IAgeServices service)
        {
            this.service = service;
        }

        [HttpPost]
        public string Insert_Age([FromBody] Age age)
        {
            return service.Insert_Age(age);
        }
        [HttpPut]
        public bool Update_Age([FromBody] Age age)
        {
            return service.Update_Age(age);
        }

        [HttpGet]
        public List<Age> GET_All_Age()
        {
            return service.GET_All_Age();
        }

       


        [HttpGet("getAgebyid/{id}")]
        public Age Get_Age_By_Id(int id)
        {
            return service.Get_Age_By_Id(id);
        }


        [HttpDelete]
        public bool Delete_Age(int id)
        {
            return service.Delete_Age(id);
        }

        
    }
}
