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
using Statanly.Web.Models;

namespace Statanly.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Company()
        {
            return View();
        }
        public IActionResult About()
        {
            return RedirectToAction("Company");
        }
        public IActionResult Solution()
        {
            return View();
        }
        public IActionResult Research()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Mission()
        {
            return View();
        }
        public IActionResult Cooperation()
        {
            return View();
        }
        public IActionResult Press()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        
        public FileResult Reference(int id = 1)
        {
            return File("~/Content/" + "Ref " + id + ".pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        public FileResult Download(string lang = "RU")
        {
            return File("~/Content/" + lang + ".pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult News()
        {
            return View();
        }
        public string GetCulture(string code = "")
        {
            if (!String.IsNullOrEmpty(code))
            {
                CultureInfo.CurrentCulture = new CultureInfo(code);
                CultureInfo.CurrentUICulture = new CultureInfo(code);
            }
            return $"CurrentCulture:{CultureInfo.CurrentCulture.Name}, CurrentUICulture:{CultureInfo.CurrentUICulture.Name}";
        }

        public IActionResult ML()
        {
            return View();
        }
        public IActionResult CV()
        {
            return View();
        }
        public IActionResult NLP()
        {
            return View();
        }
        public IActionResult DA()
        {
            return View();
        }
        public IActionResult Case(int id = 1)
        {
            if (id < 1 || id > 9)
            {
                id = 1;
            }
            return View("Case" + id);
        }
        public IActionResult Service(int id = 1)
        {
            if (id < 1 || id > 6)
            {
                id = 1;
            }
            return View("Services" + id);
        }
        public IActionResult Product(int id = 1)
        {
            if (id < 1 || id > 10)
            {
                id = 1;
            }
            return View("Product" + id);
        }
        public IActionResult Tpu()
        {
           return View();
        }
        public IActionResult Smartcity(int id = 0)
        {
            if (id == 0)
            {
                return View("Smartcity");
            }
            if (id < 0 || id > 6)
            {
                id = 1;
            }          
            return View("Smartcity" + id);
        }
        public IActionResult SetLanguage(string culture, string returnUrl = "/")
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            //this.GetCulture("en-US"); 
            //var c = $"CurrentCulture:{CultureInfo.CurrentCulture.Name}, CurrentUICulture:{CultureInfo.CurrentUICulture.Name}";
            if (returnUrl.ToLowerInvariant() == "/message/subscribe" || returnUrl.ToLowerInvariant() == "/message/error")
            {
                returnUrl = "/";
            }
            return LocalRedirect(returnUrl);
        }
    }
}
