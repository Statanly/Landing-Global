using AspNetCore.SEOHelper.Sitemap;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;
   
        //not returning any view  
        public string UpdateSitemap()
        {
            var list = new List<SitemapNode>();
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/contact", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/solution", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/services", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/products", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/smartcity", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/company", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/team", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/mission", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/press", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/cooperation", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/research", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/info/reestr", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/info/cvflow", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/ml", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/da", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/cv", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/nlp", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "http://api.statanly.com:5001", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/service/1", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/service/2", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/service/3", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/service/4", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/service/5", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/service/6", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/case/1", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/case/2", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/case/3", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/case/4", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/case/5", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/case/6", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/case/7", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/case/8", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/case/9", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/smartcity/1", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/smartcity/2", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/smartcity/3", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/smartcity/4", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/smartcity/5", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/smartcity/6", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/smartcity", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/product/1", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/product/2", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/product/3", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/product/4", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/product/5", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/product/6", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/product/7", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/product/8", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/product/9", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/home/product/10", Frequency = SitemapFrequency.Weekly });

            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/industry/agro", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/industry/development", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/industry/horeca", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/industry/logistics", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/industry/media", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/industry/medicine", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/industry/prom", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/industry/retail", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/industry/transport", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/industry", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/technology/deepfakes", Frequency = SitemapFrequency.Weekly });
            list.Add(new SitemapNode() { LastModified = DateTime.UtcNow, Priority = 1.0, Url = "https://statanly.com/technology/uav", Frequency = SitemapFrequency.Weekly });


            new SitemapDocument().CreateSitemapXML(list, _env.WebRootPath);
            return "sitemap.xml file should be create in root directory";
        }
        public AdminController(IClickRepository clickRepository, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            this.clickRepository = clickRepository;
            _logger = logger;
            _env = env;
        }
        public IActionResult Index()
        {
            var clicks = this.clickRepository.Get();
            return View(clicks);
        }
    }
}
