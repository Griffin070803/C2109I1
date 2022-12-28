using UsingTuple;

// object initializer
Person per = new()
{
    Id = 1,
    FirstName = "nguyen",
    LastName = "huan"
};

Console.WriteLine(per.Id);
Console.WriteLine(per.FirstName);

//dùng valuetuple không cần dùng đến class (struct)f
ValueTuple<int, string, string> p1 = (1, "nguyen", "huan");
Console.WriteLine(p1.Item1);
Console.WriteLine(p1.Item2);

(int, string, string) p2 = (1, "nguyen", "huan");
Console.WriteLine(p2.Item1);
Console.WriteLine(p2.Item2);

//dùng var
var p3 = (1, "nguyen", "huan");//valuetuple

var p4 = (1); //=> variable int p4 = 1
        
// nhớ 1 trong 2 cách sau

//cách 1
// net cor dùng name thay thế cho các item1, item2.....
(int id, string FirstName, string LastName) p5 = (1, "nguyen", "huan");
Console.WriteLine(p5.Item1);
Console.WriteLine(p5.Item2);

//cách 2
//hoặc dùng name phía trước
var p6 = (ID: 1, FirstName:"nguyen", LastName:"huan");
Console.WriteLine(p6.Item1);
Console.WriteLine(p6.Item2);
p6.LastName = "aaa";
Console.WriteLine(p6.LastName);

//không phải là tuple => anonymous type => chỉ có get chứ không có set 
var p7 = new { Id = 1, FirstName = "nguyen", LastName = "huan" };
Console.WriteLine(p7.FirstName);
Console.WriteLine(p7.LastName);