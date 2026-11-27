namespace Portfolio.Models;

public class Member
{
    public int Id { get; set; }
    public string Slug { get; set; } = "";       // URL: /portfolio/{slug}
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
}
