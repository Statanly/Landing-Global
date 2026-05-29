using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Safety()
        {
            return View();
        }
        public IActionResult Effectiveness()
        {
            return View();
        }
        public IActionResult Automation()
        {
            return View();
        }
        public IActionResult Quality()
        {
            return View();
        }
    }
}
