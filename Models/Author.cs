using System.ComponentModel.DataAnnotations; 

namespace BilbiotekaMVCmodel.Models;

public class Author
{
    public int AuthorId { get; set; }
    
    [Required(ErrorMessage = "Imię autora jest wymagane.")]
    [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Imie autora może zawierać tylko litery.")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Nazwisko autora jest wymagane.")]
    [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Nazwisko autora może zawierać tylko litery.")]

    public string LastName { get; set; }

    public ICollection<Book> Books { get; set; }
}