namespace BilbiotekaMVCmodel.Models;

public class LibraryCard
{
    public int LibraryCardId { get; set; }
    public string CardNumber { get; set; }
    public DateTime ExpiryDate { get; set; }
    public User User { get; set; }
    
   public int UserId { get; set; }  

    public ICollection<Book> CheckedOutBooks { get; set; }
    public ICollection<BookLoan> BookLoans { get; set; }
}