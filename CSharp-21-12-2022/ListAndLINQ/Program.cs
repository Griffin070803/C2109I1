

using System.Collections;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

List<Student> list = new()
{   new Student() {RollNumber = 1, Fullname = "Nguyễn Hữu Huân", Section = "Dãy số 1", HostelNumber = 1},
    new Student() {RollNumber = 2, Fullname = "Bùi Quang Lâm", Section = "Dãy số 1", HostelNumber = 2},
    new Student() {RollNumber = 3, Fullname = "Nguyễn Văn Vũ", Section = "Dãy số 1", HostelNumber = 3},
    new Student() {RollNumber = 4, Fullname = "Nguyễn Thanh Tùng", Section = "Dãy số 2", HostelNumber = 4},
    new Student() {RollNumber = 5, Fullname = "Lê Đức Huy", Section = "Dãy số 2", HostelNumber = 5},
    new Student() {RollNumber = 6, Fullname = "Trần Công Duy", Section = "Dãy số 2", HostelNumber = 6},
    new Student() {RollNumber = 7, Fullname = "Nguyễn Huỳnh Sơn", Section = "Dãy số 3", HostelNumber = 7},
    new Student() {RollNumber = 8, Fullname = "Trương Thị Đào", Section = "Dãy số 3", HostelNumber = 8},
    new Student() {RollNumber = 9, Fullname = "Đặng Quốc Cường", Section = "Dãy số 3", HostelNumber = 9}
};
//tính tốc độ chạy
Stopwatch sw = new Stopwatch();
sw.Restart();
foreach(var stu in list)
{
    Console.WriteLine(stu);
}
Console.WriteLine($"Foreach time: {sw.ElapsedMilliseconds}");
sw.Restart();

//tất cả các dạng của collection đều có mẫu để duyệt qua dữ liệu mà không dùng for hay foreach => ienumarator
//IEnumerator chạy nhanh hơn
IEnumerator<Student> enu = list.GetEnumerator();
while (enu.MoveNext())
{
    Console.WriteLine(enu.Current);
}
Console.WriteLine($"Foreach time: {sw.ElapsedMilliseconds}");
sw.Restart();

// *** LINQ *** => language Intergrated query

// -- linq to object
// -- Linq to sql 
// -- linq to xml, json

//đi làm sẽ học: parallel linq => pilinq

//sql: select from where group by having order by
//linq: from where group by having order by => select 

//==========================================================================================================


// linq to object có hai dạng : - style 1: theo trường phái sql => query syntax, dễ học, dễ hiểu
//                              - style 2: theo trường phái lamda => method syntax, khó học, rất khó hiểu

//liệt kể tất cả sinh viên với mã sinh viên phải lớn hơn 2

foreach (var stu in list)
{
    if(stu.RollNumber > 2)
    {
        Console.WriteLine(stu);
    }
}

// linq to object style 1: 

//IEnumerator là cha
//IEnumerable là con dùng để duyệt qua những linq

//IEnumerable<Student>
//var liststu = from t in list //t muốn đặt sao cũng được, nên đặt một kí tự
//                where t.RollNumber > 2
//                select t;

//foreach (var st in liststu)
//{
//    Console.WriteLine(st);
//}

// linq to object style 1 rút gọn: 


foreach (var st in from t in list
                   where t.RollNumber > 2
                   select t)
{
    Console.WriteLine(st);
}

//====================================================

// linq to object style 2:

//var listst = list.Select(stu => stu).Where(stu => stu.RollNumber > 2);//where trc, mới đến select, SAI NẶNG
//var liststu = list.Where(stu => stu.RollNumber > 2).Select(stu=>stu);//where đã trả về, kh cần select, select lại cái where, select hai lần, bị lập

//var liststu = list.Where(stu => stu.RollNumber > 2);
//foreach (var st in liststu)
//{
//    Console.WriteLine(st);
//}

// linq to object style 2 rút gọn:

foreach (var st in list.Where(stu => stu.RollNumber > 2)) 
{
    Console.WriteLine(st);
}

//các phương thức có sẵn trong list

//có 1 câu lệnh
list.ForEach(Console.WriteLine); // cách 1 nhanh hơn
list.ForEach(stu => Console.WriteLine(stu)); // cách 2

list.ForEach(
    stu =>
    {
        if(stu.RollNumber > 2)
        {
            Console.WriteLine(stu);
        }
    }
);

//kết hợp lambda với phương thức có sẵn của list
list.Where(stu => stu.RollNumber > 2)
    .ToList()
    .ForEach(Console.WriteLine);

//crtrl . ?  -- show only method là các phương thức có sẵn của list này, khi những phương thức này không có hãy dùng linq
//           -- show extendtion method là của linq với 
//list.


//var r = from stu in list
//        where stu.RollNumber > 2
//        select new // ANONYMOUS TYPE
//        {
//            stu.RollNumber,
//            stu.Fullname
//        }; //lấy hai cột
//r.ToList().ForEach(Console.WriteLine);


//var r = from stu in list
//        where stu.RollNumber > 2
//        select new // ANONYMOUS TYPE
//        {
//            StudentDetails = $"{stu.RollNumber} : {stu.Fullname}",
//            StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
//        }; //được quyền tùy biến
//r.ToList().ForEach(Console.WriteLine);

//=================== method syntax======================

//list.Select(stu => new
//{
//    StudentDetails = $"{stu.RollNumber} : {stu.Fullname}",
//    StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
//}).ToList().ForEach(Console.WriteLine);

foreach (var stu in list)
{
    Console.WriteLine(stu);
}

IEnumerator enume = list.GetEnumerator();
while (enume.MoveNext())
{

}

// Từ khi có linq
//2 câu dưới là 1
var b = from stu in list
        select stu;
//linq to object
//lần đầu tiên thực thi trên server và trả về bộ nhớ
//select * from list where rollnumber > 2
IEnumerable<Student> i = from stu in list
                         select stu;
//là vào bộ nhớ loại bỏ chỉ lấy 2 dòng đầu tiên
i = i.Take(2);

//==============
//linq to sql
//lần đầu tiên thực thi trên server và trả về bộ nhớ
//select * from list where rollnumber > 2
IQueryable<Student> u = from stu in list.AsQueryable()
                        select stu;
u = u.Take(2);
//select top(2) * from list where rollnumber > 2
//sẽ chạy lên server lần nữa
//hay sử dụng để làm phân trang, lazy loading

//=====================================================
var k = from stu in list
        where stu.RollNumber == 2
        select stu;
k.ToList().ForEach(Console.WriteLine);


//=====================================================
//sắp xếp

//list.OrderDescending();//tự động xắp sếp
//var obj1 = from stu in list
//           select stu;

//query syntax
var obj1 = from stu in list
           orderby stu.Section descending, stu.HostelNumber ascending
           select stu;
//method syntax
//câu này sai
//var obj2 = list.OrderByDescending(stu => stu.Section).OrderBy(stu => stu.HostelNumber);

//câu này đúng
var obj3 = list.Where(stu => stu.RollNumber > 2)
               .OrderByDescending(stu => stu.Section)
               .ThenBy(stu => stu.HostelNumber);
//ThenBy xắp sếp theo ascending