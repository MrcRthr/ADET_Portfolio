# Group 6 Portfolio

Personal portfolios of Group 6 (BSCS, PUP Manila), built with ASP.NET Core MVC.

## Pages

| Page       | URL                  | What it shows                          |
|------------|----------------------|----------------------------------------|
| Home       | `/`                  | Group intro and links to each portfolio |
| Portfolios | `/portfolio`         | A card for each member                 |
| Your page  | `/portfolio/<name>`  | Your personal portfolio                |

## Team workflow

`main` is the shared base: layout, nav, footer and styling. Each member builds
their portfolio on their own branch and merges it into `main` with a pull request.

| Member               | Branch              | Your files |
|----------------------|---------------------|------------|
| Marc Arthur Gabalfin | `portfolio/marc`    | `Views/Portfolio/Members/marc.cshtml`, `wwwroot/css/portfolio/marc.css`, `wwwroot/images/portfolio/marc/` |
| Member 2             | `portfolio/member2` | `Views/Portfolio/Members/member2.cshtml`, `wwwroot/css/portfolio/member2.css`, `wwwroot/images/portfolio/member2/` |
| Member 3             | `portfolio/member3` | `Views/Portfolio/Members/member3.cshtml`, `wwwroot/css/portfolio/member3.css`, `wwwroot/images/portfolio/member3/` |

Also update your own entry in `Services/DemoPortfolioStore.cs`. Anything else is shared, so agree with the group before changing it.

## Running locally

Requires the [.NET SDK](https://dotnet.microsoft.com/download).

```bash
git clone <repo-url>
cd <repo-folder>
git switch portfolio/<name>
dotnet watch
```

The site opens in your browser and reloads when you save changes.
