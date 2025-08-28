using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Granulometry()
        {
            return View();
        }
    }
}
