using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OopPolymorphismInterface;
internal class FileOne : IBinaryFile, ITextFile // : vửa đảm nhận kế thừa, vừa thực thi interface
                                                // kể kế thừa trước, interface sau
{
    public void ReadFile() => Console.WriteLine("Read File");

    public void WriteBinaryFile() => Console.WriteLine("Write Binary File");

    public void WriteTextFile() => Console.WriteLine("Write Text File");
}
