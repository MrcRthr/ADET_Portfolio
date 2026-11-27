using Portfolio.Models;

namespace Portfolio.Services;

public class DemoPortfolioStore : IPortfolioStore
{
    private readonly List<Member> _members =
    [
        new Member { Id = 1, Slug = "marc",    FullName = "Marc Arthur Gabalfin", Email = "marc@example.com" },
        new Member { Id = 2, Slug = "member2", FullName = "Isabella Nicole Manaog", Email = "manaognicole83@gmail.com" },
        new Member { Id = 3, Slug = "member3", FullName = "Member 3",             Email = "member3@example.com" }
    ];

    public IReadOnlyList<Member> GetMembers() => _members.AsReadOnly();
    public Member? FindMemberBySlug(string slug) =>
        _members.FirstOrDefault(m => string.Equals(m.Slug, slug, StringComparison.OrdinalIgnoreCase));
}
