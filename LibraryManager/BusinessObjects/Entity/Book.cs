namespace BusinessObjects.Entity;

public class Book
{
    public int id { get; set; }
    public string Title { get; set; }
    public BookType Type { get; set; } 
    public int AuthorId { get; set; }
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