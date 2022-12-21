using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod;
internal class CheckNumber
{
    public static void Check(int i, int value)
    {
        if (i > value)
        {
            Console.WriteLine($"{i} đúng là lớn hơn cái {value}");
        }
    }
}
