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
    public class OrderManagementService
    {
        private CarDealership2SystemDBContext ctx = new CarDealership2SystemDBContext();

        public List<OrderDTO> Get()
        {
            List<OrderDTO> orderDTO = new List<OrderDTO>();

            foreach (var item in ctx.Orders.ToList())
            {
                orderDTO.Add(new OrderDTO
                {
                    Id = item.Id,
                    CarId = item.CarId,
                    Car = new CarDTO
                    {
                        Id = item.CarId,
                        Brand = item.Car.Brand,
                        Model = item.Car.Model,
                        Year = item.Car.Year,
                        Price = item.Car.Price,
                        Doors = item.Car.Doors,
                        Minfo = item.Car.Minfo
                    },
                    BuyerId = item.BuyerId,
                    Buyer = new BuyerDTO
                    {
                        Id = item.BuyerId,
                        FName = item.Buyer.FName,
                        LName = item.Buyer.LName,
                        Age = item.Buyer.Age,
                        Price = item.Buyer.Price,
                        PhoneNumber = item.Buyer.PhoneNumber,
                        Email = item.Buyer.Email,
                        Sex = item.Buyer.Sex
                    },
                    AreaOfRegistration = item.AreaOfRegistration,
                    DateOfPurchase = item.DateOfPurchase,
                    PriceOfPurchase = item.PriceOfPurchase                    
                });
            }

            return orderDTO;
        }

        public OrderDTO GetById(int id)
        {
            Order item = ctx.Orders.Find(id);

            OrderDTO orderDTO = new OrderDTO
            {
                Id = item.Id,
                CarId = item.CarId,
                Car = new CarDTO
                {
                    Id = item.CarId,
                    Brand = item.Car.Brand,
                    Model = item.Car.Model,
                    Year = item.Car.Year,
                    Minfo = item.Car.Minfo,
                    Doors = item.Car.Doors,
                    Price = item.Car.Price
                },
                BuyerId = item.BuyerId,
                Buyer = new BuyerDTO
                {
                    Id = item.BuyerId,
                    FName = item.Buyer.FName,
                    LName = item.Buyer.LName,
                    Age = item.Buyer.Age,
                    Price = item.Buyer.Price,
                    PhoneNumber = item.Buyer.PhoneNumber,
                    Email = item.Buyer.Email,
                    Sex = item.Buyer.Sex
                },
                AreaOfRegistration = item.AreaOfRegistration,
                DateOfPurchase = item.DateOfPurchase,
                PriceOfPurchase = item.PriceOfPurchase
            };
            return orderDTO;
        }

        public bool Save(OrderDTO orderDTO)
        {
            if (orderDTO.Car == null || orderDTO.CarId == 0)
            {
                return false;
            }

            else if (orderDTO.Buyer == null || orderDTO.BuyerId == 0)
            {
                return false;
            }

            Order Order = new Order
            {
                Id = orderDTO.Id,
                CarId = orderDTO.CarId,
                BuyerId = orderDTO.BuyerId,
                AreaOfRegistration = orderDTO.AreaOfRegistration,
                DateOfPurchase = orderDTO.DateOfPurchase,
                PriceOfPurchase = orderDTO.PriceOfPurchase
            };
            try
            {
                ctx.Orders.Add(Order);
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
                Order Order = ctx.Orders.Find(id);
                ctx.Orders.Remove(Order);
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
