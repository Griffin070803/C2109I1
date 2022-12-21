using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal class FileTwo : IBinaryFile, ITextFile
{
    //không dùng bổ từ
    void IBinaryFile.ReadFile() => Console.WriteLine("Read File");
    void ITextFile.ReadFile() => Console.WriteLine("Read File");


    public void WriteBinaryFile() => Console.WriteLine("Write Binary File");

    public void WriteTextFile() => Console.WriteLine("Write Text File");
}
