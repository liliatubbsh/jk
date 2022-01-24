using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fashinista.core.Data
{
    public class Product
    {
        
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public decimal? OfferId { get; set; }
        public decimal CategoryId { get; set; }
        public DateTime Dateofadd { get; set; }


        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("OfferId")]
        public virtual Offer Offer { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }


    }
}
