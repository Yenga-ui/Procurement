using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Procurement.Models
{
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }

        public MailRequest()
        {

        }

        public MailRequest(string toEmail, string subject, string body)
        {
            ToEmail = toEmail;
            Subject = subject;
            Body = body;
        }
    }
}
