using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Data
{

    public class Age
    {
        public decimal Id { get; set; }
        public string AgePeriod { get; set; }
        public decimal StartAge { get; set; }
        public decimal EndAge { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
