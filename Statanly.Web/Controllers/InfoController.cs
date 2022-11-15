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
        public FileResult Documentation()
        {
            return File("~/Content/Documentation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
        public FileResult Code()
        {
            return File("~/Content/cvflow.zip", System.Net.Mime.MediaTypeNames.Application.Zip);
        }
        public FileResult Accreditation()
        {
            return File("~/Content/Accreditation.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
        }
    }
}
