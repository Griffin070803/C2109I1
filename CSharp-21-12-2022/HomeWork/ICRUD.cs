
using System.Reflection;
using System.Xml;

namespace HomeWork;

 
internal class ICRUD
{
    List<SinhVien> list = null;

    public ICRUD()
    {
        list = new List<SinhVien>();
    }
    public int SoLuongSinhVien()
    {
        int Count = 0;
        if (list != null)
        {
            Count = list.Count;
        }
        return Count;
    }

    public void NhapSinhVien()
    {
        string masv;
        string tensv;
        string gtsv;
        string dobsv;

        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        SinhVien sv = new();
        while (true)
        {
            Console.WriteLine("Nhập ID sinh viên: ");
            masv = Console.ReadLine();
            if (Validation.checkRegex(RegexConst.NUM, masv))
            {
                sv.Id = int.Parse(masv);
                break;
            }
        }
      
        while (true)
        {
            Console.Write("Nhập tên sinh viên: ");
            tensv = Console.ReadLine();
            if (Validation.checkRegex(RegexConst.CHARS, tensv))
            {
                sv.Fullname = tensv;
                break;
            }
        }

        while (true)
        {
            Console.Write("Nhập giới tính (true là nam, false là nữ): ");
            gtsv = Console.ReadLine();
            if (Validation.checkRegex(RegexConst.STRING, gtsv))
            {
                sv.Gender = bool.Parse(gtsv);
                break;
            }
        }

        while (true)
        {
            Console.Write("Nhập ngày sinh (yyyy/MM/dd): ");
            dobsv = Console.ReadLine();
            if (Validation.checkRegex(RegexConst.DATE, dobsv))
            {
                sv.Dob = DateTime.Parse(dobsv);
                break;
            }
        }
        list.Add(sv);
    }

    public void UpdateSinhVien(int Id)
    {
        string tensv;
        string gtsv;
        string dobsv;
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        SinhVien sv = FindByID(Id);
        if (sv != null)
        {
            while (true)
            {
                Console.Write("Nhập tên sinh viên: ");
                tensv = Console.ReadLine();
                if (tensv != null && tensv.Length > 0)
                {
                    if (Validation.checkRegex(RegexConst.CHARS, tensv))
                    {
                        sv.Fullname = tensv;
                        break;
                    }
                }
            }


            while (true)
            {
                Console.Write("Nhập giới tính (true là nam, false là nữ): ");
                gtsv = Console.ReadLine();
                if (gtsv != null && gtsv.Length > 0)
                {
                    if (Validation.checkRegex(RegexConst.STRING, gtsv))
                    {
                        sv.Gender = bool.Parse(gtsv);
                        break;
                    }
                }
               
            }

            while (true)
            {
                Console.Write("Nhập ngày sinh (yyyy/MM/dd): ");
                dobsv = Console.ReadLine();
                if (dobsv != null)
                {
                    if (Validation.checkRegex(RegexConst.DATE, dobsv))
                    {
                        sv.Dob = DateTime.Parse(dobsv);
                        break;
                    }
                }
                
            }
        }
        else
        {
            Console.WriteLine("Sinh viên có Id = {0} không tồn tại.", Id);
        }
    }

    public bool DeleteById(int ID)
    {
        bool IsDeleted = false;
        SinhVien sv = FindByID(ID);
        if (sv != null)
        {
            IsDeleted = list.Remove(sv);
        }
        return IsDeleted;
    }

    public List<SinhVien> FindByName(String keyword)
    {
        List<SinhVien> searchResult = new List<SinhVien>();
        if (list != null && list.Count > 0)
        {
            foreach (SinhVien sv in list)
            {
                if (sv.Fullname.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(sv);
                }
            }
        }
        return searchResult;
    }

    public void SortByName()
    {
        list.Sort(delegate (SinhVien sv1, SinhVien sv2) {
            return sv1.Fullname.CompareTo(sv2.Fullname);
        });
    }

    public void ShowSinhVien(List<SinhVien> listSV)
    {
        list.ForEach(Console.WriteLine);
    }

    public SinhVien FindByID(int Id)
    {
        SinhVien searchResult = null;
        if (list != null && list.Count > 0)
        {
            foreach (SinhVien sv in list)
            {
                if (sv.Id == Id)
                {
                    searchResult = sv;
                }
            }
        }
        return searchResult;
    }


    public List<SinhVien> getList()
    {
        return list;
    }
}
