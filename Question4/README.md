# Question 4: Find Maximum

## Problem Description

Write a function that finds and returns the maximum value in an integer array.

## Function Signature

```csharp
public static int FindMaximum(int[] numbers)
```

## Parameters

- `numbers`: An array of integers (guaranteed to have at least one element)

## Return Value

- Returns the maximum value found in the array

## Examples

```csharp
FindMaximum(new int[] { 1, 5, 3, 9, 2 }) // returns 9
FindMaximum(new int[] { -10, -5, -20 }) // returns -5
FindMaximum(new int[] { 42 }) // returns 42
FindMaximum(new int[] { 100, 200, 50, 75 }) // returns 200
```

## Constraints

- Array length: 1 ≤ length ≤ 10,000
- Element values: -1,000,000 ≤ value ≤ 1,000,000
- Array is guaranteed to have at least one element
