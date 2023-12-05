using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Statanly.Web.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IClickRepository clickRepository;

        public AdminController(IClickRepository clickRepository)
        {
            this.clickRepository = clickRepository;
        }
        public IActionResult Index()
        {
            var clicks = this.clickRepository.Get();
            return View(clicks);
        }
    }
}
