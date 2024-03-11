namespace homework3_4.Classes
{
    using homework3_4.Interfaces;   
    class ProvideValueBool:IValueProvider<bool>
    {
        public bool GetRandomValue()
        {
            Random random = new Random();
            int value = random.Next(0,2);
            if(value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}