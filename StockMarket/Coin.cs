namespace StockMarket
{
    public class Coin
    {
        public string name;

        public double value;

        public Coin(string Name, double Value)
        {
            name = Name;
            value = Value;
        }

        public string GetName()
        {
            return name;
        }
        public double GetValue()
        {
            return value;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        
        public void SetValue(double value)
        {
            this.value = value;
        }
    }
}
