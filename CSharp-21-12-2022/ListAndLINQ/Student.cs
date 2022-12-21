namespace ListAndLINQ;
internal class Student
{
    public int    RollNumber   { get; set; }
    public string Fullname     { get; set; }
    public string Section      { get; set; }
    public int    HostelNumber { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(RollNumber)}={RollNumber.ToString()}, {nameof(Fullname)}={Fullname}, {nameof(Section)}={Section}, {nameof(HostelNumber)}={HostelNumber.ToString()}}}";
    }
}
