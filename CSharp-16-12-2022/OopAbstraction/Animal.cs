
namespace OopAbstraction;
internal abstract class Animal
{
    // không chỉ ra từ private mặc định sẽ là private
    // fields
    private string fullName;
    private int    age;

    public abstract void ShowInfo();
}
