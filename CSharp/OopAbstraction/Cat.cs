
namespace OopAbstraction;
internal abstract class Cat:Animal //: là kế thừa
{
    private bool gender;

    public void ShowInfocat()
    {
        Console.WriteLine($"{nameof(gender)} = {gender}");
    }
}
