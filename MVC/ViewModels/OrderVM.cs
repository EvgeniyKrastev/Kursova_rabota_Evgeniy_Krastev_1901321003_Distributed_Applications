using MVC.SOAPService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class OrderVM
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        //  public virtual CarDTO Car { get; set; }
        public virtual CarsVM Car { get; set; }

        public int BuyerId { get; set; }
     //   public virtual BuyerDTO Buyer { get; set; }
        public virtual BuyerVM Buyer { get; set; }

        public string AreaOfRegistration { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public double PriceOfPurchase { get; set; }

        public OrderVM() { }

        public OrderVM(OrderDTO orderDTO)
        {
            Id = orderDTO.Id;
            CarId = orderDTO.CarId;
            //   Car = new CarDTO
            Car = new CarsVM
            {
                Id = orderDTO.CarId,
                Brand = orderDTO.Car.Brand,
                Model = orderDTO.Car.Model,
                Price = orderDTO.Car.Price,
                Year = orderDTO.Car.Year,
                Doors = orderDTO.Car.Doors,
                Minfo = orderDTO.Car.Minfo
            };
            BuyerId = orderDTO.BuyerId;
          //  Buyer = new BuyerDTO
            Buyer = new BuyerVM
            {
                Id = orderDTO.BuyerId,
                FName = orderDTO.Buyer.FName,
                LName = orderDTO.Buyer.LName,
                Age = orderDTO.Buyer.Age,
                Price = orderDTO.Buyer.Price,
                PhoneNumber = orderDTO.Buyer.PhoneNumber,
                Email = orderDTO.Buyer.Email,
                Sex = orderDTO.Buyer.Sex
            };
            AreaOfRegistration = orderDTO.AreaOfRegistration;
            DateOfPurchase = orderDTO.DateOfPurchase;
            PriceOfPurchase = orderDTO.PriceOfPurchase;
        }
    }
}