using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Statanly.Web.Data;
using Statanly.Web.Infrastructure.IRepositories;
using Statanly.Web.Models;

namespace Statanly.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IClickRepository clickRepository;
        public HomeController(ILogger<HomeController> logger, IClickRepository clickRepository)
        {
            _logger = logger;
            this.clickRepository = clickRepository;
        }

        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Platform()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
