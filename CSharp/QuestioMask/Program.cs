// Formar code ctrl + k + d

double a = 0.1;
double b = 0.2;
Console.WriteLine(a + b == 0.3 ? "true" : "false");

decimal c = 0.1M;
decimal d = 0.2M;
Console.WriteLine(c + d == 0.3M ? "true" : "false");

// ?: => ternary operator

// ? nullable value type 

string? fullname = null;
//int i = null; kiểu int không được phép null, kh giá trị thì mặc định 0
//c# cũ

Nullable<int> i = null;//kiểu int được để null

//c# mới

bool? check = null;

//int length = fullname != null ? fullname.Length : 0;

//int? length = fullname is not null ? fullname.Length : null;

//var a = 10;
//if (a is 10)
//{
//}

// NULL-CONDITIONAL OPERATOR " ? "
// dấu ? ở fullname tương tự dấu !=
//fullname mà khác null thì trả về phía sau.
int? length = fullname?.Length;

// NULL-COALESCING OPERATOR " ?? "
// tương tự như dấu ==
//fullname bằng null trả về vế sau
int? chieudai = fullname?.Length ?? 0;