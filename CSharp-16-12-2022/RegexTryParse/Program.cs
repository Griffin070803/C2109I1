using System.Text;
using System.Text.RegularExpressions;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string? str = null;
Console.WriteLine("Vui long nhap so: ");
str = Console.ReadLine();

var formula = new Regex("^[0-9]+$");

//sử dụng nhiều trong web
if(formula.IsMatch(str))
{
    //int result = int.Parse(str);//nếu chỉ dùng c#

    //nếu sử dụng đa ngôn ngữ 
    int result = Convert.ToInt32(str);
    Console.WriteLine(++result);
}

//sử dụng nhiều dưới console
if (int.TryParse(str, out int i))//nếu ép kh thành công là null
{
    Console.WriteLine($"i là số: {i}");
}


Console.WriteLine("Vui lòng nhập số lượng: ");
string? amount = Console.ReadLine();
//dùng try catch
// Mệnh đề " GRUAD CLAUSE "
if (string.IsNullOrEmpty(amount)) return;

//làm cái gì đó

//======cách 2==========
if(amount != null)
{
    //làm cái gì đó
}

try
{
    int total = int.Parse(amount);
    if (total <= 0) throw new Exception("Phải lớn hơn 0");
    Console.WriteLine($"{nameof(total)}={total}");
} 
catch(Exception) when (amount.Contains("$"))
{
    Console.WriteLine("Chuỗi không được có dấu $");
}
catch (Exception e)
{
    Console.WriteLine($"{e.GetType()}, {e.Message}");
}