using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> objectList = new List<object>();

            int a = 42;
            string b = "wow";
            float c = 8f;
            string d = "Pingas";
            int e = 69;

            objectList.Add(a);
            objectList.Add(b);
            objectList.Add(c);
            objectList.Add(d);
            objectList.Add(e);

            Console.WriteLine(Checker.HowManyOfType<string>(objectList));
            Console.WriteLine(Checker.HowManyOfType<float>(objectList));
            Console.WriteLine(Checker.HowManyOfType<int>(objectList));
        }
    }
}