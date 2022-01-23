using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Data
{
    public class Offer
    {
        public decimal Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
