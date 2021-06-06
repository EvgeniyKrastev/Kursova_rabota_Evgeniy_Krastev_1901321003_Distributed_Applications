using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class BuyerDTO
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public double Price { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
    }
}
