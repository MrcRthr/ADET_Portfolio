using Microsoft.AspNetCore.Mvc;
using Portfolio.Services;
using Portfolio.ViewModels;

namespace Portfolio.Controllers;

public class SkillsController : Controller
{
    private readonly IPortfolioStore _store;

    public SkillsController(IPortfolioStore store) => _store = store;

    // GET Skills
    public IActionResult Index() => View(new SkillsPageVm
    {
        Skills = _store.GetSkills(),
        Members = _store.GetMembers()
    });
}
