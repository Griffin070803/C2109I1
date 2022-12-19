
namespace OopEncapsulation;
//muốn xài được ở đồ án đổi internal thành public
//internal class Plant
public class Plant
{
    //encapsulation thể hiện ở 2 nơi
    //-1-ACCESS MODIFY
    //-2-PROPERTY

    //access modify bổ từ 
    private            void Private()           => Console.WriteLine("Private");
    //đứng tại class đó mới được sử dụng

    protected          void Protected()         => Console.WriteLine("Protected");
    // con cái mới được quyền sài

    internal           void Internal()          => Console.WriteLine("Internal");
    //trong một project là được quyền sài

    private protected  void PrivateProtected()  => Console.WriteLine("Private Protected");
    //tôi đứng tại class này hoặc con tôi có quyền xài
    //một trong hai là thỏa
    //đứng trong một project mới được sử dụng, khác project không được sử dụng

    protected internal void ProtectedInternal() => Console.WriteLine("Protected Internal");
    //một trong hai là thỏa

    public             void Public()            => Console.WriteLine("Public");
    //một trong hai là thỏa

}
