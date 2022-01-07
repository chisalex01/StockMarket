using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class Notification
    {
        public string notification; 

        public Notification(string notification) 
        {
            this.notification = notification;
        }

        public string GetNotification()
        {
            return notification;
        }
    }
}
