using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> writeLines = new Queue<string>();

            string input = Console.ReadLine();
            while (input != "")
            {
                writeLines.Enqueue(input);
                input = Console.ReadLine();
            }

                foreach (string s in writeLines)
            {
                File.WriteAllLines(args[0], writeLines);
                }
            }
        }
    }