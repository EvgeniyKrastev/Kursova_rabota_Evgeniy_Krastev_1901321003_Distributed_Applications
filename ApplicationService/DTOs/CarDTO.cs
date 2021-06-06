using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class CarDTO
    {
        // old nationality 
        public int Id { get; set; }
        //  public string Title { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int Doors { get; set; }
        public double Price { get; set; }
        public string Minfo { get; set; }
        
    }
}
