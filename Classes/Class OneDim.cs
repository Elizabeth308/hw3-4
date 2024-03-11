namespace homework3_4.Classes
{
    using homework3_4.Interfaces;
    sealed class OneDGeneric<T>:ArrayBase,IPrinter
    {
        private IValueProvider<T> _provider;
        private T[] array;
        public OneDGeneric(IValueProvider<T> provider, bool random = false)
        {
            _provider = provider;
            ReCreateArray(random);
        }

        private void FillArray()
        {
            for(int i = 0; i<array.Length; i++)
            {
                array[i] = _provider.GetRandomValue();
            }
        }

        public override void CreateArray()
        {
            Console.WriteLine("Enter the length of your array (1 dimension)");
            int arrayLength = int.Parse(Console.ReadLine());
            array = new T[arrayLength];
            FillArray();
        }
    
        public override void UserChoise()
        {
            Console.WriteLine("Enter the length of your array (1 dimension)");
            int arrayLength = int.Parse(Console.ReadLine());
            array = new T[arrayLength];
            FillArray();
        }

        void IPrinter.Print()
        {
            Console.WriteLine("Your array (one dimension): ");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}