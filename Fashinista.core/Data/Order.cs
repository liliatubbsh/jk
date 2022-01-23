using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fashinista.core.Data
{
    public class Order
    {
        public decimal Id { get; set; }
        public DateTime Dateoforder { get; set; }
        public decimal? Status { get; set; }
        public decimal? DeliveryId { get; set; }


        [ForeignKey("DeliveryId")]
        public virtual Delivery Delivery { get; set; }
        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}
