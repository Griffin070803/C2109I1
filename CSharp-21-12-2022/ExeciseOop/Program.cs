

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

DalProduct prod = new();
prod.ChangColor(ConsoleColor.Black, ConsoleColor.Green);
prod.AddProduct();

Product pro = new();
Console.WriteLine("Vui lòng nhập ID hàng hóa( kiểu string ): ");
pro.Proid = Validate<string>.CheckReadLine();

Console.WriteLine("Vui lòng nhập số lượng hàng hóa( kiểu int ): ");
pro.ProQuantity = Validate<int>.CheckReadLine();

Console.WriteLine("Vui lòng nhập ngày sản xuất: ");
pro.ProDate = Validate<DateTime>.CheckReadLine();
Console.WriteLine(pro);
