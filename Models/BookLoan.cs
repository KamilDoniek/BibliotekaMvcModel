using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using MessagePack;

namespace BilbiotekaMVCmodel.Models;
public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime date)
        {
            if (date.Date >= DateTime.Now.Date)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ErrorMessage ?? "Date must be in the future.");
            }
        }

        return new ValidationResult("Invalid date type");
    }
    
}
public class BookLoan
{
    public int BookLoanId { get; set; }
    
    [Required(ErrorMessage = "The Book field is required.")]
    public int? BookId { get; set; }
    
    [Required(ErrorMessage = "The User field is required.")]
    public int? UserId { get; set; }
    public DateTime RentalStarDate { get; set; }
    
    [Required(ErrorMessage = "Data rozpoczęcia wypożyczenia jest wymagana.")]
    [FutureDate(ErrorMessage = "Data zakończenia wypożyczenia nie może być wcześniejsza niż dzisiejsza data.")]
    public DateTime RentalEndDate { get; set; }
    
    public Book Book { get; set; }
    public User User { get; set; }
}