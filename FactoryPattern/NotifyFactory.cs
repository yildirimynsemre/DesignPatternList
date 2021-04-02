using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class NotifyFactory
    {
        public INotify CreateNotify(string notifyType)
        {
            if (notifyType == "SMS")
            {
                return new SmsNotify();
            }
            else if (notifyType == "MAIL")
            {
                return new MailNotify();
            }
            return null;
        }
    }
}
