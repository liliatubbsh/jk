using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fashinista.core.Data
{
  public  class Property
    {

        public decimal Id { get; set; }
        public decimal Quantite { get; set; }
        public decimal ColorId { get; set; }
        public decimal SizeId { get; set; }
        public decimal ProductId { get; set; }
        public decimal SkinId { get; set; }
        public decimal AgeId { get; set; }

        [ForeignKey("AgeId")]
        public virtual Age Age { get; set; }
        [ForeignKey("ColorId")]
        public virtual Color Color { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("SizeId")]
        public virtual StandaredSize Size { get; set; }
        [ForeignKey("SkinId")]
        public virtual Skin Skin { get; set; }
        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}
