using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = null;
            try
            {
                Console.WriteLine(str.ToString());
                Console.WriteLine("Program Terminated");
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.ToString());
            }


            int[] arr1 = { 1, 11, 22, 33 };
            int[] arr2 = { 0, 1, 2 };
            for(int i = 0; i < arr1.Length; i++)
                try
                {
                    Console.WriteLine(arr1[i] + "/" + arr2[i] + "=" + arr1[i] / arr2[i]);
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("Cant divide");
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
        }
    }
}
