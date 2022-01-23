using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fashinista.core.Data
{
   public class Testimonial
    {
        public decimal Id { get; set; }
        public string Texet { get; set; }
        public decimal CustomerId { get; set; }
        public decimal Status { get; set; }

        [ForeignKey("CustomerId")]
        public virtual User Customer { get; set; }
    }
}
