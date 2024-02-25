using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Entity;

[Table("author")]
public class Author : AEntity
{
    public string firstName{ get; set; }
    public string lastName{ get; set; }
    public IEnumerable<Book> Books { get; set; }
}