# Question 1: Array Sum

## Problem Description

Write a function that calculates the sum of all elements in an integer array.

## Function Signature

```csharp
public static int ArraySum(int[] numbers)
```

## Parameters

- `numbers`: An array of integers

## Return Value

- Returns the sum of all elements in the array
- Returns 0 for an empty array

## Examples

```csharp
ArraySum(new int[] { 1, 2, 3, 4, 5 }) // returns 15
ArraySum(new int[] { -1, 0, 1 }) // returns 0
ArraySum(new int[] { }) // returns 0
ArraySum(new int[] { 100 }) // returns 100
```

## Constraints

- Array length: 0 ≤ length ≤ 10,000
- Element values: -1,000,000 ≤ value ≤ 1,000,000
