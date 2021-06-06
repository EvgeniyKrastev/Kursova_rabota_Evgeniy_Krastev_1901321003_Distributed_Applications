using MVC.SOAPService;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CarsController : Controller
    {
        
        public ActionResult Index()
        {
            List<CarsVM> CarsVM = new List<CarsVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetCars())
                {
                    CarsVM.Add(new CarsVM(item));
                }

            }

            return View(CarsVM);
        }

        [HttpPost]
        public ActionResult Create(CarsVM carsVM)
        {
            try
            {
                using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                {
                    if (ModelState.IsValid)
                    {
                        CarDTO carDTO = new CarDTO
                        {
                            Brand = carsVM.Brand,
                            Model = carsVM.Model,
                            Year = carsVM.Year,
                            Price = carsVM.Price,
                            Doors = carsVM.Doors,
                            Minfo = carsVM.Minfo

                        };
                        service.PostCar(carDTO);

                        return RedirectToAction("Index");
                    }

                    return View();

                }
            }

            catch
            {
                return View();
            }
        }

        public ActionResult Create() { return View(); }

        
        
        




        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteCar(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            CarsVM carVM = new CarsVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                carVM = new CarsVM(service.GetCarById(id));
            }
            return View(carVM);
        }
    }
}