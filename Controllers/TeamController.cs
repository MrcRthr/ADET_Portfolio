using Microsoft.AspNetCore.Mvc;
using Portfolio.Services;
using Portfolio.ViewModels;

namespace Portfolio.Controllers;

public class TeamController : Controller
{
    private readonly IPortfolioStore _store;

    public TeamController(IPortfolioStore store) => _store = store;

    // GET Team
    public IActionResult Index()
        => View(new TeamPageVm { Members = _store.GetMembers() });

    // GET Details
    public IActionResult Details(int id)
    {
        var member = _store.FindMember(id);
        if (member is null) return NotFound();   // Not found

        // Shared view
        return View("Index", new TeamPageVm { Members = _store.GetMembers(), Selected = member });
    }
}
