using Fashinista.core.Data;
using Fashinista.core.Repository;
using Fashinista.core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.infra.Services
{
    public class MessageServices : IMessageServices
    {
        private readonly IMessageRepository messageRepository;
        public MessageServices(IMessageRepository messageRepository)
        {
            this.messageRepository = messageRepository;
        }
        public bool Delete_Message(int id)
        {
            return messageRepository.Delete_Message(id);
        }

        public List<Message> GET_All_Message()
        {
            return messageRepository.GET_All_Message();
        }

        public Message Get_Message_By_Id(int id)
        {
            return messageRepository.Get_Message_By_Id(id);
        }

        public string Insert_Message(Message message)
        {
            return messageRepository.Insert_Message(message);
        }

        public bool Update_Message(Message message)
        {
            return messageRepository.Update_Message(message);
        }
    }
}
