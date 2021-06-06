using MVC.SOAPService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class CarsVM
    {
        public int Id { get; set; }
        //  public string Title { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int Doors { get; set; }
        public double Price { get; set; }
        public string Minfo { get; set; }

        public CarsVM() { }

        public CarsVM(CarDTO CarDTO)
        {
            Id = CarDTO.Id;
            Brand = CarDTO.Brand;
            Model = CarDTO.Model;
            Year = CarDTO.Year;
            Doors = CarDTO.Doors;
            Price = CarDTO.Price;
            Minfo = CarDTO.Minfo;
        }
    }
}