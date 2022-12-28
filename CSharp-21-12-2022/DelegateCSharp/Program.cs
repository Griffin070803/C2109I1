using DelegateCSharp;
//cách 1 pure oop: oop thuần
//xài nhiều lần
//Mathems ma = new();
//ma.Add(10, 5);

//cách 2: xài 1 lần
//new Mathems().Multi(10, 5);

//cách 3
//Mathems.Div(10, 5);


//dùng delegate
Abc dele = new Mathems().Multi;
dele += new Mathems().Sub;
dele(10, 5);//safe thread : luồng an toàn