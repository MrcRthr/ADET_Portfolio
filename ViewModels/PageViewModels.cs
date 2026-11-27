using Portfolio.Models;

namespace Portfolio.ViewModels;

// Home
public class HomePageVm
{
    public IReadOnlyList<Member> Members { get; set; } = [];
}

// One member's portfolio
public class PortfolioPageVm
{
    public Member Member { get; set; } = new();
}
