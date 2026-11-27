# Group 6 Portfolio

Personal portfolios of Group 6 (BSCS, PUP Manila), built with ASP.NET Core MVC.

## Pages

| Page       | URL                  | What it shows                          |
|------------|----------------------|----------------------------------------|
| Home       | `/`                  | Links to each portfolio  |
| Your page  | `/portfolio/<name>`  | Your personal portfolio  |

## Team workflow

`main` is a blank starting point with no design. Each member builds
their portfolio from scratch on their own branch and merges it into `main` with a pull request.

| Member               | Branch              | Your page |
|----------------------|---------------------|-----------|
| Marc Arthur Gabalfin | `portfolio/marc`    | `Views/Portfolio/Members/marc.cshtml` |
| Member 2             | `portfolio/member2` | `Views/Portfolio/Members/member2.cshtml` |
| Member 3             | `portfolio/member3` | `Views/Portfolio/Members/member3.cshtml` |

Put your own CSS, images and scripts under `wwwroot/` in a folder named after you (e.g. `wwwroot/marc/`), and update your name in `Services/DemoPortfolioStore.cs`. Anything else is shared, so agree with the group before changing it.

## Running locally

Requires the [.NET SDK](https://dotnet.microsoft.com/download).

```bash
git clone <repo-url>
cd <repo-folder>
git switch portfolio/<name>
dotnet watch
```

The site opens in your browser and reloads when you save changes.
