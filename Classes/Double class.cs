namespace homework3_4.Classes
{
    using homework3_4.Interfaces;
    class ProvideValueDouble:IValueProvider<double>
    {
        public double GetRandomValue()
        {
            Random random = new Random();
            int value = random.Next(10, 100000);
            string str = value.ToString();
            int length = str.Length;
            double number = value/(10*(length-1));
            return number;
        }
    }
}