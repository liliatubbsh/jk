using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fashinista.core.Data
{
   public class Review
    {
        public decimal Id { get; set; }
        public string Comments { get; set; }
        public decimal CustomerId { get; set; }
        public decimal ProductId { get; set; }
        public decimal Status { get; set; }
        public decimal Rating { get; set; }


        [ForeignKey("CustomerId")]
        public virtual User Customer { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
