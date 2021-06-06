using MVC.SOAPService;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult Index()
        {
            List<OrderVM> ordersVM = new List<OrderVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetOrders())
                {
                    ordersVM.Add(new OrderVM(item));
                }

            }

            return View(ordersVM);

        }

        public ActionResult Details(int id)
        {
            OrderVM orderVM = new OrderVM();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var orderDTO = service.GetOrderById(id);
                orderVM = new OrderVM(orderDTO);
            }

            return View(orderVM);
        }

        public ActionResult Create()
        {
            ViewBag.Cars = Helpers.LoadDataUtilities.LoadCarData();
            ViewBag.Buyers = Helpers.LoadDataUtilities.LoadBuyerData();

            return View();
        }
       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderVM orderVM)
        {
            try
            {
                using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                {
                    OrderDTO orderDTO = new OrderDTO
                    {
                        CarId = orderVM.CarId,
                        Car = new CarDTO
                        {
                            Id = orderVM.CarId
                        },

                        BuyerId = orderVM.BuyerId,
                        Buyer = new BuyerDTO
                        {
                            Id = orderVM.BuyerId
                        },

                        AreaOfRegistration = orderVM.AreaOfRegistration,                  
                        DateOfPurchase = orderVM.DateOfPurchase,
                        PriceOfPurchase = orderVM.PriceOfPurchase
                    };

                    service.PostOrder(orderDTO);

                }

                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Cars = Helpers.LoadDataUtilities.LoadCarData();
                ViewBag.Buyers = Helpers.LoadDataUtilities.LoadBuyerData();

                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteOrder(id);
            }
            return RedirectToAction("Index");
        }
    }
}