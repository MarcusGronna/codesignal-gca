# Question 1: Sum Array

## Problem Description
Write a function that takes an array of integers and returns the sum of all elements in the array.

## Function Signature
```csharp
public int SumArray(int[] numbers)
```

## Parameters
- `numbers`: An array of integers

## Returns
- An integer representing the sum of all elements in the array

## Examples

### Example 1:
**Input:** `[1, 2, 3, 4, 5]`  
**Output:** `15`  
**Explanation:** 1 + 2 + 3 + 4 + 5 = 15

### Example 2:
**Input:** `[10, -5, 3]`  
**Output:** `8`  
**Explanation:** 10 + (-5) + 3 = 8

### Example 3:
**Input:** `[]`  
**Output:** `0`  
**Explanation:** Empty array has sum of 0

## Constraints
- 0 ≤ array length ≤ 1000
- -10^6 ≤ numbers[i] ≤ 10^6
