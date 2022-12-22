


using Microsoft.VisualBasic;

namespace HomeWork;
internal class SinhVien
{
    public int Id { get; set; }
    public string Fullname { get; set; }
    public bool Gender { get; set; }
    public DateTime Dob { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Id)} = {Id.ToString()}, {nameof(Fullname)} = {Fullname}, {nameof(Gender)} = {(Gender ? "Nam" : "Nữ")}, {nameof(Dob)} = {Dob.ToString("dd/MM/yyyy")}}}";
    }
}
