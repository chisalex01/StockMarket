using System;
using System.Linq;
using System.Collections.Generic;

namespace StockMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu();
            }
        }

        public static CoinList coinList = new();
        public static UserList userList = new();
        public static NotificationList newOrDeletedList = new();
        public static NotificationList updatedList = new();
        public static int coinKey = 1;
        public static int userKey = 1;
        public static int newOrDeletedKey = 1;
        public static int updatedKey = 1;

        static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Stock market");

            Console.WriteLine("1) Virtual coins");
            Console.WriteLine("2) Users");

            Console.WriteLine("\r\n3) Exit");

            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(coinList);

                    Console.WriteLine("1) Add virtual coin");
                    Console.WriteLine("2) Update virtual coin");
                    Console.WriteLine("3) Remove virtual coin");

                    Console.WriteLine("\r\n4) Back");

                    Console.Write("\r\nSelect an option: ");
                    
                    switch (Console.ReadLine())
                    {

                        case "1":
                            Console.Clear();
                            Console.WriteLine("Adding new virtual coin");

                            Console.Write("Insert coin name: ");
                            string coinName = Console.ReadLine();

                            Console.Write("Insert coin value: ");
                            double coinValue = Convert.ToDouble(Console.ReadLine());

                            Coin coin = new(coinName, coinValue);
                            coinList.AddCoin(coinKey, coin);
                            coinKey++;

                            string text = coinName + " has been added and it's value is: " + coinValue + "\n";
                            Notification notification = new(text);
                            newOrDeletedList.AddNotification(newOrDeletedKey, notification);
                            newOrDeletedKey++;

                            Console.WriteLine("\r\n\r\nPress ENTER to go back");
                            if (Console.ReadLine() == "")
                                return true;
                            else
                                Error();
                            return true;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Updating virtual coin");

                            Console.Write("Insert coin id: ");
                            int keyCoin = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();
                            Console.WriteLine("Updating options for " + coinList.CoinName(keyCoin) + ":");
                            Console.WriteLine("1) Update the name of the virtual coin");
                            Console.WriteLine("2) Update the value of the virtual coin");

                            Console.WriteLine("\r\n3) Back");

                            Console.Write("\r\nSelect an option: ");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Changing the name of " + coinList.CoinName(keyCoin));

                                    Console.Write("Insert new name: ");
                                    string newName = Console.ReadLine();
                                    coinList.UpdateCoinName(keyCoin, newName);

                                    string text0 = coinList.CoinName(keyCoin) + "'s name has been modified and now it's new name is: " + newName + "\n";
                                    Notification notification0 = new(text0);
                                    updatedList.AddNotification(updatedKey, notification0);
                                    updatedKey++;

                                    Console.WriteLine("\r\nPress ENTER to go back");
                                    if (Console.ReadLine() == "")
                                        return true;
                                    else
                                        Error();
                                    return true;

                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Updating the value of " + coinList.CoinName(keyCoin));

                                    Console.Write("Insert new value: ");
                                    double newValue = Convert.ToDouble(Console.ReadLine());
                                    coinList.UpdateCoinValue(keyCoin, newValue);

                                    string text1 = coinList.CoinName(keyCoin) + "'s value has been modified and now it's new value is: " + newValue + "\n";
                                    Notification notification1 = new(text1);
                                    updatedList.AddNotification(updatedKey, notification1);
                                    updatedKey++;

                                    Console.WriteLine("\r\nPress ENTER to go back");
                                    if (Console.ReadLine() == "")
                                        return true;
                                    else
                                        Error();
                                    return true;

                                case "3":
                                    Menu();
                                    return true;

                                default:
                                    Error();
                                    return true;
                            }

                        case "3":
                            Console.Clear();
                            Console.WriteLine("Deleting virtual coin");

                            Console.Write("Insert coin id: ");
                            int key = Convert.ToInt32(Console.ReadLine());
                            
                            string text2 = coinList.CoinName(key) + " has been deleted" + "\n";
                            Notification notification2 = new(text2);
                            newOrDeletedList.AddNotification(newOrDeletedKey, notification2);
                            newOrDeletedKey++;

                            coinList.RemoveCoin(key);

                            return true;

                        case "4":
                            Menu();
                            return true;

                        default:
                            Error();
                            return true;
                    }
                case "2":
                    Console.Clear();
                    Console.WriteLine(userList);

                    Console.WriteLine("1) Add user");
                    Console.WriteLine("2) Update user"); 
                    Console.WriteLine("3) See user's notifications");
                    Console.WriteLine("4) Remove user");

                    Console.WriteLine("\r\n5) Back");

                    Console.Write("\r\nSelect an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Adding new user");

                            Console.Write("Insert user last name: ");
                            string userLast = Console.ReadLine();

                            Console.Write("Insert user first name: ");
                            string userFirst = Console.ReadLine();

                            User user = new(userLast, userFirst);
                            userList.AddUser(userKey, user);
                            userKey++;

                            Console.WriteLine("\r\n\r\nPress ENTER to go back");
                            if (Console.ReadLine() == "")
                                return true;
                            else
                                Error();
                            return true;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Updating User");

                            Console.Write("Insert user id: ");
                            int keyUser = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();
                            Console.WriteLine("Updating options for " + userList.UserName(keyUser) + ":");
                            Console.WriteLine("1) Change the last name");
                            Console.WriteLine("2) Change the first name");

                            Console.WriteLine("\r\n3) Back");

                            Console.Write("\r\nSelect an option: ");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Updating the last name of " + userList.UserName(keyUser));
                                    Console.Write("Insert new last name: ");
                                    userList.UpdateLastName(keyUser, Console.ReadLine());
                                    Console.WriteLine("\r\nPress ENTER to go back");
                                    if (Console.ReadLine() == "")
                                        return true;
                                    else
                                        Error();
                                    return true;

                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Updating the first name of " + userList.UserName(keyUser));
                                    Console.Write("Insert new first name: ");
                                    userList.UpdateFirstName(keyUser, Console.ReadLine());
                                    Console.WriteLine("\r\nPress ENTER to go back");
                                    if (Console.ReadLine() == "")
                                        return true;
                                    else
                                        Error();
                                    return true;

                                case "3":
                                    Menu();
                                    return true;

                                default:
                                    Error();
                                    return true;
                            }

                        case "3":
                            Console.Clear();
                            Console.WriteLine("User's notifications");

                            Console.Write("Insert the id of the user that you want to see the notifications of: ");
                            int keyUserNotifications = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();
                            Console.WriteLine(userList.UserName(keyUserNotifications) + "'s notifications: ");
                            Console.WriteLine("1) See notifications ");
                            Console.WriteLine("2) Change status");

                            Console.WriteLine("\r\n3) Back");

                            Console.Write("\r\nSelect an option: ");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine(userList.UserName(keyUserNotifications) + "'s notifications:\n");

                                    Console.WriteLine("News about new or deleted coins:");
                                    if (userList.NewOrDeletedStatus(keyUserNotifications) == true)
                                        Console.WriteLine(newOrDeletedList + "\n");
                                    else Console.WriteLine("This user is not subscribed to this list...\n");

                                    Console.WriteLine("News updated coins:");
                                    if (userList.UpdatedStatus(keyUserNotifications) == true)
                                        Console.WriteLine(updatedList);
                                    else Console.WriteLine("This user is not subscribed to this list...");

                                    Console.WriteLine("\r\nPress ENTER to go back");
                                    if (Console.ReadLine() == "")
                                        return true;
                                    else
                                        Error();
                                    return true;

                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Changing the status of " + userList.UserName(keyUserNotifications) + "'s subscriptions\n");
                                    if (userList.NewOrDeletedStatus(keyUserNotifications) == true)
                                        Console.WriteLine("New or removed virtual coins news: subscribed");
                                    else Console.WriteLine("New or removed virtual coins news: unsubscribed");

                                    if (userList.UpdatedStatus(keyUserNotifications) == true)
                                        Console.WriteLine("Updated virtual coins news: subscribed\n");
                                    else Console.WriteLine("Updated virtual coins news: unsubscribed\n");

                                    Console.WriteLine("1) Change status for new or removed virtual coins ");
                                    Console.WriteLine("2) Change status for updated virtual coins");
                                    Console.WriteLine("3) Change status for both");


                                    Console.WriteLine("\r\n4) Back");

                                    Console.Write("\r\nSelect an option: ");

                                    switch (Console.ReadLine())
                                    {
                                        case "1":
                                            userList.SetNewOrDeletedStatus(keyUserNotifications);
                                            return true;

                                        case "2":
                                            userList.SetUpdatedStatus(keyUserNotifications);
                                            return true;

                                        case "3":
                                            userList.SetNewOrDeletedStatus(keyUserNotifications);
                                            userList.SetUpdatedStatus(keyUserNotifications);
                                            return true;

                                        case "4":
                                            Menu();
                                            return false;

                                        default:
                                            Error();
                                            return true;
                                    }

                                case "3":
                                    Menu();
                                    return true;

                                default:
                                    Error();
                                    return true;
                            }

                        case "4":
                            Console.Clear();
                            Console.WriteLine("Deleting user");
                            Console.Write("Insert user id: ");
                            userList.RemoveUser(Convert.ToInt32(Console.ReadLine()));
                            return true;

                        case "5":
                            Menu();
                            return true;

                        default:
                            Error();
                            return true;
                    }

                case "3":
                    return false;

                default :
                    Error();
                    return true;
            }
        }

        static void Error()
        {
            Console.WriteLine("\r\nOption not available! Choose one of the available options!");
            Console.Write("\r\nPress Enter to go back to the menu");
            Console.ReadLine();
            Menu();
        }
    }
}