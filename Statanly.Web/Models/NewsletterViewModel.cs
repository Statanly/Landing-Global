using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Models
{
    public class NewsletterViewModel
    {
        public string Emails { get; set; }
        public string[] EmailList { get; set; }

        public string Text { get; set; }

        public string Subject { get; set; }

        public string FromEmail { get; set; }
        public string Password { get; set; }
    }
}
