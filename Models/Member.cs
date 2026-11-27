namespace Portfolio.Models;

// Member
public class Member
{
    public int Id { get; set; }
    public string Slug { get; set; } = "";       // URL: /portfolio/{slug}

    public string FullName { get; set; } = "";   // Full name
    public string CardName { get; set; } = "";   // Card label
    public string Nickname { get; set; } = "";   // Nickname
    public string Role { get; set; } = "";       // Role
    public string Tagline { get; set; } = "";    // Tagline
    public string Course { get; set; } = "BSCS";
    public string FunFact { get; set; } = "";
    public string Email { get; set; } = "";
    public string GitHubUrl { get; set; } = "";  // Optional
    public List<string> Contributions { get; set; } = [];  // Contributions

    // Card style
    public string AccentColor { get; set; } = "#72d8ec";  // Border
    public string LabelColor { get; set; } = "#7ff4c3";   // Label
    public int Tilt { get; set; }                         // Rotation
    public string InfoSide { get; set; } = "left";        // Side

    // Images
    public string CardImage { get; set; } = "";
    public string ProfileImage { get; set; } = "";
    public string StickerImage { get; set; } = "";
    public string BoxImage { get; set; } = "";     // Team page box (optional)
    public string PropImage { get; set; } = "";    // Optional
    public string PropName { get; set; } = "";     // Prop class
    public bool PropSpins { get; set; }

    public string BoxPhoto => string.IsNullOrWhiteSpace(BoxImage) ? CardImage : BoxImage;
    public bool HasProp => !string.IsNullOrWhiteSpace(PropImage);
}
