namespace ExeciseOop.Dal;
internal class DalProduct : IProduct
{
    
    public List<Product> ListPro { get; set; } = new();
    public void AddProduct()
    {
        Console.WriteLine("Enter the number of list product");
        var n = Validate<int>.CheckReadLine();
        for(int i = 0; i < n; i++)
        {
            Product pro = new();
            Console.WriteLine($"Product[{i+1}] => enter id product: ");
            pro.Proid = Validate<String>.CheckReadLine();

            ListPro.Add(pro);
        }
    }

}
