
namespace OopEncapsulationProperty;
internal class HumanBeing
{
    //fields các field phải là private
    private string fullname;

    //thuộc tính address theo C# mới
    //viết web, console, window
    //dùng trong class này thì là field, ra ngoài class là thuộc tính
    public string Address { private get; set; }//get được ở đây, ra ngoài thì không lấy được
    public int Age { get; set; }

    //[property theo cách cũ
    //mobile , viết ứng dụng cho aroid, ios
    public string FullName // chỉ set, cài đặt giá trị
    {
        set => fullname = value;

        //get => fullname;
    }

    public void ShowProperty()
    {
        Console.WriteLine($"{nameof(Address)} = {Address}");
        Console.WriteLine($"{nameof(fullname)} = {fullname}");
    }
}
