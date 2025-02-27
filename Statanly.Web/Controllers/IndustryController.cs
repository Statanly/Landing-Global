using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Statanly.Web.Controllers
{
    public class IndustryController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект для бизнеса";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных для различных сфер бизнеса";
            return View();
        }
 
        public IActionResult Agro(string id)
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект для агропромышленности и сельского хозяйства";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных для агропромышленности и сельского хозяйства";
            if (id == "livestock")
            {
                return View("Agro1"); //Pigs
            }
            if (id == "poultry")
            {
                return View("Agro2");//chickens
            }
            if (id == "crops")
            {
                return View("Agro3");//crops
            }
            if (id == "fishery")
            {
                return View("Agro4");//fish
            }
            else
            {
                return View();
            }
        }
        public IActionResult Pigs()
        {     
            return View();           
        }
        public IActionResult Cows()
        {
            return View();
        }
        public IActionResult Development(string id)
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект для строительства и девелопмента";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных для строительства и девелопмента";
            if (id == "monitoring")
            {
                return View("Development2");//fish
            }
            return View();
        }
        public IActionResult Horeca()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект для кафе, ресторанов и отелей";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных для кафе, ресторанов и отелей";
            return View();
        }
        public IActionResult Insurance()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект в страховой сфере";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных в страховой сфере";
            return View();
        }
        public IActionResult Printing()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект для типографий";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных для типографий";
            return View();
        }
        public IActionResult Logistics()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект в сфере логистики";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных в сфере логистики";
            return View();
        }
        public IActionResult Medicine()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект в медицине";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных в медицине";
            return View();
        }
        public IActionResult Media()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект для медиа и рекламной сферы";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных для медиа и рекламной сферы";
            return View();
        }
        public IActionResult Prom()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект для промышленности";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных для промышленности";
            return View();
        }
        public IActionResult Transport()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект для транспорта";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных для транспорта";
            return View();
        }
        public IActionResult Retail()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект в ретейле и продажах";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных в ретейле и продажах";
            return View();
        }
        public IActionResult Food()
        {
            ViewData["Title"] = "Statanly Technologies - искусственный интеллект для пишевой промышленности";
            ViewData["Description"] = "Решения на базе технологий искусственного интеллекта, машинного обучения, компьютерного зрения, обработки естественных языков и анализа данных для пишевой промышленности";

            return View();
        }
    }
}
