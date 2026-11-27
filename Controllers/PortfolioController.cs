using Microsoft.AspNetCore.Mvc;
using Portfolio.Services;
using Portfolio.ViewModels;

namespace Portfolio.Controllers;

// Each member's page lives in Views/Portfolio/Members/{slug}.cshtml
public class PortfolioController : Controller
{
    private readonly IPortfolioStore _store;

    public PortfolioController(IPortfolioStore store) => _store = store;

    // GET /portfolio/{slug}
    [Route("portfolio/{slug}")]
    public IActionResult Show(string slug)
    {
        var member = _store.FindMemberBySlug(slug);
        if (member is null) return NotFound();

        return View($"~/Views/Portfolio/Members/{member.Slug}.cshtml",
                    new PortfolioPageVm { Member = member });
    }
}
