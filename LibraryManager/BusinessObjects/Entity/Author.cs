namespace BusinessObjects.Entity;

public class Author : AEntity
{
    public string firstName{ get; set; }
    public string lastName{ get; set; }
    public IEnumerable<Book> Books { get; set; }
}