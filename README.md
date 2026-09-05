# Mariane Valerie Añes
**IT Elective 2 – Web System and Technologies | Section BSIT31E1**

## Prefinal Examination – Answer Sheet (MVC App)

This repository contains an ASP.NET Core MVC application built for the IT Elective 2 prefinal examination. Instead of a paper answer sheet, each of the 20 multiple-choice items is rendered as a card in the app, with my chosen answer shaded and a short explanation underneath — the same way an answer sheet would be shaded, just on the web.

No database is used. All 20 questions, choices, and answers live in a single static data file (`Models/QuestionBank.cs`).

## How to run

```bash
dotnet restore
dotnet run
```

Then open the URL shown in the terminal (usually `https://localhost:5001` or `http://localhost:5000`).

## Project structure

| Folder | Contents |
|---|---|
| `Models/Question.cs` | The shape of a single exam item |
| `Models/QuestionBank.cs` | All 20 questions, choices, my answers, and explanations |
| `Controllers/HomeController.cs` | Serves the list view and a details view per item |
| `Views/Home/Index.cshtml` | Shows all 20 items on one page |
| `Views/Home/Details.cshtml` | Shows a single item (`/Home/Details/5`) |
| `Views/Shared/_Layout.cshtml` | Shared page header/footer |
| `wwwroot/css/site.css` | Styling |

## Commit history

Each numbered item was completed and committed individually, so the commit history reflects the exam being worked through item by item, on top of the initial project scaffold.
