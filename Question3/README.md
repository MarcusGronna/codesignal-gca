# Question 3: Find Maximum in Array

## Problem Description

Write a function that finds and returns the maximum value in an array of integers. If the array is empty, return 0.

## Function Signature

```csharp
public int FindMaximum(int[] numbers)
```

## Input

- `numbers`: An array of integers (length between 0 and 100)
- Each integer is between -1000 and 1000

## Output

- Returns the maximum integer value found in the array
- If the array is empty, return 0

## Examples

### Example 1

**Input:**
```
numbers = [3, 7, 2, 9, 1]
```

**Output:**
```
9
```

**Explanation:** The maximum value in the array is 9.

### Example 2

**Input:**
```
numbers = [-5, -2, -8, -1]
```

**Output:**
```
-1
```

**Explanation:** The maximum value among the negative numbers is -1.

## Constraints

- Time complexity should be O(n) where n is the length of the array
- Space complexity should be O(1)
