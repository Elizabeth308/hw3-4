using homework3_4.Interfaces;
using System;

namespace homework3_4.Classes
{
    class ProvideValueInt:IValueProvider<int>
    {
        public int GetRandomValue()
        {
            Random random = new Random();
            int a = random.Next(0,2);
            return a;
        }


        public int GetUserValue()
        {
            int UserValue = int.Parse(Console.ReadLine());
            return UserValue;
        }
    }
}