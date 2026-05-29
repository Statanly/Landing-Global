using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Beauty()
        {
            return View();
        }
        public IActionResult Industry(int? id)
        {

            if (id == 1)
            {
                return View("Industry1");
            }
            if (id == 2)
            {
                return View("Industry2");
            }
            if (id == 4)
            {
                return View("Industry4");
            }
            if (id == 5)
            {
                return View("Industry5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Hospitals(int? id)
        {

            if (id == 1)
            {
                return View("Hospitals1");
            }
            if (id == 2)
            {
                return View("Hospitals2");
            }
            if (id == 4)
            {
                return View("Hospitals4");
            }
            if (id == 5)
            {
                return View("Hospitals5");
            }
            else
            {
                return View();
            }
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
        public IActionResult Gasstation(int? id)
        {

            if (id == 1)
            {
                return View("Gasstation1");
            }
            if (id == 2)
            {
                return View("Gasstation2");
            }
            if (id == 4)
            {
                return View("Gasstation4");
            }
            if (id == 5)
            {
                return View("Gasstation5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Institutions(int? id)
        {

            if (id == 1)
            {
                return View("Institutions1");
            }
            if (id == 2)
            {
                return View("Institutions2");
            }
            if (id == 4)
            {
                return View("Institutions4");
            }
            if (id == 5)
            {
                return View("Institutions5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Sports(int? id)
        {

            if (id == 1)
            {
                return View("Sports1");
            }
            if (id == 2)
            {
                return View("Sports2");
            }
            if (id == 4)
            {
                return View("Sports4");
            }
            if (id == 5)
            {
                return View("Sports5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Transport(int? id)
        {

            if (id == 1)
            {
                return View("Transport1");
            }
            if (id == 2)
            {
                return View("Transport2");
            }
            if (id == 4)
            {
                return View("Transport4");
            }
            if (id == 5)
            {
                return View("Transport5");
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
        public IActionResult Railwaystation(int? id)
        {

            if (id == 1)
            {
                return View("Railwaystation1");
            }
            if (id == 2)
            {
                return View("Railwaystation2");
            }
            if (id == 4)
            {
                return View("Railwaystation4");
            }
            if (id == 5)
            {
                return View("Railwaystation5");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Unique()
        {
            return View();
        }
        public IActionResult Monitoring()
        {
            return View();
        }
        public IActionResult Hospitality()
        {
            return View();
        }
        public IActionResult Retail()
        {
            return View();
        }
        public IActionResult Warehouses()
        {
            return View();
        }
        public IActionResult Malls()
        {
            return View();
        }
    }
}
