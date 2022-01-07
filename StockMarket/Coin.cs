namespace StockMarket
{
    public class Coin
    {
        public string name { get; set; }

        public double value { get; set; }

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

        public void setName(string name)
        {
            this.name = name;
        }

        
        public void setValue(double value)
        {
            this.value = value;
        }
    }
}
