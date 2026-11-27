using Microsoft.AspNetCore.Mvc;
using Portfolio.Services;
using Portfolio.ViewModels;

namespace Portfolio.Controllers;

// Personal portfolios.
// Shared base: this controller, Views/Portfolio/Index.cshtml, css/portfolio.css.
// Each member owns ONLY their own files:
//   Views/Portfolio/Members/{slug}.cshtml
//   wwwroot/css/portfolio/{slug}.css
//   wwwroot/images/portfolio/{slug}/
public class PortfolioController : Controller
{
    private readonly IPortfolioStore _store;

    public PortfolioController(IPortfolioStore store) => _store = store;

    // GET /portfolio
    [Route("portfolio")]
    public IActionResult Index()
        => View(new PortfolioListVm { Members = _store.GetMembers() });

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
