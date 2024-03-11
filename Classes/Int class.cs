namespace homework3_4.Classes
{
    using homework3_4.Interfaces;
    class ProvideValueInt:IValueProvider<int>
    {
        public int GetRandomValue()
        {
            Random random = new Random();
            int a = random.Next(0,2);
            return a;
        }
    }
}