using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Controllers
{
    public class TechnologyController : Controller
    {
        public IActionResult DeepFakes()
        {
            return View();
        }
        public IActionResult UAV()
        {
            return View();
        }
    }
}
