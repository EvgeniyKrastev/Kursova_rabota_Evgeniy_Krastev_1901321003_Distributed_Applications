using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class CarDealership2SystemDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; } // tablica koqto sudurja danni nacionalnosti ili drugo staroto Dealership i dealerships

        public DbSet<Buyer> Buyers { get; set; } // baza danni za buyers

        public DbSet<Order> Orders { get; set; } // baza danni za poru4ki

    }
}
