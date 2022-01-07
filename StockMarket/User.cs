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
            newOrDeletedStatus = true;
            updatedStatus = true;
        }

        public string GetLast()
        {
            return last;
        }

        public string GetFirst()
        {
            return first;
        }

        public bool NewOrDeletedStatus()
        {
            return newOrDeletedStatus;
        }

        public bool UpdatedStatus()
        {
            return updatedStatus;
        }

        public void SetLast(string name)
        {
            this.last = name;
        }
        public void SetFirst(string name)
        {
            this.first = name;
        }
    }
}
