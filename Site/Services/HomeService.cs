using Site.Model;
using System;
using System.Threading;

namespace Site.Services
{
    public class HomeService
    {
        public bool Register(RegisterViewModel model)
        {
            var mail = new Mail(model);
            Thread workerThread = new Thread(mail.Send);

            workerThread.Start();

            return true;
        }       
    }
}