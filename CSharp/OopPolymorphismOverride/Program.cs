using OopPolymorphismOverride;

Child ch1 = new Child();
ch1.Display();
ch1.Show(); //lấy phương thức của con, không lấy của cha, kh ghi đè, là phương thức hoàn toàn mới của con

Parent pa = new Child();  //cha tham chiếu tới con, những phương thức mà con sửa lại, cha có quyền sử dụng
pa.Display();
pa.Show(); // lấy Phương thức Show của cha

Parent par = new Parent();
par.Display();
