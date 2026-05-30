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

        public async Task<IActionResult> Index(string id)
        {
            if (!String.IsNullOrWhiteSpace(id))
            {
                var click = new Click() { Date = DateTime.Now, Guid = id };
                await this.clickRepository.Add(click);
            }
            
            return View();
        }
        public IActionResult Company()
        {
            ViewData["Title"] = "Statanly Technologies - решения на базе искусственного интеллекта";
            ViewData["Description"] = "О компании";
            return View();
        }
        public IActionResult About()
        {
            ViewData["Title"] = "Statanly Technologies - решения на базе искусственного интеллекта";
            ViewData["Description"] = "О компании";
            return RedirectToAction("Company");
        }
        public IActionResult Solution()
        {
            ViewData["Title"] = "Statanly Technologies - решения на базе искусственного интеллекта";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных";
            return View();
        }
        public IActionResult Research()
        {
            ViewData["Title"] = "Statanly Technologies - наука и технологии";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Title"] = "Statanly Technologies - наши контакты";
            return View();
        }
        public IActionResult Team()
        {
            ViewData["Title"] = "Statanly Technologies - наша команда";
            return View();
        }
        public IActionResult Mission()
        {
            ViewData["Title"] = "Statanly Technologies - наша миссия";
            return View();
        }
        public IActionResult Platform()
        {
            return View();
        }
        public IActionResult Logo()
        {
            return View();
        }
        public IActionResult Trademark()
        {
            return View();
        }
        public IActionResult Cooperation()
        {
            ViewData["Title"] = "Statanly Technologies - сотрудничество";
            return View();
        }
        public IActionResult Press()
        {
            ViewData["Title"] = "Statanly Technologies - публикации";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Conveyers()
        {
            ViewData["Title"] = "Statanly Technologies - Автоматизация конвейеров и производственных линий на базе искусственного интеллекта";
            ViewData["Description"] = "Контроль и оптимизация конвейерных процессов и производственной линии, снижение зависимости от человека и ручного труда";
            return View();
        }
        public IActionResult Mobile()
        {
            ViewData["Title"] = "Statanly Technologies - Портативный программно-аппаратный комплекс для анализа однородных, сгруппированных объектов";
            ViewData["Description"] = "Портативный программно-аппаратный комплекс для анализа гранулометрического состава (анализ размера и поиск негарабарита) руды, размера, формы, цветности, скорости пузырьков флотации, влажности окатышей руды, подсчета и классификации объектов, распознавание дефектов";
            return View();
        }
        public IActionResult Manufacturing()
        {
            ViewData["Title"] = "Statanly Technologies - Автоматизация производственных и промышленных предприятий на базе искусственного интеллекта";
            ViewData["Description"] = "Контроль и оптимизация конвейерных процессов и производственной линии, снижение зависимости от человека и ручного труда";
            return View();
        }
        public IActionResult Services()
        {
            ViewData["Title"] = "Statanly Technologies - сервисы на базе искусственного интеллекта";
            ViewData["Description"] = "Системы и сервисы на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных";
            return View();
        }
        public IActionResult Products()
        {
            ViewData["Title"] = "Statanly Technologies - продукты на базе искусственного интеллекта";
            ViewData["Description"] = "Системы и сервисы на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных";
            return View();
        }

        public FileResult Reference(int id = 1)
        {
            return File("~/Content/" + "Ref " + id + ".pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        public FileResult Presentation(int id = 1)
        {
            return File("~/Content/" + "Presentation " + id + ".pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
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
        public IActionResult Contacts()
        {
            return View();
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
            ViewData["Title"] = "Statanly Technologies - большие языковые моделей и речевая аналитика";
            ViewData["Description"] = "Сервисы на базе больших языковых моделей (LLM) и речевая аналитика";
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
            ViewData["Title"] = "Statanly Technologies - сервисы на базе искусственного интеллекта";
            ViewData["Description"] = "Системы и сервисы на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных";

            if (id < 1 || id > 6)
            {
                id = 1;
            }
            if (id == 6)
            {
                ViewData["Title"] = "Statanly Technologies - тензорные процессоры";
                ViewData["Description"] = "Адаптация алгоритмов искусственного интеллекта под тензорные процессоры, одноплатники типа Jetson Nano, Raspberry Pi";
            }
            return View("Services" + id);
        }
        public IActionResult Product(int id = 1)
        {
            ViewData["Title"] = "Statanly Technologies - продукты на базе искусственного интеллекта";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных";

            if (id < 1 || id > 13)
            {
                id = 1;
            }
            if (id == 8)
            { 
                id = 3;
            }
            if (id == 7)
            {
                ViewData["Title"] = "Statanly Technologies - Система охраны труда, промышленной безопасности и контроля нарушений";
                ViewData["Description"] = "Универсальная платформа охраны труда, промышленной безопасности и контроля нарушений на базе технологий компьютерного зрения и речевой аналитики";
            }
            return View("Product" + id);
        }        
        public IActionResult Singleboard()
        {
            ViewData["Title"] = "Statanly Technologies - одноплатники и микрокомпьютеры";
            ViewData["Description"] = "Адаптация алгоритмов искусственного интеллекта под тензорные процессоры, одноплатники типа Jetson Nano, Raspberry Pi";
            return View();
        }
        public IActionResult Tpu()
        {
            ViewData["Title"] = "Statanly Technologies - тензорные процессоры";
            ViewData["Description"] = "Адаптация алгоритмов искусственного интеллекта под тензорные процессоры, одноплатники типа Jetson Nano, Raspberry Pi";

            return View();
        }
        public IActionResult Smartcity(int id = 0)
        {
            ViewData["Title"] = "Statanly Technologies - умный и безопасный город";
            ViewData["Description"] = "Интеллектуальная система анализа городской среды";

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
        public IActionResult News()
        {
            ViewData["Title"] = "Statanly Technologies - новости компании";
            ViewData["Description"] = "Новости, анонсы, мероприятия компании";
            return View();
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
