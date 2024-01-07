using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BilbiotekaMVCmodel.Models;

public class User 
{
    public int UserId { get; set; }
    [Required(ErrorMessage = "Imię użytkownika jest wymagane.")]

    public string FirstName { get; set; }
    [Required(ErrorMessage = "Nazwisko użytkownika jest wymagane.")]

    public string LastName { get; set; }
    [Required(ErrorMessage = "Adres email użytkownika jest wymagany.")]
    [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu email.")]
    public string Email { get; set; }
   
        
    public LibraryCard LibraryCard { get; set; }
    public ICollection<BookLoan> BookLoans { get; set; }
}
