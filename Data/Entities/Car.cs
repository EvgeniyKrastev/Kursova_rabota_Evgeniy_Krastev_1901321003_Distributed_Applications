using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Car : BaseEntity
    {
        // old nationality
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int Doors { get; set; }
        public double Price { get; set; }
        public string Minfo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
