using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _200393445.Models;

namespace _200393445.Controllers
{
    public class CarsController : Controller
    {
        List<Car> carList = new List<Car>()
        {
         new Car {Id = 1, Brand = "Toyota", Model = "Compact", Year = 2017},
         new Car {Id = 2, Brand = "Ford", Model = "F-150", Year = 2018 },
         new Car {Id = 3, Brand = "Dodge", Model = "Caravan", Year = 2019},
         new Car {Id = 4, Brand = "Hyundai", Model = "Sonata", Year = 2020}
        };
        // GET: Cars
        public ActionResult Index()
        {
            return View(carList);
        }

        // GET: Cars/Details - Single Car
        public ActionResult Details(int? id)
        {
            if(id ==null || id > carList.Count)
            {
                return Content("Invalid car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }
    }
}