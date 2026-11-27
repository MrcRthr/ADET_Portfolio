using Portfolio.Models;

namespace Portfolio.Services;

public interface IPortfolioStore
{
    TeamInfo GetTeam();
    IReadOnlyList<Member> GetMembers();
    Member? FindMember(int id);
    Project GetFeaturedProject();
    IReadOnlyList<Skill> GetSkills();
}
