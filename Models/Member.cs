namespace Portfolio.Models;

// Member: just enough to list and link each portfolio.
// Put everything else about yourself on your own portfolio page.
public class Member
{
    public int Id { get; set; }
    public string Slug { get; set; } = "";       // URL: /portfolio/{slug}
    public string FullName { get; set; } = "";
    public string Role { get; set; } = "";

    // Colors used on your card and page
    public string AccentColor { get; set; } = "#72d8ec";  // Border
    public string LabelColor { get; set; } = "#7ff4c3";   // Label
}
