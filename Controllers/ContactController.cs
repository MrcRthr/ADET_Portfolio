using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;
using Portfolio.ViewModels;

namespace Portfolio.Controllers;

public class ContactController : Controller
{
    private readonly IContactStore _messages;
    private readonly IPortfolioStore _store;

    public ContactController(IContactStore messages, IPortfolioStore store)
    {
        _messages = messages;
        _store = store;
    }

    // GET Contact
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.Members = _store.GetMembers();
        return View(new ContactVm());
    }

    // POST Contact
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(ContactVm input)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Members = _store.GetMembers();
            return View(input);   // Invalid
        }

        _messages.Add(new ContactMessage
        {
            Name = input.Name,
            Email = input.Email,
            Message = input.Message
        });

        TempData["SentBy"] = input.Name;   // TempData
        return RedirectToAction(nameof(Index));
    }
}
