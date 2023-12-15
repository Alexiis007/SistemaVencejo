using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.MailServices
{
    class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "christianalexis0918@gmail.com";
            password = "ywbwwkdhcumwgoka";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();

        }
    }
}
