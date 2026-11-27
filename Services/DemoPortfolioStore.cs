using Portfolio.Models;

namespace Portfolio.Services;

public class DemoPortfolioStore : IPortfolioStore
{
    private readonly TeamInfo _team = new()
    {
        Name = "GROUP 6",                                   // EDIT
        Tagline = "Three BSCS students from PUP Manila building for the web, one commit at a time.",
        Course = "BSCS",
        School = "PUP Manila",
        Email = "group@example.com",                           // EDIT
        GitHubUrl = "https://github.com/MrcRthr/Group6-ADET"
    };

    private readonly List<Member> _members =
    [
        new Member
        {
            Id = 1, FullName = "Marc Arthur Gabalfin", CardName = "MARC ARTHUR", Nickname = "Art",
            Role = "Leader · Front-end", Tagline = "Pixel-pusher and popcorn enthusiast.",
            FunFact = "Can't write a single line of CSS without snacks nearby.",
            Email = "marcgabalfin@gmail.com",
            GitHubUrl = "https://github.com/MrcRthr",
            Contributions =
            [
                "Set up the ASP.NET Core MVC project and GitHub repository",
                "Built the Home page and shared site layout",
                "Designed the navigation, footer, and overall styling",
                "Wrote the project README"
            ],
            AccentColor = "#72d8ec", LabelColor = "#7ff4c3", Tilt = 10, InfoSide = "left",
            CardImage = "~/images/team/art-card.jpeg", ProfileImage = "~/images/team/art-profile.jpeg",
            StickerImage = "~/images/team/art-sticker.png",
            PropImage = "~/images/props/popcorn.png", PropName = "popcorn"
        },
        new Member
        {
            Id = 2, FullName = "Member 2", CardName = "MEMBER TWO", Nickname = "Two",   // EDIT
            Role = "Team page", Tagline = "lagay kayo dito",                                // EDIT
            FunFact = "lagay kayo dito",                                           // EDIT
            Email = "member2@example.com",                                                // EDIT
            Contributions =
            [
                "lagay kayo dito"
            ],
            AccentColor = "#ff7ad5", LabelColor = "#f47f96", Tilt = -9, InfoSide = "bottom",
            CardImage = "~/images/team/member-2.png", ProfileImage = "~/images/team/member-2.png",
            StickerImage = "~/images/team/member-2.png"
        },
        new Member
        {
            Id = 3, FullName = "Member 3", CardName = "MEMBER THREE", Nickname = "Three", // EDIT
            Role = "Skills · Contact", Tagline = "lagay kayo dito",                           // EDIT
            FunFact = "lagay kayo dito",                                             // EDIT
            Email = "member3@example.com",                                                  // EDIT
            Contributions =
            [
                "lagay kayo dito"
            ],
            AccentColor = "#bd75e6", LabelColor = "#bd7ff4", Tilt = 8, InfoSide = "right",
            CardImage = "~/images/team/member-3.png", ProfileImage = "~/images/team/member-3.png",
            StickerImage = "~/images/team/member-3.png"
        }
    ];

    private readonly Project _project = new()
    {
        Title = "KAMSAHAMNIDA!",
        Summary = "lagay kayo dito",
        Year = 2026,
        TechStack = ["HTML", "CSS", "JavaScript", "C#", "ASP.NET Core MVC"],
        RepoUrl = "",                                            // EDIT
        Credits = "Designed & developed by Group 6",
        Shots =
        [
            new ProjectShot
            {
                Title = "HETO NA SILA!", LabelColor = "#f47f96", Tilt = -7,
                Caption = "lagay kayo dito",
                Image = "~/images/project/shot-1.png", ImageAlt = "Member cards page of the KAMSAHAMNIDA site"
            },
            new ProjectShot
            {
                Title = "SINO BA KAMI?", LabelColor = "#bd7ff4", Tilt = 4,
                Caption = "lagay kayo dito",
                Image = "~/images/project/shot-2.png", ImageAlt = "Profiles page of the KAMSAHAMNIDA site"
            },
            new ProjectShot
            {
                Title = "ANO, TARA?", LabelColor = "#92f47f", Tilt = 10,
                Caption = "lagay kayo dito",
                Image = "~/images/project/shot-3.png", ImageAlt = "Gala memories page of the KAMSAHAMNIDA site"
            },
            new ProjectShot
            {
                Title = "STICKERS", LabelColor = "#f4d97f", Tilt = -5,
                Caption = "lagay kayo dito",
                Image = "~/images/project/shot-4.png", ImageAlt = "Sticker gallery of the KAMSAHAMNIDA site"
            }
        ]
    };

    private readonly List<Skill> _skills =
    [
        new Skill { Id = 1, Name = "HTML", Category = "Language", LabelColor = "#f49c7f", Tilt = -6, MemberIds = [1, 2, 3],
            UsedFor = "lagay kayo dito" },
        new Skill { Id = 2, Name = "CSS", Category = "Language", LabelColor = "#72d8ec", Tilt = 5, MemberIds = [1, 2, 3],
            UsedFor = "lagay kayo dito" },
        new Skill { Id = 3, Name = "C#", Category = "Language", LabelColor = "#bd7ff4", Tilt = -3, MemberIds = [1, 2, 3],
            UsedFor = "lagay kayo dito" },
        new Skill { Id = 4, Name = "JavaScript", Category = "Language", LabelColor = "#f4d97f", Tilt = 8, MemberIds = [1, 2, 3],
            UsedFor = "lagay kayo dito" },
        new Skill { Id = 5, Name = "ASP.NET Core MVC", Category = "Framework", LabelColor = "#92f47f", Tilt = -8, MemberIds = [1, 2, 3],
            UsedFor = "lagay kayo dito" },
        new Skill { Id = 6, Name = "Uhm", Category = "Uhm", LabelColor = "#f47f96", Tilt = 4, MemberIds = [1, 2, 3],
            UsedFor = "lagay kayo dito" },
        new Skill { Id = 7, Name = "Git", Category = "Tool", LabelColor = "#f34b4b", Tilt = 7, MemberIds = [1, 2, 3],
            UsedFor = "lagay kayo dito" },
        new Skill { Id = 8, Name = "GitHub", Category = "Tool", LabelColor = "#a9adad", Tilt = -4, MemberIds = [1, 2, 3],
            UsedFor = "lagay kayo dito" },
        new Skill { Id = 9, Name = "VS Code", Category = "Tool", LabelColor = "#7fb8f4", Tilt = 3, MemberIds = [1, 2, 3],
            UsedFor = "lagay kayo dito" }
    ];

    public TeamInfo GetTeam() => _team;
    public IReadOnlyList<Member> GetMembers() => _members.AsReadOnly();
    public Member? FindMember(int id) => _members.FirstOrDefault(m => m.Id == id);
    public Project GetFeaturedProject() => _project;
    public IReadOnlyList<Skill> GetSkills() => _skills.AsReadOnly();
}
