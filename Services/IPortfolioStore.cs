using Portfolio.Models;

namespace Portfolio.Services;

public interface IPortfolioStore
{
    TeamInfo GetTeam();
    IReadOnlyList<Member> GetMembers();
    Member? FindMemberBySlug(string slug);
}
