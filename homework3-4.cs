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
            Console.WriteLine("---------------------------String array---------------------------");
            ProvideValueString stringvalue = new ProvideValueString();
            OneDGeneric<string> stringArray1 = new OneDGeneric<string>(stringvalue, userchoise);
            TwoDGeneric<string> stringArray2 = new TwoDGeneric<string>(stringvalue, userchoise);
            Console.WriteLine("---------------------------Int array---------------------------");
            ProvideValueInt intvalue = new ProvideValueInt();
            OneDGeneric<int> intArray1 = new OneDGeneric<int>(intvalue, userchoise);
            TwoDGeneric<int> intArray2 = new TwoDGeneric<int>(intvalue, userchoise);
            Console.WriteLine("---------------------------Double array---------------------------(enter value with comma)");
            ProvideValueDouble doublevalue = new ProvideValueDouble();
            OneDGeneric<double> doubleArray1 = new OneDGeneric<double>(doublevalue, userchoise);
            TwoDGeneric<double> doubleArray2 = new TwoDGeneric<double>(doublevalue, userchoise);
            Console.WriteLine("---------------------------Bool array---------------------------");
            ProvideValueBool boolvalue = new ProvideValueBool();
            OneDGeneric<bool> boolArray1 = new OneDGeneric<bool>(boolvalue, userchoise);
            TwoDGeneric<bool> boolArray2 = new TwoDGeneric<bool>(boolvalue, userchoise);
            IPrinter[] printers = {stringArray1, stringArray2, intArray1, intArray2, doubleArray1, doubleArray2, boolArray1, boolArray2};
            foreach(var t in printers)
            {
                t.Print();
            }
            Console.ReadLine();
        }
    }

}
