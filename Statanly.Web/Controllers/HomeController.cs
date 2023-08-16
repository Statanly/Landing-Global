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
        public FileResult Download(string lang = "RU")
        {
            return File("~/Content/" + lang + ".pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
        public IActionResult Case(int n = 1)
        {
            if (n < 1 || n > 9)
            {
                n = 1;
            }
            return View("Case" + n);
        }
        public IActionResult Service(int n=1)
        {
            if (n < 1 || n > 6)
            {
                n = 1;
            }
            return View("Services" + n);
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
        public IActionResult Smartcity(int n = 0)
        {
            if (n == 0)
            {
                return View("Smartcity");
            }
            if (n < 0 || n > 6)
            {
                n = 1;
            }          
            return View("Smartcity" + n);
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
