using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;
using Portfolio.ViewModels;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly IPortfolioStore _store;

    // Injection
    public HomeController(IPortfolioStore store) => _store = store;

    // GET Home
    public IActionResult Index() => View(new HomePageVm
    {
        Team = _store.GetTeam(),
        Members = _store.GetMembers()
    });

    // Error
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
        => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
