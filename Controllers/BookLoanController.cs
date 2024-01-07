using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BilbiotekaMVCmodel.Areas.Identity.Data;
using BilbiotekaMVCmodel.Models;
using Microsoft.AspNetCore.Authorization;

namespace BilbiotekaMVCmodel.Controllers
{
    [Authorize]
    public class BookLoanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookLoanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BookLoan
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.BookLoan.Include(b => b.Book).Include(b => b.User);
            return View(await applicationDbContext.ToListAsync());
        }
    

    // GET: BookLoan/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.BookLoan == null)
        {
            return NotFound();
        }

        var bookLoan = await _context.BookLoan
            .Include(b => b.Book)
            .Include(b => b.User)
            .FirstOrDefaultAsync(m => m.BookLoanId == id);
        if (bookLoan == null)
        {
            return NotFound();
        }

        return View(bookLoan);
    }

    // GET: BookLoan/Create
    [Authorize]

    public IActionResult Create()
    {
      
        ViewData["BookId"] = new SelectList(_context.Book, "BookId", "BookId");
        ViewData["UserId"] = new SelectList(_context.Set<User>(), "UserId", "UserId");
        return View();
    }

    // POST: BookLoan/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("BookLoanId,BookId,UserId,RentalStartDate,RentalEndDate")] BookLoan bookLoan)
    {
        if (!ModelState.IsValid)
        {
            ViewData["BookId"] = new SelectList(_context.Book, "BookId", "BookId", bookLoan.BookId);
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "UserId", "UserId", bookLoan.UserId);
           

            return View(bookLoan);
        }
        try
        {
            bookLoan.RentalStarDate = DateTime.Now;
            _context.Add(bookLoan);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);


        }
        return RedirectToAction(nameof(Index));


       
    }
    [Authorize(Roles = "Admin,Manager")]
    // GET: BookLoan/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.BookLoan == null)
        {
            return NotFound();
        }

        var bookLoan = await _context.BookLoan.FindAsync(id);
        if (bookLoan == null)
        {
            return NotFound();
        }

        ViewData["BookId"] = new SelectList(_context.Book, "BookId", "BookId", bookLoan.BookId);
        ViewData["UserId"] = new SelectList(_context.Set<User>(), "UserId", "UserId", bookLoan.UserId);
        return View(bookLoan);
    }

    // POST: BookLoan/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin,Manager")]

    public async Task<IActionResult> Edit(int id,
        [Bind("BookLoanId,BookId,UserId,RentalStartDate,RentalEndDate")] BookLoan bookLoan)
    {
        if (id != bookLoan.BookLoanId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(bookLoan);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookLoanExists(bookLoan.BookLoanId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }

        ViewData["BookId"] = new SelectList(_context.Book, "BookId", "BookId", bookLoan.BookId);
        ViewData["UserId"] = new SelectList(_context.Set<User>(), "UserId", "UserId", bookLoan.UserId);
        return View(bookLoan);
    }

    // GET: BookLoan/Delete/5
    [Authorize(Roles = "Admin")]

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.BookLoan == null)
        {
            return NotFound();
        }

        var bookLoan = await _context.BookLoan
            .Include(b => b.Book)
            .Include(b => b.User)
            .FirstOrDefaultAsync(m => m.BookLoanId == id);

        if (bookLoan == null)
        {
            return NotFound();
        }

        return View(bookLoan);
    }

    // POST: BookLoan/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {

        if (_context.BookLoan == null)
        {
            return Problem("Entity set 'ApplicationDbContext.BookLoan'  is null.");
        }

        // var bookLoan = await _context.BookLoan.FindAsync(id,id2);
        var bookLoan = await _context.BookLoan.FindAsync(id);


        if (bookLoan != null)
        {
            try
            {
                _context.BookLoan.Remove(bookLoan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "BŁAD SSSSSSSSSSSSSSSSSs");

            }

        }

        return NotFound();

    }

    private bool BookLoanExists(int id)
    {
        return (_context.BookLoan?.Any(e => e.BookLoanId == id)).GetValueOrDefault();
    }
}

}


