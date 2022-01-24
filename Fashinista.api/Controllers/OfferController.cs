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
    public class OfferController : ControllerBase
    {
        private readonly IOfferServices service;
        public OfferController(IOfferServices service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("Insert_Offer")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Offer([FromBody]Offer offer)
        {
            return service.Insert_Offer(offer);
        }
        [HttpDelete]
        [Route("DeleteOffer/{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Offer_By_Id(int id)
        {
            return service.Delete_Offer_By_Id(id);

        }
        [HttpPut]
        [Route("UpdateOffer")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Offer([FromBody] Offer offer)
        {
            return service.Update_Offer(offer);

        }
        [HttpGet]
        [Route("GETAllOffer")]
        [ProducesResponseType(typeof(List<Offer>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Offer> GET_All_Offer()
        {
            return service.GET_All_Offer();

        }
        [HttpGet]
        [Route("GetOfferById/{id}")]
        [ProducesResponseType(typeof(Offer), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Offer Get_Offer_By_Id(int id)
        {
            return service.Get_Offer_By_Id(id);
        }


    }
}
