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
    public class ColorController : ControllerBase
    {
        private readonly IColorServices service;
        public ColorController(IColorServices service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("InsertColor")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Color([FromBody]Color color)
        {

            return service.Insert_Color(color);
        }
        [HttpDelete]
        [Route("DeleteColorById/{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Color_By_Id(int id)
        {

            return service.Delete_Color_By_Id(id);
        }
        [HttpPut]
        [Route("UpdateColor")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Color([FromBody] Color color)
        {
            return service.Update_Color(color);

        }

        [HttpGet]
        [Route("GETAllColor")]
        [ProducesResponseType(typeof(List<Color>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Color> GET_All_Color()
        {
            return service.GET_All_Color();

        }
        [HttpGet]
        [Route("GetColorById/{id}")]
        [ProducesResponseType(typeof(Color), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Color Get_Color_By_Id(int id)
        {
            return service.Get_Color_By_Id(id);

        }


    }
}
