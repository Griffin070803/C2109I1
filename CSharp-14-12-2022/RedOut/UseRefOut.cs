using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut;
internal class UseRefOut
{
    // EXPRESSION BODY
    // khi một phương thức chỉ có một câu lệnh duy nhất
    public void ShowInfo() =>
        Console.WriteLine("Thông tin về class này");
    public void ChangeNumber(ref int a, ref int b)
    {
        int tam = a;
        a = b;
        b = tam;
        Console.WriteLine($"ChangeNumber : {nameof(a)}= {a}, {nameof(b)}= {b}");
    }
}
