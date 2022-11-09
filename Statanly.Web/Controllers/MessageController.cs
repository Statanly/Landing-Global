using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Statanly.Web.Infrastructure.Interfaces;
using Statanly.Web.Models;

namespace Statanly.Web.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class MessageController : Controller
    {
        private readonly IMessageService messageService;

        public MessageController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        [HttpPost]
        public async Task<IActionResult> Send(MessageViewModel message)
        {
            try
            {
                if (message.Check == 7)
                {
                    message.Subject = "Вопрос с сайта";
                    await this.messageService.SendAsync(message);
                    ViewBag.Message = "Ваш вопрос успешно отправлен. Мы ответим Вам в ближайшее время.";
                    return Ok("OK");
                }
                else
                    return Ok("2 + 7 = ?");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Newsletter()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Newsletter(NewsletterViewModel message)
        {
            ViewBag.Message = "Start";
            var s = message.Subject;
            message.EmailList = message.Emails.Split(new[] { "\r\n" }, StringSplitOptions.None);
            ViewBag.Message = await this.messageService.SendAsync(message);
            return View();
        }
    }
}