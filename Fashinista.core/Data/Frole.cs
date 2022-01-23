using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Data
{
   public class Frole
    {
        public decimal Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
