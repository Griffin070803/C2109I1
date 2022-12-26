using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;
internal class Two<T,U>
{
    public T Field1 { get; set; }
    public U Field2 { get; set; }
    public void Show() => Console.WriteLine($"{Field1}, {Field2}");
}
