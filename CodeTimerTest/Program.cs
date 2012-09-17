using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeTimer;
using System.Threading;

namespace CodeTimerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //CodeTimer.CodeTimer.Time("demo", 1000, () => 
            //{
            //    GC.Collect();
            //});

            int i = 1, j = 10;
            do
            {
                if (i++ > --j)
                    continue;
            } while (i < 5);
            Console.WriteLine(string.Format("{0} {1}",i,j));

            Console.Read();
        }
    }
}
