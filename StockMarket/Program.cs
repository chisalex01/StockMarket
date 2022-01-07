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
        public static int coinKey = 1;
        public static int userKey = 1;

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
                            Console.WriteLine("Updating options: ");
                            Console.WriteLine("1) Update the name of the virtual coin");
                            Console.WriteLine("2) Update the value of the virtual coin");

                            Console.WriteLine("\r\n3) Back");

                            Console.Write("\r\nSelect an option: ");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Updating the name of the virtual coin");
                                    Console.Write("Insert new name: ");
                                    coinList.UpdateCoinName(keyCoin, Console.ReadLine());
                                    Console.WriteLine("\r\nPress ENTER to go back");
                                    if (Console.ReadLine() == "")
                                        return true;
                                    else
                                        Error();
                                    return true;

                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Updating the value of the virtual coin");
                                    Console.Write("Insert new value: ");
                                    coinList.UpdateCoinValue(keyCoin, Convert.ToDouble(Console.ReadLine()));
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
                            coinList.RemoveCoin(Convert.ToInt32(Console.ReadLine()));
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
                    Console.WriteLine("3) Remove user");

                    Console.WriteLine("\r\n4) Back");

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
                            Console.WriteLine("Updating options: ");
                            Console.WriteLine("1) Update the first name of this user");
                            Console.WriteLine("2) Update the last name of this user");

                            Console.WriteLine("\r\n3) Back");

                            Console.Write("\r\nSelect an option: ");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Updating the last name of this user");
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
                                    Console.WriteLine("Updating the first name of this user");
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
                            Console.WriteLine("Deleting user");
                            Console.Write("Insert user id: ");
                            userList.RemoveUser(Convert.ToInt32(Console.ReadLine()));
                            return true;

                        case "4":
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
