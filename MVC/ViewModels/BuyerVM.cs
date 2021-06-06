using MVC.SOAPService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class BuyerVM
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public double Price { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }

        public BuyerVM() { }

        public BuyerVM(BuyerDTO buyerDTO)
        {
            Id = buyerDTO.Id;
            FName = buyerDTO.FName;
            LName = buyerDTO.LName;
            Age = buyerDTO.Age;
            Price = buyerDTO.Price;
            PhoneNumber = buyerDTO.PhoneNumber;
            Email = buyerDTO.Email;
            Sex = buyerDTO.Sex;
        }
    }
}