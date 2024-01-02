using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BilbiotekaMVCmodel.Models;
using Microsoft.AspNetCore.Identity;

namespace BilbiotekaMVCmodel.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    // public Author Author { get; set; }
    // public Book Book { get; set; }
    // public BookLoan BookLoan{ get; set; }
    // public User User { get; set; }
    // public LibraryCard LibraryCard { get; set; }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

