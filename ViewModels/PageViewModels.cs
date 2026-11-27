using System.ComponentModel.DataAnnotations;
using Portfolio.Models;

namespace Portfolio.ViewModels;

// Home
public class HomePageVm
{
    public TeamInfo Team { get; set; } = new();
    public IReadOnlyList<Member> Members { get; set; } = [];
    public Project Project { get; set; } = new();
}

// Team
public class TeamPageVm
{
    public IReadOnlyList<Member> Members { get; set; } = [];
    public Member? Selected { get; set; }
}

// Skills
public class SkillsPageVm
{
    public IReadOnlyList<Skill> Skills { get; set; } = [];
    public IReadOnlyList<Member> Members { get; set; } = [];

    public string WhoUsed(Skill skill) =>
        string.Join(", ", Members.Where(m => skill.MemberIds.Contains(m.Id)).Select(m => m.Nickname));
}

// Contact form
public class ContactVm
{
    [Required, StringLength(80)]
    [Display(Name = "Your name")]
    public string Name { get; set; } = "";

    [Required, EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; } = "";

    [Required, StringLength(1000, MinimumLength = 10, ErrorMessage = "Write at least 10 characters.")]
    [Display(Name = "Message")]
    public string Message { get; set; } = "";
}
