using Fashinista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Services
{
   public interface IMessageServices
    {
        public string Insert_Message(Message message);
        public bool Delete_Message(int id);
        public bool Update_Message(Message message);

        public List<Message> GET_All_Message();


        public Message Get_Message_By_Id(int id);

    }
}
