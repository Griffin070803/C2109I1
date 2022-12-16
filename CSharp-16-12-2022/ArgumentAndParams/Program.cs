using ArgumentAndParams;

//pure oop -> oop thuần
//ArgumentClass argu = new ArgumentClass();

// dùng var
//var argu = new ArgumentClass();

// TARGET-TYPE
ArgumentClass argu = new();
// Argument là tham số

//named argument
argu.Display(4,5,6);
argu.Display(a:4, b:5, c:6);
argu.Display(a: 4, b: 5, 6);
argu.Display(a: 4, 5, 6);
argu.Display(b: 5,  a: 4, c: 6);
argu.Display(c: 6, b: 5, a: 4);
//nếu để a lên trước, phía sau mặc định hiểu là b,c 

//nếu để b hoặc c lên trước thì nó sẽ lỗi
//argu.Display(b: 5, 4, 6); => error

argu.Show();//giá trị mặc định
argu.Show(10);//10 mặc định là a
argu.Show(10, 5);//10 mặc định là a, b mặc định là b
argu.Show(10, 5, 4);

argu.Show(a:10, b: 5, c: 4);
argu.Show(b: 5, c: 4);//a đã có giá trị mặc định

//================================
argu.SumParam(1);
argu.SumParam(1,2,3,4,5);

//cách cũ 
int[] mang = { 1, 2, 3, 4, 5 };
argu.SumParam(mang);