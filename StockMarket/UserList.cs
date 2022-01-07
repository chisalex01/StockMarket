using System.Collections.Generic;

namespace StockMarket
{
    public class UserList : Dictionary<int, User>
    {
        public Dictionary<int, User> list = new Dictionary<int, User>();

        public UserList()
        { }

        public UserList AddUser(int key, User user)
        {
            list.Add(key, user);
            return this;
        }

        public UserList RemoveUser(int key)
        {
            list.Remove(key);
            return this;
        }

        public UserList UpdateLastName(int key, string name)
        {
            list[key].SetLast(name);
            return this;
        }

        public UserList UpdateFirstName(int key, string name)
        {
            list[key].SetFirst(name);
            return this;
        }

        public bool NewOrDeleteStatus(int key)
        {
            return list[key].GetNewOrDeletedStatus();
        }

        public bool UpdatedStatus(int key)
        {
            return list[key].GetUpdatedStatus();
        }

        public string UserName(int key)
        {
            return list[key].GetLast() + " " + list[key].GetFirst();
        }

        public override string ToString()
        {
            string result = $"Users:\n";
            foreach (KeyValuePair<int, User> i in list)
            {
                result += i.Key + ". " + i.Value.GetLast() + " " + i.Value.GetFirst() + " ";

                if (i.Value.GetNewOrDeletedStatus() == false && i.Value.GetUpdatedStatus() == false)
                    result += "(unsubscribed from all the news)" + "\n";
                else if(i.Value.GetNewOrDeletedStatus() == true && i.Value.GetUpdatedStatus() == true)
                    result += "(subscribed to all the news)" + "\n";
                else { 
                        if (i.Value.GetNewOrDeletedStatus() == false)
                            result += "(unsubscribed from new/deleted virtual coins news )";
                        else result += "(subscribed to new/deleted virtual coins news ) ";

                        if (i.Value.GetUpdatedStatus() == false)
                            result += "(unsubscribed from updated virtual coins news)" + "\n";
                        else result += "(subscribed to updated virtual coins news)" + "\n";
                    }
            }
            return result;
        }
    }
}
