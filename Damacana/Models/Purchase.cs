using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Damacana.Models
{
    public class Purchase
    {   public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOn { get; set; } = new DateTime(2015, 12, 02);
        public decimal TotalPrice { get; set; } = 0;
        public virtual ICollection<Product> Products { get; set; }

    }
}