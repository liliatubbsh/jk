using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fashinista.core.Data
{
   public class Delivery
    {
        public decimal Id { get; set; }
        public decimal DeliveryId { get; set; }
        public string Xlit { get; set; }
        public string Ylit { get; set; }

        [ForeignKey("DeliveryId")]
        public virtual User DeliveryNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
