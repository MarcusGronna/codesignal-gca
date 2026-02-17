# CodeSignal GCA Simulation

This repository simulates the **CodeSignal General Coding Assessment (GCA)** format, providing a realistic practice environment for technical interview preparation. The assessment consists of four progressively challenging coding problems implemented in .NET 10 C#, with comprehensive test suites built using xUnit.

The GCA format is designed to evaluate fundamental programming skills, problem-solving abilities, and algorithmic thinking under time constraints. Each question in this simulation mirrors the structure and difficulty progression of actual CodeSignal assessments.

## Question Overview

This assessment contains four questions with increasing difficulty levels:

### Question 1: Array Sum
**Difficulty:** Easy  
**Time Estimate:** 5-10 minutes  
**Focus:** Basic iteration and array manipulation  
**Skills Evaluated:**
- Understanding of array traversal
- Basic arithmetic operations
- Handling edge cases (empty arrays)
- Writing clean, readable code

**Problem:** Calculate the sum of all elements in an integer array.

---

### Question 2: Extract and Reverse Even Numbers
**Difficulty:** Medium  
**Time Estimate:** 15-20 minutes  
**Focus:** Array filtering, string manipulation, and edge case handling  
**Skills Evaluated:**
- Filtering data based on conditions (even numbers)
- String formatting and manipulation
- Handling null/empty inputs
- Number reversal with special cases (negative numbers)
- Combining multiple operations in a single solution

**Problem:** Extract even numbers from an array, reverse their digits, and return as a comma-separated string.

---

### Question 3: Character Frequency by Position
**Difficulty:** Medium-Hard  
**Time Estimate:** 20-25 minutes  
**Focus:** String analysis, data structures (dictionaries), and algorithmic reasoning  
**Skills Evaluated:**
- Working with dictionaries/hash maps
- String indexing and character analysis
- Frequency counting algorithms
- Multiple-pass algorithms (scanning for digits, counting frequencies)
- Understanding of complex return value structures

**Problem:** Analyze a string and create a dictionary mapping digit positions to their frequency counts across the entire string.

---

### Question 4: Merge Overlapping Intervals with Priority
**Difficulty:** Hard  
**Time Estimate:** 30-35 minutes  
**Focus:** Advanced algorithmic reasoning, interval merging, and optimization  
**Skills Evaluated:**
- Interval overlap detection and merging
- Sorting and comparison operations
- Tracking metadata during merges (priorities)
- Efficient algorithm design (O(n log n) complexity)
- Handling complex edge cases (touching intervals, contained intervals, empty inputs)
- Working with multi-dimensional data structures

**Problem:** Merge overlapping intervals while preserving the highest priority value from merged intervals.

---

## For Candidates: Getting Started

### Prerequisites
- .NET 10 SDK or later ([Download here](https://dotnet.microsoft.com/download))

### How to Complete This Assessment

1. **Understand the Problem**
   - Navigate to a question folder (e.g., `Question1/`, `Question2/`, etc.)
   - Read the `README.md` file carefully to understand the problem requirements
   - Review the examples and constraints

2. **Write Your Solution**
   - Open the `Solution.cs` file in the question folder
   - Each file contains a method stub that throws `NotImplementedException`
   - **All methods are currently unimplemented** - you must complete them
   - Replace the `throw new NotImplementedException();` line with your solution code
   - Do not modify the method signature or class structure

3. **Test Your Solution**
   - Run tests for a specific question:
     ```bash
     cd Question1
     dotnet test
     ```
   - Or run all tests from the root directory:
     ```bash
     dotnet test
     ```
   - Tests will fail initially because methods are unimplemented
   - Continue refining your solution until all tests pass

4. **Build the Project** (optional)
   ```bash
   dotnet build
   ```

### Important Notes
- ⚠️ **All solution methods currently throw `NotImplementedException`** - you must implement them
- ✅ Each question has multiple test cases covering various scenarios and edge cases
- 📝 Follow the constraints specified in each question's README
- ⏱️ Time estimates are guidelines based on GCA format expectations
- 🎯 Focus on correctness first, then optimize if needed

## Project Structure
```
codesignal-gca/
├── README.md                    # This file
├── CodeSignalGCA.slnx          # Solution file
├── Question1/                   # Easy - Array Sum
│   ├── Solution.cs             # ⚠️ Implement your solution here
│   ├── README.md               # Problem description
│   ├── Question1.csproj
│   └── Question1.Tests/        # xUnit test cases
│       ├── SolutionTests.cs
│       └── Question1.Tests.csproj
├── Question2/                   # Medium - Extract and Reverse Even Numbers
│   ├── Solution.cs             # ⚠️ Implement your solution here
│   ├── README.md
│   ├── Question2.csproj
│   └── Question2.Tests/
├── Question3/                   # Medium-Hard - Character Frequency by Position
│   ├── Solution.cs             # ⚠️ Implement your solution here
│   ├── README.md
│   ├── Question3.csproj
│   └── Question3.Tests/
└── Question4/                   # Hard - Merge Overlapping Intervals
    ├── Solution.cs             # ⚠️ Implement your solution here
    ├── README.md
    ├── Question4.csproj
    └── Question4.Tests/
```

## Tips for Success
- Start with Question 1 and progress sequentially
- Read all requirements carefully, including constraints
- Test your solution frequently as you develop
- Pay attention to edge cases (null inputs, empty arrays, boundary values)
- Manage your time effectively - don't spend too long on any single question
- If stuck, move to the next question and return later if time permits
