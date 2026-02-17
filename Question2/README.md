# Question 2: Extract and Reverse Even Numbers

## Problem Description

Write a function that extracts all even numbers from an array, reverses their digits, and returns them as a comma-separated string.

For negative numbers, preserve the negative sign and reverse only the digit portion.

## Function Signature

```csharp
public static string ExtractAndReverseEvens(int[]? numbers)
```

## Parameters

- `numbers`: An array of integers (can be null)

## Return Value

- Returns a comma-separated string of reversed even numbers
- Returns an empty string if there are no even numbers
- Returns an empty string if the array is null or empty
- For negative numbers, the negative sign is preserved and only digits are reversed (e.g., -12 becomes -21)

## Examples

```csharp
ExtractAndReverseEvens(new int[] { 12, 7, 24, 9, 6 }) // returns "21,42,6"
ExtractAndReverseEvens(new int[] { 1, 3, 5 }) // returns ""
```

## Constraints

- Array length: 0 ≤ length ≤ 1,000
- Element values: -10,000 ≤ value ≤ 10,000
