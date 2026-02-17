# Question 1: Sum of Even Numbers

## Problem Description

Write a function that takes an array of integers and returns the sum of all even numbers in the array.

## Function Signature

```csharp
public int SumOfEvenNumbers(int[] numbers)
```

## Input

- `numbers`: An array of integers (length between 0 and 100)
- Each integer is between -1000 and 1000

## Output

- Returns an integer representing the sum of all even numbers in the array
- If there are no even numbers, return 0

## Examples

### Example 1

**Input:**
```
numbers = [1, 2, 3, 4, 5, 6]
```

**Output:**
```
12
```

**Explanation:** The even numbers are 2, 4, and 6. Their sum is 2 + 4 + 6 = 12

### Example 2

**Input:**
```
numbers = [1, 3, 5, 7]
```

**Output:**
```
0
```

**Explanation:** There are no even numbers in the array, so the sum is 0

## Constraints

- Time complexity should be O(n) where n is the length of the array
- Space complexity should be O(1)
