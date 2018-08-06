using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment02
{
    class DelegateClass
    {
        public void printNumber(int number)
        {
            Console.WriteLine("{0:N}", number);
        }
        public void printMoney(int number)
        {
            Console.WriteLine("{0:C}", number);
        }
        public void printHexadecimal(int number)
        {
            Console.WriteLine("{0:X}", number);
        }

    }
}
