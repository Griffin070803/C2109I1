
namespace ExeciseOop.Entity;
internal class Product
{
    public string Proid { get; set; }
    public string ProName { get; set; }
    public double ProPrice { get; set; }
    public int ProQuantity { get; set; }
    public DateTime ProDate { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Proid)}={Proid}, {nameof(ProName)}={ProName}, {nameof(ProPrice)}={ProPrice.ToString()}, {nameof(ProQuantity)}={ProQuantity.ToString()}, {nameof(ProDate)}={ProDate.ToString("dd/MM/yyyy h:m:s")}}}";
    }
}
