# HAN ASD ADP
This project contains algorithm implementations with unit tests and benchmarks for those. 

In the `Program.cs` the benchmarks you do and don't want to run can be added or removed from the list of `Setup`s. 

Benchmark results can be found in the root of this repository in the `./BenchmarkResults` folder. For viewing on GitHub we recommend to open the `*.md` files, for opening on a e.g. a laptop the `*.html` might be easier.

## Codespaces
This project is supported by GitHub Codespaces. To run build the project or unit tests, run the following commands in the terminal once Codespaces is done initializing:

| Command        | Description                                                        |
| -------------- | ------------------------------------------------------------------ |
| `cd src/`      | Changes directory to the source folder where the *.sln is located. |
| `dotnet build` | Builds the project.                                                |
| `dotnet test`  | Runs the tests in the repository.                                  |
