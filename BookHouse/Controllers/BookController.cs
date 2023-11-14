using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BookHouse.Models; // Add the namespace for your ViewModel
using BookHouse.Data;

[Authorize] // Ensure the user is logged in to access these actions
public class BookController : Controller
{
    private readonly BookHouseDbContext _context;

    public BookController(BookHouseDbContext context)
    {
        _context = context;
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [HttpPost]
    public IActionResult Create(Book model)
    {
        if (ModelState.IsValid)
        {
            _context.Books.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        return View(model);
    }
}
