using OopPolymorphismInterface;

//FileOne f = new();
//f.WriteBinaryFile();
//f.WriteTextFile();
//f.ReadFile();

////ép về interface

//   // Cách cũ
//((IBinaryFile)f).ShowInfo();

//   // cách mới
//(f as IBinaryFile).ShowInfo();


//FileTwo f = new();
//f.WriteBinaryFile();
//f.WriteTextFile();
//(f as IBinaryFile).ReadFile();
//(f as ITextFile).ReadFile();


ITextFile itext = new FileOne();
itext.ReadFile();
itext = new FileTwo();
itext.ReadFile();