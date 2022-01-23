using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Data
{
    public class Category
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
