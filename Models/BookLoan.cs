namespace BilbiotekaMVCmodel.Models;

public class BookLoan
{
    public int BookLoanId { get; set; }
    public int BookId { get; set; }
    public int UserId { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime DueDate { get; set; }
    
    public Book Book { get; set; }
    public User User { get; set; }
}