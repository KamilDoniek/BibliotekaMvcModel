using System.ComponentModel.DataAnnotations;

namespace BilbiotekaMVCmodel.Models;

public class Book
{
    public int BookId { get; set; }
    [Required(ErrorMessage = "Tytuł jest wymagany.")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "ISBN jest wymagany.")]
    
    [RegularExpression(@"^\d{13}$", ErrorMessage = "ISBN musi mieć 13 cyfr.")]
    public string ISBN { get; set; }
    public int AuthorId { get; set; }

    public Author Author { get; set; }
    public ICollection<BookLoan> BookLoans { get; set; }

}