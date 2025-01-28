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
            return File("~/Content/Accreditation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
    }
}
