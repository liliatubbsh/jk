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
    public class MessageController : ControllerBase
    {

        private readonly IMessageServices service;
        public MessageController(IMessageServices service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("Insert_Message")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Message([FromBody] Message message)
        {
            return service.Insert_Message(message);
        }
        [HttpDelete]
        [Route("DeleteMessage/{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Message(int id)
        {

            return service.Delete_Message(id);
        }

        [HttpPut]
        [Route("UpdateMessage")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Message([FromBody] Message message)
        {

            return service.Update_Message(message);
        }
        [HttpGet]
        [Route("GETAllMessage")]
        [ProducesResponseType(typeof(List<Message>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Message> GET_All_Message()
        {
            return service.GET_All_Message();
        }

        [HttpGet]
        [Route("GetMessageById/{id}")]
        [ProducesResponseType(typeof(Message), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Message Get_Message_By_Id(int id)
        {
            return service.Get_Message_By_Id(id);
        }


    }
}
