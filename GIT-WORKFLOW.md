# Git workflow: one branch per portfolio

`main` is the shared base: layout, nav, the Home/Team/Skills/Contact pages and the
portfolio template. Each of us builds our personal portfolio on our own branch and
brings it back into `main` with a pull request (PR).

```
main ──●──────────────────●──────────●──────────●   (shared base)
        \                /          /          /
         ●─●─● portfolio/marc      /          /
          \                       /          /
           ●─●─●─● portfolio/member2         /
            \                               /
             ●─●─● portfolio/member3 ──────/
```

## What belongs to whom

| Files | Owner |
|-------|-------|
| `Views/Portfolio/Members/<you>.cshtml` | you |
| `wwwroot/css/portfolio/<you>.css` | you |
| `wwwroot/images/portfolio/<you>/` | you |
| Your own `new Member { ... }` entry in `Services/DemoPortfolioStore.cs` | you |
| Everything else (layout, `site.css`, controllers, README) | shared, so agree before changing |

Your page is at `http://localhost:xxxx/portfolio/<you>`.

| Member | Branch | Slug |
|--------|--------|------|
| Marc Arthur | `portfolio/marc` | `marc` |
| Member 2 | `portfolio/member2` | `member2` |
| Member 3 | `portfolio/member3` | `member3` |

## 1. Get the project (once)

```bash
git clone https://github.com/MrcRthr/Group6-ADET.git
cd Group6-ADET
git switch portfolio/<you>        # e.g. git switch portfolio/member2
dotnet watch
```

## 2. Daily work on your branch

```bash
git switch portfolio/<you>        # make sure you're on YOUR branch
git status                        # what changed?
git add .                         # stage your changes
git commit -m "Add my projects section"
git push                          # first time: git push -u origin portfolio/<you>
```

Commit small and often. Never commit straight to `main`.

## 3. Keep up with main

When someone else's PR gets merged, pull those changes into your branch:

```bash
git switch main
git pull                          # get the latest main
git switch portfolio/<you>
git merge main                    # bring main into your branch
git push
```

## 4. Open a pull request

1. Push your branch (step 2).
2. On GitHub, click **Compare & pull request** (or **Pull requests → New**).
3. Set **base: `main`** and **compare: `portfolio/<you>`**.
4. Write what you changed, then ask a teammate to review.
5. After approval, click **Merge pull request**.

## 5. The merge-conflict exercise

Each of us works in our own files, so normal work won't conflict. To practise
resolving a conflict, we will all edit the **same line** on purpose:

> In `Services/DemoPortfolioStore.cs`, everyone changes the team `Tagline = "..."`
> line to their own version, commits it on their own branch, and pushes.

Then:

1. **Marc** opens a PR first. It merges cleanly.
2. **Member 2** opens a PR. GitHub now says *"This branch has conflicts that must be resolved"*.
3. Member 2 resolves it locally:

   ```bash
   git switch main
   git pull
   git switch portfolio/member2
   git merge main                  # CONFLICT (content): Merge conflict in Services/DemoPortfolioStore.cs
   ```

   Open the file. Git marks the conflict like this:

   ```
   <<<<<<< HEAD
       Tagline = "Member 2's version",
   =======
       Tagline = "Marc's version",
   >>>>>>> main
   ```

   Keep one version (or combine them), and **delete the `<<<<<<<`, `=======`, `>>>>>>>` lines**. Then:

   ```bash
   git add Services/DemoPortfolioStore.cs
   git commit                      # finishes the merge
   git push                        # the PR updates and the conflict is gone
   ```

   (You can also click **Resolve conflicts** on the PR page and edit it on GitHub.)

4. Merge Member 2's PR. **Member 3** repeats step 3 against the new `main`.

## Handy commands

```bash
git branch -a                     # list all branches
git log --oneline --graph --all   # see the branch tree
git diff                          # see unstaged changes
git merge --abort                 # back out of a merge you started
```
