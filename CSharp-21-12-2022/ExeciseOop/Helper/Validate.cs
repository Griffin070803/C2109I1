using System.Threading.Tasks.Dataflow;

namespace ExeciseOop.Helper;
internal class Validate<T>
{
    public static T CheckReadLine()
    {
        var     typeCode = Type.GetTypeCode(typeof(T));
        object  obj = new(); //có quyền hứng mọi kiểu dữ liệu
        bool    flag;
        do
        {
            flag = true;
            try
            {
                var str = Console.ReadLine();

                if (string.IsNullOrEmpty(str))//str != null 
                    //nếu sử dụng đa ngôn ngữ str is {}
                {
                    throw new Exception("Error, null or empty");
                }
                switch (typeCode)
                {
                    case TypeCode.String:
                        obj = str;
                        break;
                    case TypeCode.Int32:
                        obj = Convert.ToInt32(str);
                        if ((int)obj < 0) throw new Exception("Value must be greater than zero");
                        break;
                    case TypeCode.Double:
                        obj = Convert.ToDouble(str);
                        if ((double)obj < 0) throw new Exception("Value must be greater than zero");
                        break;
                    case TypeCode.DateTime:
                        var date = DateTime.TryParseExact(str, new[]
                        {"d/M/yyyy", "d-M-yyyy"}, new CultureInfo("vi-VN"), DateTimeStyles.None,
                        out var t)? t:throw new Exception("Datetime wrong (d/M/yyyy or d-M-yyyy)");
                        obj = date.Add(DateTime.Now.TimeOfDay);//giờ phút giây
                        break;
                    case TypeCode.Char:
                        obj = Convert.ToChar(str.ToLower);
                        if (!obj.In('y', 'n')) throw new Exception("Error, must b y or n");
                        break;
                    default:
                        obj = null;
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.GetType()} : {e.Message}, please enter again");
                flag = false;
            }
        } while (!flag);
        return (T)obj;
    }
}
