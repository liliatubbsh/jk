using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fashinista.core.Data
{
 public   class UserOrder
    {
        public decimal Id { get; set; }
        public decimal OrderId { get; set; }
        public decimal CustId { get; set; }
        public decimal ProId { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Price { get; set; }

        [ForeignKey("CustId")]
        public virtual User Cust { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProId")]
        public virtual Property Pro { get; set; }
    }

}
