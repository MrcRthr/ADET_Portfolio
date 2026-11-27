namespace Portfolio.Models;

// Project
public class Project
{
    public string Title { get; set; } = "";
    public string Summary { get; set; } = "";
    public int Year { get; set; }
    public List<string> TechStack { get; set; } = [];
    public string RepoUrl { get; set; } = "";   // Optional
    public string Credits { get; set; } = "";
    public List<ProjectShot> Shots { get; set; } = [];
}

// Screenshot
public class ProjectShot
{
    public string Title { get; set; } = "";
    public string Caption { get; set; } = "";
    public string Image { get; set; } = "";
    public string ImageAlt { get; set; } = "";
    public string LabelColor { get; set; } = "#f47f96";
    public int Tilt { get; set; }
}
