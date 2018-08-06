
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment02
{
    public delegate void mydel(int num);
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass dc = new DelegateClass();

            //int number = 2349465;
            mydel del = dc.printNumber;

            del += dc.printMoney;
            del += dc.printHexadecimal;

            del(10000000);
          
           
        }
    }
}
