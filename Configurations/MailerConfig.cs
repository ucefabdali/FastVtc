using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Security;

namespace FastVtc.Configurations
{
    public class MailerConfig
    {
        public MailerConfig()
        {
            this.HostSecureSocketOptions = SecureSocketOptions.Auto;
        }
        public string HostAddress { get; set; }

        public int HostPort { get; set; }

        public string HostUsername { get; set; }

        public string HostPassword { get; set; }

        public SecureSocketOptions HostSecureSocketOptions { get; set; }

        public string SenderEmail { get; set; }

        public string SenderName { get; set; }
    }
}
