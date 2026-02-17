# CodeSignal GCA Simulation

This repository contains a .NET 10 C# project simulating a 4-question CodeSignal General Cognitive Aptitude (GCA) assessment. The test cases are built with xUnit.

## Structure

The repository contains four coding challenges (Question1 through Question4), each with:
- `Solution.cs` - Contains method stubs that need to be implemented
- `README.md` - Problem description and requirements
- `QuestionX.Tests` - xUnit test project with test cases

## Getting Started

### Prerequisites
- .NET 10 SDK or later

### Building the Project
```bash
dotnet build
```

### Running Tests
```bash
dotnet test
```

Note: All tests will fail initially as the solution methods are not implemented.

## How to Use

1. Navigate to any Question folder (e.g., `Question1/`)
2. Read the `README.md` to understand the problem
3. Implement the solution in `Solution.cs`
4. Run `dotnet test` to verify your implementation

## Project Structure
```
codesignal-gca/
├── README.md (this file)
├── Question1/
│   ├── Solution.cs
│   ├── README.md
│   └── Question1.Tests/
├── Question2/
│   ├── Solution.cs
│   ├── README.md
│   └── Question2.Tests/
├── Question3/
│   ├── Solution.cs
│   ├── README.md
│   └── Question3.Tests/
└── Question4/
    ├── Solution.cs
    ├── README.md
    └── Question4.Tests/
```
