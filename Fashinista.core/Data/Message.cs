using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fashinista.core.Data
{
   public class Message
    {
        public decimal Id { get; set; }
        public decimal CustomerId { get; set; }
        public string Messg { get; set; }
        public string Reciver { get; set; }

        [ForeignKey("CustomerId")]

        public virtual User Customer { get; set; }
    }
}
