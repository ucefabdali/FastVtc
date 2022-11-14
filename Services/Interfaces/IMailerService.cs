using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastVtc.Services.Interfaces
{
    public interface IMailerService
    {
        Task SendEmailAsync(string to, string subject, string message);
    }
}
