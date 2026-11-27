# Group 6 Portfolio

A group portfolio website for Group 6 (BSCS, PUP Manila), built with ASP.NET Core MVC.

## Pages

| Page    | What it shows                                        |
|---------|------------------------------------------------------|
| Home    | Team intro, member cards, and the featured project   |
| Team    | Each member's profile, fun fact, and contributions   |
| Skills  | Languages, frameworks, and tools we use              |
| Contact | A contact form with validation                       |

## Tech stack

- ASP.NET Core MVC (C#)
- Razor views, HTML, CSS, JavaScript
- Git and GitHub

## Project structure

```
Controllers/   Handle requests for each page
Models/        Data classes (Member, Skill, Project, ContactMessage, ...)
ViewModels/    Data passed from controllers to views
Services/      Portfolio and contact data stores
Views/         Razor pages and the shared layout
wwwroot/       CSS, JavaScript, and images
```

## Running locally

Requires the [.NET SDK](https://dotnet.microsoft.com/download).

```bash
git clone https://github.com/MrcRthr/Group6-ADET.git
cd Group6-ADET
dotnet watch
```

The site opens in your browser and reloads when you save changes.

## Members

- Marc Arthur Gabalfin (Leader, Front-end)
- Member 2 (Team page)
- Member 3 (Skills, Contact)
