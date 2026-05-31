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
        public IActionResult Subscribe(SubscriberViewModel subscriber)
        {
            if (!String.IsNullOrWhiteSpace(subscriber.Email))
            {
                //subscriber.Date = DateTime.Now;
                //this.subscriberRepository.Add(subscriber);
                return Ok("OK");
            }
            return View("Error");
        }
        [HttpPost]
        public async Task<IActionResult> Send(MessageViewModel message)
        {
            try
            {
                if (message.Check == 5)
                {
                    message.Subject = "Statanly Europe question";
                    await this.messageService.SendAsync(message);
                    ViewBag.Message = "Your question has been successfully submitted. We will respond to you as soon as possible.";
                    return Ok("OK");
                }
                else
                    return Ok("2 + 3 = ?");
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