using System.Collections.Generic;

namespace StockMarket
{
    public class CoinList : Dictionary<int, Coin>
    {
        public Dictionary<int, Coin> list = new Dictionary<int, Coin>();

        public CoinList()
        { }

        public CoinList AddCoin(int key, Coin coin)
        {
            list.Add(key, coin);
            return this;
        }

        public CoinList RemoveCoin(int key)
        {
            list.Remove(key);
            return this;
        }

        public CoinList UpdateCoinName(int key, string name)
        {
            list[key].setName(name);
            return this;
        }

        public CoinList UpdateCoinValue(int key, double value)
        {
            list[key].setValue(value);
            return this;
        }

        public override string ToString()
        {
            string result = $"Virtual Coins:\n";
            foreach (KeyValuePair<int, Coin> i in list)
            {
                result += i.Key + ". " + i.Value.GetName() + "-" + i.Value.GetValue() + "$" + "\n";
            }
            return result;
        }
    }
}
