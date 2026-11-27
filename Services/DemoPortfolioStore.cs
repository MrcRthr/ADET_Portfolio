using Portfolio.Models;

namespace Portfolio.Services;

public class DemoPortfolioStore : IPortfolioStore
{
    private readonly TeamInfo _team = new()
    {
        Name = "GROUP 6",
        Tagline = "lagay kayo dito",
        Course = "BSCS",
        School = "PUP Manila",
        GitHubUrl = ""                                  // EDIT: new repo URL
    };

    // Each member edits ONLY their own entry
    private readonly List<Member> _members =
    [
        new Member
        {
            Id = 1, Slug = "marc", FullName = "Marc Arthur Gabalfin", Role = "Leader",
            AccentColor = "#72d8ec", LabelColor = "#7ff4c3"
        },
        new Member
        {
            Id = 2, Slug = "member2", FullName = "Member 2", Role = "Member",           // EDIT
            AccentColor = "#ff7ad5", LabelColor = "#f47f96"
        },
        new Member
        {
            Id = 3, Slug = "member3", FullName = "Member 3", Role = "Member",           // EDIT
            AccentColor = "#bd75e6", LabelColor = "#bd7ff4"
        }
    ];

    public TeamInfo GetTeam() => _team;
    public IReadOnlyList<Member> GetMembers() => _members.AsReadOnly();
    public Member? FindMemberBySlug(string slug) =>
        _members.FirstOrDefault(m => string.Equals(m.Slug, slug, StringComparison.OrdinalIgnoreCase));
}
