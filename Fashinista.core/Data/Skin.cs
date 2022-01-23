using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Data
{
   public class Skin
    {

        public decimal Id { get; set; }
        public string ColorSkin { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
