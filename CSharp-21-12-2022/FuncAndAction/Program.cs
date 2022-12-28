using System.ComponentModel.DataAnnotations;

//delegate void Display();
internal class Program
{
    //method
     public static void Add(int a, int b) => Console.WriteLine(a + b);

    public static int Substract(int a, int b) => a - b;

    public static void Show() => Console.WriteLine("C2109I1");

    public static int ReturnNumber() => 5;

    private static void Main(string[] args)
    {
        // local function : hàm cục bộ, nằm trong một phương thức nào đó
        void Sub(int a, int b) => Console.WriteLine(a - b);

        //******func và action => đều là delegate
        //action: dùng cho các phương thức là void
        //func: là dùng cho các phương thức khác void

        //Display a = Show();
        //a();

        Action act = Show;
        act();

        //Action a = Sub;//local function không sử dụng được delegate

        Action<int, int> ac = Add;
        ac(4, 5);

        Func<int> fun = ReturnNumber;
        Console.WriteLine(fun());

        Func<int, int, int> fu = Substract; //int đầu là kiểu trả về, int 2 là a, int 3 là b
        Console.WriteLine(fu(10 ,5));

        //Action action = () =>
        //{
        //    Console.WriteLine("Love you chu cà mo");
        //};
        //c1
        //action();
        //c2
        //action.Invoke();

        Action<string> action = (str) =>
        {
            Console.WriteLine(str);
        };
        action("hello");
    }
}