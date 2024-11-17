using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Restaurants(int? id)
        {
            if (id == 1)
            {
                return View("Restaurants1");
            }
            if (id == 2)
            {
                return View("Restaurants2");
            }
            if (id == 4)
            {
                return View("Restaurants4");
            }
            if (id == 5)
            {
                return View("Restaurants5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Banks(int? id)
        {

            if (id == 1)
            {
                return View("Banks1");
            }
            if (id == 2)
            {
                return View("Banks2");
            }
            if (id == 4)
            {
                return View("Banks4");
            }
            if (id == 5)
            {
                return View("Banks5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Pvz(int? id)
        {

            if (id == 1)
            {
                return View("Pvz1");
            }
            if (id == 2)
            {
                return View("Pvz2");
            }
            if (id == 4)
            {
                return View("Pvz4");
            }
            if (id == 5)
            {
                return View("Pvz5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Warehouses(int? id)
        {

            if (id == 1)
            {
                return View("Warehouses1");
            }
            if (id == 2)
            {
                return View("Warehouses2");
            }
            if (id == 4)
            {
                return View("Warehouses4");
            }
            if (id == 5)
            {
                return View("Warehouses5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Parking(int? id)
        {
            if (id == 1)
            {
                return View("Parking1");
            }
            if (id == 4)
            {
                return View("Parking4");
            }
            if (id == 5)
            {
                return View("Parking5");
            }
            if (id == 6)
            {
                return View("Parking6");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Business(int? id)
        {

            if (id == 1)
            {
                return View("Business1");
            }
            if (id == 2)
            {
                return View("Business2");
            }
            if (id == 4)
            {
                return View("Business4");
            }
            if (id == 5)
            {
                return View("Business5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Beauty(int? id)
        {

            if (id == 1)
            {
                return View("Beauty1");
            }
            if (id == 2)
            {
                return View("Beauty2");
            }
            if (id == 4)
            {
                return View("Beauty4");
            }
            if (id == 5)
            {
                return View("Beauty5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Industry()
        {
            return View();
        }
        public IActionResult Hospitals()
        {
            return View();
        }
        
        public IActionResult Unique()
        {
            return View();
        }
        public IActionResult Shops(int? id)
        {

            if (id == 1)
            {
                return View("Shops1");
            }
            if (id == 2)
            {
                return View("Shops2");
            }
            if (id == 4)
            {
                return View("Shops4");
            }
            if (id == 5)
            {
                return View("Shops5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Housing(int? id)
        {

            if (id == 1)
            {
                return View("Housing1");
            }
            if (id == 3)
            {
                return View("Housing3");
            }
            if (id == 4)
            {
                return View("Housing4");
            }
            if (id == 5)
            {
                return View("Housing5");
            }
            else
            {
                return View();
            }
        }
    }
}
