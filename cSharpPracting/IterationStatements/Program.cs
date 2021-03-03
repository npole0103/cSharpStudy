using System;
using System.Collections; //ArrayList
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    class Program
    {
        public static void PrintValue(ArrayList myList)
        {
            foreach (string text in myList)
                Console.Write("\t{0}", text);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ArrayList myAl = new ArrayList();
            myAl.Add("Hello");
            myAl.Add("World");
            myAl.Add("!");
            Console.Write("Values:");
            PrintValue(myAl);
        }
    }
}
