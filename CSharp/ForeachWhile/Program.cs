using System.Collections;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
string[] arrs = { "Huân", "Gryffin", "Tùng", "Vũ", "Huy" };

foreach (var t in arrs)
{
    Console.WriteLine($"{t} có chiều dài là: {t.Length}");
}

//int i = 0;
//int length = arrs.Length;
//while(i < arrs.Length)//mỗi lần chạy phải length lại lần nữa
//{
//    Console.WriteLine($"{arrs[i]} có chiều dài {arrs[i].Length}");
//    i++;
//}

IEnumerator e = arrs.GetEnumerator();  
while (e.MoveNext())
{
    string s = (string)e.Current;
    Console.WriteLine($"{s} có chiều dài {s.Length}");
}