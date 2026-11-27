namespace Portfolio.Models;

// Skill
public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; } = "";         // Name
    public string Category { get; set; } = "";     // Category
    public string UsedFor { get; set; } = "";      // Note text
    public List<int> MemberIds { get; set; } = []; // Members
    public string LabelColor { get; set; } = "#f47f96";
    public int Tilt { get; set; }
}
