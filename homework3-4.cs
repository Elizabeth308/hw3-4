using System;
using homework3_4.Interfaces;
using homework3_4.Classes;

namespace homework3_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("If you want to fill your array with random numbers, type \"false\", if you want to fill it yourself, type \"true\"");
            bool userchoise = bool.Parse(Console.ReadLine());
            ProvideValueString stringvalue = new ProvideValueString();
            OneDGeneric<string> stringArray = new OneDGeneric<string>(stringvalue);
            ProvideValueInt intvalue = new ProvideValueInt();
            OneDGeneric<int> intArray = new OneDGeneric<int>(intvalue);
            ProvideValueDouble doublevalue = new ProvideValueDouble();
            OneDGeneric<double> doubleArray = new OneDGeneric<double>(doublevalue);
            ProvideValueBool boolvalue = new ProvideValueBool();
            OneDGeneric<bool> boolArray = new OneDGeneric<bool>(boolvalue);
            IPrinter[] printers = {stringArray, intArray, boolArray, doubleArray};
            foreach(var t in printers)
            {
                t.Print();
            }
            Console.ReadLine();
        }
    }

}
