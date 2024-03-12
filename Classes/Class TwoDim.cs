using homework3_4.Interfaces;
using System;

namespace homework3_4.Classes
{
    sealed class TwoDGeneric<T>:ArrayBase,IPrinter
    {
        private IValueProvider<T> _provider;
        private T[,] array;
        public TwoDGeneric(IValueProvider<T> provider, bool random = false)
        {
            _provider = provider;
            ReCreateArray(random);
        }

        public override void ReCreateArray(bool random)
        {
            Console.WriteLine("Enter the length of your array (2 dimensions)");
            int arrayLength = int.Parse(Console.ReadLine());
            array = new T[arrayLength,arrayLength];
            base.ReCreateArray(random);
        }


        public override void RandomFill()
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int f = 0; f < array.GetLength(0); f++)
                {   
                    array[i,f] = _provider.GetRandomValue();
                }
            }
        }
    
        public override void UserFill()
        {
            Console.WriteLine("Enter something");
            for(int i = 0; i<array.GetLength(0); i++)
            {
                for(int f = 0; f < array.GetLength(0); f++)
                {   
                    array[i,f] = _provider.GetUserValue();
                }
            }
        }

        void IPrinter.Print()
        {
            Console.WriteLine("Your array (two dimensions): ");
            for (int i = 0; i < array.GetLength(0); i++)
            {  
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}