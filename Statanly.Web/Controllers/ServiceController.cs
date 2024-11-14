using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Restaurants()
        {
            return View();
        }
        public IActionResult Banks()
        {
            return View();
        }
        public IActionResult Pvz()
        {
            return View();
        }
        public IActionResult Warehouses()
        {
            return View();
        }
        public IActionResult Parking()
        {
            return View();
        }
        public IActionResult Business()
        {
            return View();
        }
        public IActionResult Beauty()
        {
            return View();
        }
        public IActionResult Industry()
        {
            return View();
        }
        public IActionResult Hospitals()
        {
            return View();
        }
        public IActionResult Shops(int? id)
        {

            if (id == 1)
            {
                return View("Shops1");
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
