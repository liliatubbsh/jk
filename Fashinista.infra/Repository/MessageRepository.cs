using Dapper;
using Fashinista.core.common;
using Fashinista.core.Data;
using Fashinista.core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fashinista.infra.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IdbContext context;
        public MessageRepository(IdbContext context)
        {
            this.context = context;
        }


        public bool Delete_Message(int id)
        {
            var p = new DynamicParameters();
            p.Add("M_ID  ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Massege_Package.Delete_Msg", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Message> GET_All_Message()
        {

            IEnumerable<Message> result = context.connection.Query<Message>("Massege_Package.Get_All_Msg", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Message Get_Message_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("M_ID  ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Message>("Massege_Package.Get_Msg_By_Id", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public string Insert_Message(Message message)
        {
            var p = new DynamicParameters();
            p.Add("M_Cust_Id ", message.Customer_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Msg ", message.Messg, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Reciv", message.Reciver, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("Massege_Package.Insert_Msg ", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool Update_Message(Message message)
        {

            var p = new DynamicParameters();
            p.Add("M_Cust_Id ", message.Customer_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Msg ", message.Messg, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Reciv", message.Reciver, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("Massege_Package.Update_Msg ", p, commandType: CommandType.StoredProcedure);
            return true;

        }
    }
}
