using Fashinista.core.Data;
using Fashinista.core.DTO;
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
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialServices service;
        public TestimonialController(ITestimonialServices service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("InsertTestimonial")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Testimonial([FromBody] Testimonial testimonial)
        {

            return service.Insert_Testimonial(testimonial);
        }
        [HttpDelete]
        [Route("DeleteTestimonial/{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Testimonial_By_Id(int id)
        {
            return service.Delete_Testimonial_By_Id(id);

        }
        [HttpPut]
        [Route("UpdateTestimonial")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Testimonial([FromBody] Testimonial testimonial)
        {
            return service.Update_Testimonial(testimonial);

        }
        [HttpGet]
        [Route("GETAllTestimonialAdmin")]
        [ProducesResponseType(typeof(List<Testimonial_Dto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Testimonial_Dto> GET_All_Testimonial_Admin()
        {
            return service.GET_All_Testimonial_Admin();
        }
        [HttpGet]
        [Route("GETAllTestimonialUser")]
        [ProducesResponseType(typeof(List<Testimonial_Dto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Testimonial_Dto> GET_All_Testimonial__User()
        {
            return service.GET_All_Testimonial__User();

        }
        [HttpGet]
        [Route("GetTestimonialById/{id}")]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Testimonial Get_Testimonial_By_Id(int id)
        {
            return service.Get_Testimonial_By_Id(id);

        }

    }
}
