using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace print1to10
{
	class Program
{
static void Main(string[] args)
		{
                Random engine = new Random();
                int a = engine.Next(1, 10);
                a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
              printNumber1To10(a);
 }


 private static bool printNumber1To10(int a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                Console.WriteLine("a");
                break;
                return true;
                 default:
                    Console.WriteLine("number not in rang");
                    break;
                  return false;

}

            Thread.Sleep(500);
            }
            }
}            
