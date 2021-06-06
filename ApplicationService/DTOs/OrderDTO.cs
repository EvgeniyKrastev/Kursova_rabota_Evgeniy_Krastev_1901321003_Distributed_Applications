using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public virtual CarDTO Car { get; set; }
        public int BuyerId { get; set; }
        public virtual BuyerDTO Buyer { get; set; }
        public string AreaOfRegistration { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public double PriceOfPurchase { get; set; }
    }
}
