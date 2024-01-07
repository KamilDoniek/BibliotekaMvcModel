using System.ComponentModel.DataAnnotations;

namespace BilbiotekaMVCmodel.Models;

public class LibraryCard
{
    public int LibraryCardId { get; set; }
    [Required(ErrorMessage = "Numer karty bibliotecznej jest wymagany.")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Numer karty musi zawierać dokładnie 10 cyfr.")]
    public string CardNumber { get; set; }
    public DateTime ExpiryDate { get; set; }
    public User User { get; set; }
    
   public int UserId { get; set; }  

    public ICollection<Book> CheckedOutBooks { get; set; }
    public ICollection<BookLoan> BookLoans { get; set; }
}