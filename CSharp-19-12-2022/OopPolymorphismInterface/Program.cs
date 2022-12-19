using OopPolymorphismInterface;

FileOne f = new();
f.WriteBinaryFile();
f.WriteTextFile();
f.ReadFile();

//ép về interface

// Cách cũ
((IBinaryFile)f).ShowInfo();

// cách mới
(f as IBinaryFile).ShowInfo();