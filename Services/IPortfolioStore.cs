using Portfolio.Models;

namespace Portfolio.Services;

public interface IPortfolioStore
{
    IReadOnlyList<Member> GetMembers();
    Member? FindMemberBySlug(string slug);
}
