using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private CarManagementService carManagementService = new CarManagementService();

        private BuyerManagementService buyerManagementService = new BuyerManagementService();

        private OrderManagementService orderManagementService = new OrderManagementService();

        public List<CarDTO> GetCars()
        {
            return carManagementService.Get();    
        }
        public List<BuyerDTO> GetBuyers()
        {
            return buyerManagementService.Get();
        }
        public List<OrderDTO> GetOrders()
        {
            return orderManagementService.Get();
        }

        public string PostCar(CarDTO CarDto)
        {
            if(!carManagementService.Save(CarDto))
            {
                return "Car is Saved!";
                
            }else
            {
                return "Car isn't Saved!";
            }
        }
        public string PostBuyer(BuyerDTO buyerDTOs)
        {
            if (!buyerManagementService.Save(buyerDTOs))
            {
                return "Buyer is not saved!";
            }
            else
            {
                return "Buyer successfully saved!";
            }
        }
        public string PostOrder(OrderDTO orderDTOs)
        {
            if (!orderManagementService.Save(orderDTOs))
            {
                return "Order is not saved!";
            }
            else
            {
                return "Order successfully saved!";
            }
        }

        public string DeleteCar(int id)
        {
            if (!carManagementService.Delete(id))
            {
                return "Car is Deleted!";

            }
            else
            {
                return "Car isn't Deleted!";
            }
        }
        public string DeleteBuyer(int id)
        {
            if (!buyerManagementService.Delete(id))
            {
                return "Buyer is not deleted!";
            }
            else
            {
                return "Buyer successfully deleted!";
            }
        }
        public string DeleteOrder(int id)
        {
            if (!orderManagementService.Delete(id))
            {
                return "Order is not deleted!";
            }
            else
            {
                return "Order successfully deleted!";
            }
        }

        public CarDTO GetCarById(int id)
        {
            return carManagementService.GetById(id);
        }

        public BuyerDTO GetBuyerById(int id)
        {
            return buyerManagementService.GetById(id);
        }
        public OrderDTO GetOrderById(int id)
        {
            return orderManagementService.GetById(id);
        }

    }
}
