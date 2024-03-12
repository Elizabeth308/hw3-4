using homework3_4.Interfaces;
using System;

namespace homework3_4.Classes
{
    class ProvideValueString:IValueProvider<string>
    {
        public string GetRandomValue()
        {   
            char[] CharArray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random random = new Random();
            char[] array1 = new char[10];
            for(int i = 0; i < 10; i++)
            {
                int number = random.Next(0,26);
                array1[i] = CharArray[number];
            }
            return new string(array1);
        }

        public string GetUserValue()
        {
            string UserString = Console.ReadLine();
            return UserString;
        }
    }
}