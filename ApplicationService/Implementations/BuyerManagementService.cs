using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationService.DTOs;
using Data.Context;
using Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationService.Implementations
{
    public class BuyerManagementService
    {
        private CarDealership2SystemDBContext ctx = new CarDealership2SystemDBContext();

        public List<BuyerDTO> Get()
        {
            List<BuyerDTO> BuyersDto = new List<BuyerDTO>();

            foreach (var item in ctx.Buyers.ToList())
            {
                BuyersDto.Add(new BuyerDTO
                {
                    Id = item.Id,
                    FName = item.FName, // Predi be6e Title 
                    LName = item.LName,
                    PhoneNumber = item.PhoneNumber,
                    Email = item.Email,
                    Price = item.Price,
                    Age = item.Age,
                    Sex = item.Sex
                });
            }
            return BuyersDto;

        }
        public BuyerDTO GetById(int id)
        {
            BuyerDTO CarDTO = new BuyerDTO();
            Buyer Buyer = ctx.Buyers.Find(id);
            if (Buyer != null)
            {
                CarDTO.Id = Buyer.Id;
                CarDTO.FName = Buyer.FName;
                CarDTO.LName = Buyer.LName;
                CarDTO.PhoneNumber = Buyer.PhoneNumber;
                CarDTO.Email = Buyer.Email;
                CarDTO.Price = Buyer.Price;
                CarDTO.Age = Buyer.Age;
                CarDTO.Sex = Buyer.Sex;

            }

            return CarDTO;
        }
        public bool Save(BuyerDTO BuyerDTO)
        {
            Buyer Buyers = new Buyer

            {
                Id = BuyerDTO.Id,
                FName = BuyerDTO.FName,  
                LName = BuyerDTO.LName,
                PhoneNumber = BuyerDTO.PhoneNumber,
                Email = BuyerDTO.Email,
                Price = BuyerDTO.Price,
                Age = BuyerDTO.Age,
                Sex = BuyerDTO.Sex
            };

            try
            {
                ctx.Buyers.Add(Buyers);
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
                Buyer Buyer = ctx.Buyers.Find(id);
                ctx.Buyers.Remove(Buyer);
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
