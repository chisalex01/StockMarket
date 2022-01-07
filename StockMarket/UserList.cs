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

        public bool NewOrDeletedStatus(int key)
        {
            return list[key].NewOrDeletedStatus();
        }

        public bool UpdatedStatus(int key)
        {
            return list[key].UpdatedStatus();
        }

        public bool SetNewOrDeletedStatus(int key)
        {
            if (list[key].NewOrDeletedStatus() == true)
                return false;
            else
                return true;
        }

        public bool SetUpdatedStatus(int key)
        {
            if (list[key].UpdatedStatus() == true)
                return false;
            else
                return true;
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

                if (i.Value.NewOrDeletedStatus() == false && i.Value.UpdatedStatus() == false)
                    result += "(unsubscribed from all the news)" + "\n";
                else if(i.Value.NewOrDeletedStatus() == true && i.Value.UpdatedStatus() == true)
                    result += "(subscribed to all the news)" + "\n";
                else { 
                        if (i.Value.NewOrDeletedStatus() == false)
                            result += "(unsubscribed from new/deleted virtual coins news )";
                        else result += "(subscribed to new/deleted virtual coins news ) ";

                        if (i.Value.UpdatedStatus() == false)
                            result += "(unsubscribed from updated virtual coins news)" + "\n";
                        else result += "(subscribed to updated virtual coins news)" + "\n";
                    }
            }
            return result;
        }
    }
}
