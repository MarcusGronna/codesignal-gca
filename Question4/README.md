# Question 4: Find Maximum

## Problem Description
Write a function that finds and returns the maximum value in an array of integers.

## Function Signature
```csharp
public int FindMaximum(int[] numbers)
```

## Parameters
- `numbers`: A non-empty array of integers

## Returns
- An integer representing the maximum value in the array

## Examples

### Example 1:
**Input:** `[1, 5, 3, 9, 2]`  
**Output:** `9`  
**Explanation:** 9 is the largest number in the array

### Example 2:
**Input:** `[-10, -5, -20, -1]`  
**Output:** `-1`  
**Explanation:** -1 is the largest among negative numbers

### Example 3:
**Input:** `[42]`  
**Output:** `42`  
**Explanation:** Single element is the maximum

### Example 4:
**Input:** `[5, 5, 5, 5]`  
**Output:** `5`  
**Explanation:** When all elements are equal, that value is the maximum

## Constraints
- 1 ≤ array length ≤ 1000
- -10^6 ≤ numbers[i] ≤ 10^6
- Array will not be empty
