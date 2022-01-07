using System;

namespace StockMarket
{
    public class User
    {
        public string last;
        public string first;
        public bool newOrDeletedStatus;
        public bool updatedStatus;

        public User(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;
            newOrDeletedStatus = false;
            updatedStatus = false;
        }

        public void NewOrDeletedStatus(string newOrDeletedStatus)
        {
            if (newOrDeletedStatus == "subscribed")
                this.newOrDeletedStatus = false;
            else if (newOrDeletedStatus == "unsubscribed")
                this.newOrDeletedStatus = true;
            else Console.WriteLine("");
        }

        public void UpdatedStatus(string updatedStatus)
        {
            if (updatedStatus == "subscribed")
                this.updatedStatus = false;
            else if (updatedStatus == "unsubscribed")
                this.newOrDeletedStatus = true;
            else Console.WriteLine("");
        }

        public string GetLast()
        {
            return last;
        }

        public string GetFirst()
        {
            return first;
        }

        public bool GetNewOrDeletedStatus()
        {
            return newOrDeletedStatus;
        }

        public bool GetUpdatedStatus()
        {
            return updatedStatus;
        }

        public void setLast(string name)
        {
            this.last = name;
        }
        public void setFirst(string name)
        {
            this.first = name;
        }
    }
}
