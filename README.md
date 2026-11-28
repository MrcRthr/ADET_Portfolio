# GABALFIN, SANCHEZ, MANAOG — Portfolio

Personal portfolios of Gabalfin, Sanchez and Manaog (BSCS, PUP Manila), built with ASP.NET Core MVC.

## Pages

| Page       | URL                  | What it shows                          |
|------------|----------------------|----------------------------------------|
| Home       | `/`                  | Links to each portfolio  |
| About      | `/about`             | About the group and project |
| Contact    | `/contact`           | Each member's email      |
| Your page  | `/portfolio/<name>`  | Your personal portfolio  |

## Team workflow

`main` is the shared base: a simple header, footer and home page (`wwwroot/css/site.css`). Each member builds
their portfolio from scratch on their own branch and merges it into `main` with a pull request.

| Member               | Branch              | Your page |
|----------------------|---------------------|-----------|
| Marc Arthur Gabalfin | `portfolio/marc`    | `Views/Portfolio/Members/marc.cshtml` |
| Isabella Nicole Manaog             | `portfolio/member2` | `Views/Portfolio/Members/member2.cshtml` |
| Member 3             | `portfolio/member3` | `Views/Portfolio/Members/member3.cshtml` |

Put your own CSS, images and scripts under `wwwroot/` in a folder named after you (e.g. `wwwroot/marc/`), and update your name and email in `Services/DemoPortfolioStore.cs`. Anything else is shared, so agree with the group before changing it.

## Running locally

Requires the [.NET SDK](https://dotnet.microsoft.com/download).

```bash
git clone <repo-url>
cd <repo-folder>
git switch portfolio/<name>
dotnet watch
```

The site opens in your browser and reloads when you save changes.
