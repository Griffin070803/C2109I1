using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal interface IBinaryFile
{
    // Có kiểu trả về và tên của phương thức nhưng không có bổ từ
    void WriteBinaryFile();
    void ReadFile();

    // phương thức mặc định của interface
    void ShowInfo() => Console.WriteLine("This is BinaryFile");
}
