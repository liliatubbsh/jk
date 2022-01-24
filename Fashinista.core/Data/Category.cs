using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fashinista.core.Data
{
    public class Category
    {
        [Key]
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string IMAGE_PATH { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
