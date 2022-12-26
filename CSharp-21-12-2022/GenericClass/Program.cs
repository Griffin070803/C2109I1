using GenericClass;

One<int> one = new One<int>();
one.Field = 10;
one.Show();

Two<string,int> two= new();
two.Field1 = "Nguyễn Hữu Huân";
two.Field2 = 10;
two.Show();

Two<int, double> t = new();
t.Field1 = 10;
t.Field2 = 10.5;
t.Show();