using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fashinista.core.Data
{
   public class Payment
    {
        public decimal Id { get; set; }
        public string VisaNumber { get; set; }
        public string Cvv { get; set; }
        public DateTime ExperdDate { get; set; }
        public decimal Balanc { get; set; }
        public decimal? UserId { get; set; }

        [ForeignKey("UserId")]

        public virtual User User { get; set; }
    }
}
