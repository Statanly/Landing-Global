using Statanly.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Infrastructure.Interfaces
{
    public interface IMessageService
    {
        Task<string> SendAsync(MessageViewModel message);
        Task<string> SendAsync(NewsletterViewModel mails);
    }
}
