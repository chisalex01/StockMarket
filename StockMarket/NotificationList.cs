using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class NotificationList : Dictionary<int, Notification>
    {
        public Dictionary<int, Notification> list = new();

        public NotificationList() { }

        public NotificationList AddNotification(int key, Notification notification)
        {
            list.Add(key, notification);
            return this;
        }

        public override string ToString()
        {
            string result = "";
            foreach (KeyValuePair<int, Notification> i in list)
            {
                result += i.Key + ". " + i.Value.GetNotification() + "\n";
            }
            return result;
        }
    }
}
