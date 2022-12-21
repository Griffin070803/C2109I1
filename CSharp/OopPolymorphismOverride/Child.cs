using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverride;
internal class Child:Parent
{
    public override void Display()
    {
        base.Display();
        // Con muốn sửa cha, thì cha phải có virtual
        Console.WriteLine("Child Display");
    }

    //public override void Show() // con kh thể sửa, vì phương thức này kh có virtual
    //{
    //}

    public new void Show() //phương thức mới hoàn toàn của con
    {
        Console.WriteLine("Child show");
    }
}
