using ApplicationService.DTOs;
using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Implementations
{
    public class CarManagementService
    {
        private CarDealership2SystemDBContext ctx = new CarDealership2SystemDBContext();

        public List<CarDTO> Get()
        {
            List<CarDTO> CarsDto = new List<CarDTO>();

            foreach(var item in ctx.Cars.ToList())
            {
                CarsDto.Add(new CarDTO
                {
                    Id = item.Id,
                    Brand = item.Brand, // Predi be6e Title 
                    Model = item.Model,
                    Year = item.Year,
                    Doors = item.Doors,
                    Price = item.Price,
                    Minfo = item.Minfo                  
                });
            }
            return CarsDto;

        }
        public CarDTO GetById(int id)
        {
            CarDTO CarDTO = new CarDTO();
            Car Car = ctx.Cars.Find(id);
            if (Car != null)
            {
                CarDTO.Id = Car.Id;
                CarDTO.Brand = Car.Brand;
                CarDTO.Model = Car.Model;
                CarDTO.Year = Car.Year;
                CarDTO.Doors = Car.Doors;
                CarDTO.Price = Car.Price;
                CarDTO.Minfo = Car.Minfo;
            }

            return CarDTO;
        }
        public bool Save(CarDTO CarDTO)
        {
            Car Cars = new Car
            
            {
                Brand = CarDTO.Brand, // Predi be6e Title
                Model = CarDTO.Model,
                Year = CarDTO.Year,
                Doors = CarDTO.Doors,
                Price = CarDTO.Price,
                Minfo = CarDTO.Minfo,
            };

            try
            {
                ctx.Cars.Add(Cars);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                Car Car = ctx.Cars.Find(id);
                ctx.Cars.Remove(Car);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
