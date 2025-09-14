using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Reestr()
        {
            return View();
        }
        public IActionResult Company()
        {
            return View();
        }
        public IActionResult CVFlow()
        {
            return View();
        }
        public FileResult Download()
        {
            return File("~/Content/Documentation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        public FileResult Installation()
        {
            return File("~/Content/Installation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        public FileResult Code()
        {
            return File("~/Content/cvflow.zip", System.Net.Mime.MediaTypeNames.Application.Zip);
        }
        public FileResult Accreditation()
        {
            return File("~/Content/Accreditation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        public IActionResult Weight()
        {
            return Redirect("https://disk.yandex.ru/d/n4ZydwYeeJwiHA");
        }
        public FileResult Ustav()
        {
            return File("~/Content/Ustav.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        public FileResult Brandbook()
        {
            return File("~/Content/Brandbook.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        public FileResult Product7(int id)
        {
            if (id == 1)
            {
                return File("~/Content/Product7_Installation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
            }
            if (id == 2)
            {
                return File("~/Content/Product7_Documentation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);

            }
            if (id == 3)
            {
                return File("~/Content/Product7_Instruct.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);

            }
            if (id == 4)
            {
                return File("~/Content/Product7_Architecture.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);

            }
            return File("~/Content/Accreditation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }

        public FileResult Granulometry(int id)
        {
            if (id == 1)
            {
                return File("~/Content/Granulometry_Documentation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
            }
            if (id == 2)
            {
                return File("~/Content/Granulometry_Instruct.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);

            }
            if (id == 3)
            {
                return File("~/Content/Granulometry_Installation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);

            }
            if (id == 4)
            {
                return File("~/Content/Granulometry_Architecture.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);

            }
            return File("~/Content/Accreditation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }

        //Rostelecom
        public FileResult Report()
        {
            return File("~/Content/Report.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        public FileResult Agro()
        {
            return File("~/Content/Agro Presentation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        public FileResult SafetyPlatform()
        {
            ViewData["Title"] = "Statanly Technologies - Система охраны труда, промышленной безопасности и контроля нарушений";
            ViewData["Description"] = "Универсальная платформа охраны труда, промышленной безопасности и контроля нарушений на базе технологий компьютерного зрения и речевой аналитики";
            return File("~/Content/Safety_Platform.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
    }
}
