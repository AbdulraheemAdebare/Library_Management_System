namespace Library_Management_System.Data.Entities;

public class Book : BaseEntity
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public string ISBN { get; set; }
    public int Copies { get; set; }
    public bool Availability { get; set; }
}