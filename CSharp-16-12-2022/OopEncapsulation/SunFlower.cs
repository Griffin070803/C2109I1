
namespace OopEncapsulation;
internal class SunFlower:Plant
{
    static void Main(string[] args)
    {
        Plant sf = new();
        sf.Public();
        sf.Internal();
        sf.ProtectedInternal();

        SunFlower s = new();
        s.Public();
        s.Internal();
        s.Protected();
        s.PrivateProtected();
        s.ProtectedInternal();
    }
}
