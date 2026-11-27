using Portfolio.Models;

namespace Portfolio.ViewModels;

// Home
public class HomePageVm
{
    public TeamInfo Team { get; set; } = new();
    public IReadOnlyList<Member> Members { get; set; } = [];
}

// Portfolios
public class PortfolioListVm
{
    public IReadOnlyList<Member> Members { get; set; } = [];
}

// One member's personal portfolio
public class PortfolioPageVm
{
    public Member Member { get; set; } = new();
}
