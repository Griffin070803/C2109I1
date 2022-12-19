using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverride;
internal class Parent
{
    public void Show() => Console.WriteLine("Parent Show");

    public virtual void Display() => Console.WriteLine("Parent Display");
    //virtual: tại thời điểm đó đúng, nhưng tương lai có thể đúng hoặc sai

}
