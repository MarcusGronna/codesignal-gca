# Question 3: Rotate Grid Border Clockwise

## Problem Description

Write a function that rotates **only the outer border** (the perimeter cells) of a 2D integer matrix clockwise by exactly 1 step, while keeping all inner cells unchanged. Return the new matrix as a result.

The outer border consists of:
- The entire first row
- The entire last row
- The first column (excluding corners already counted)
- The last column (excluding corners already counted)

A clockwise rotation by 1 step means each border element moves to the next position in the clockwise direction:
1. Elements in the top row move one position to the right
2. The top-right corner moves down to the second position of the right column
3. Elements in the right column move one position down
4. The bottom-right corner moves left to the second-to-last position of the bottom row
5. Elements in the bottom row move one position to the left
6. The bottom-left corner moves up to the second-to-last position of the left column
7. Elements in the left column move one position up
8. The top-left corner receives the element from the second position of the left column

## Function Signature

```csharp
public static int[][] RotateBorderClockwise(int[][] grid)
```

## Parameters

- `grid`: A 2D integer array (rectangular, non-null) with height >= 2 and width >= 2

## Return Value

- Returns a new 2D integer array with the outer border rotated clockwise by 1 step
- All inner cells (if any) remain in their original positions
- The original matrix must not be mutated; return a deep copy

## Examples

### Example 1

Input:
```
grid = [
  [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9]
]
```

Output:
```
[
  [4, 1, 2],
  [7, 5, 3],
  [8, 9, 6]
]
```

Explanation:
- Border elements before: 1,2,3,6,9,8,7,4 (clockwise from top-left)
- Border elements after rotation: 4,1,2,3,6,9,8,7 (each moved one position clockwise)
- Center element 5 remains unchanged

### Example 2

Input:
```
grid = [
  [1,  2,  3,  4],
  [5,  6,  7,  8],
  [9, 10, 11, 12]
]
```

Output:
```
[
  [5,  1,  2,  3],
  [9,  6,  7,  4],
  [10, 11, 12, 8]
]
```

Explanation:
- Border elements before: 1,2,3,4,8,12,11,10,9,5 (clockwise from top-left)
- Border elements after rotation: 5,1,2,3,4,8,12,11,10,9 (each moved one position clockwise)
- Inner elements 6 and 7 remain unchanged

## Constraints

- 2 <= height <= 100
- 2 <= width <= 100
- -10^9 <= grid[i][j] <= 10^9

## Notes

- The function must preserve the rectangular shape of the matrix
- Return a deep copy; do not modify the original input matrix
- For a 2x2 matrix, all four elements are on the border (no inner cells)
