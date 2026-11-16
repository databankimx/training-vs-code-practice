# VS Code training practice

This repository is the practice project for the Working With Visual Studio Code course. You will edit its files, run its tests, use Git on it, and open pull requests on it. It is yours to change, so break it on purpose when a lesson asks you to.

The same small calculator is written three ways, so that you can follow the course in whichever language you know:

- `calculator.py` and `test_calculator.py`: Python, with the standard unittest module.
- `totals.js`: JavaScript.
- `csharp/`: C#, a class library and an xUnit test project.

The lessons tell you which file to open and what to change. You do not need to know all three languages to complete the course.

## Running the tests

Python, from this folder:

    python -m unittest

C#, from the `csharp` folder, with the .NET SDK installed:

    dotnet test Calculator.Tests

One Python test is meant to fail. The course uses it to show how the Testing view reports a failure.

## Notes

- The `.vscode` folder holds the course's recommended extensions. It is part of the project, so it stays in source control.
- Build output and Python caches are ignored by `.gitignore`.
