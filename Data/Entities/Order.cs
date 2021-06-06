using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Order : BaseEntity
    {
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int BuyerId { get; set; }
        public virtual Buyer Buyer { get; set; }
        public string AreaOfRegistration { get; set; }
        [Required]
        public DateTime? DateOfPurchase { get; set; }
        public double PriceOfPurchase { get; set; }     
    }
}
