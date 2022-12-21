Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

HumanBeing human = new();
human.FullName = "Nguyễn Hữu Huân";
human.Address = "39 Hồ Xuân Hương, Phường 9, Đà Lạt, Lâm Đồng";
//string abc = human.Address; lỗi, vì private nên không lấy ra được