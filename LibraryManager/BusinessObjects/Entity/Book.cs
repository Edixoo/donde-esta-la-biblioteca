using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Entity;

[Table("book")]
public class Book : AEntity
{
    //public int id { get; set; }
    public string Name { get; set; }
    public BookType Type { get; set; } 
    public Author Author { get; set; }
    public int Rate { get; set; }
    

    public enum BookType
    {
        Fantasy,
        ScienceFiction,
        Action,
        Comedie,
        Aventure,
        Policier,
        Drame,
        Histoire,
        Enseignement,
        Juridique
    }
    
}