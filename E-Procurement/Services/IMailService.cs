using E_Procurement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Procurement.Services
{
  public  interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
