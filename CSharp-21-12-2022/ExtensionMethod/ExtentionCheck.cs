using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod;
//biến cái class này thành extention method
// => class buộc phải là static
//một class là static thì toàn bộ bên trong nó phải là static
internal static class ExtentionCheck
{
    public static void IsGreaterThan(this int i, int value)
    {
        if (i > value)
        {
            Console.WriteLine($"{i} đúng là lớn hơn {value}");
        }
    }

 
    //class Program
    public static void Hi(this Program obj) => Console.WriteLine("hihi");
}
