# Question 4: Merge Overlapping Intervals with Priority

## Problem Description

You are given an array of intervals where each interval is represented as `[start, end]`, and an array of priority values where `priority[i]` corresponds to the priority of `intervals[i]`. 

Your task is to:
1. Merge all overlapping intervals (two intervals overlap if they share at least one point)
2. When merging, keep the **highest priority** among all merged intervals
3. Return a list of non-overlapping intervals sorted by their start position, where each result is `[start, end, priority]`

An interval `[a, b]` overlaps with `[c, d]` if there is at least one point in common. For example:
- `[1, 3]` and `[3, 5]` overlap (they share point 3)
- `[1, 2]` and `[3, 4]` do not overlap
- `[1, 5]` and `[2, 3]` overlap (2 and 3 are common points)

## Function Signature

```csharp
public static List<int[]> MergeIntervalsWithPriority(int[][] intervals, int[] priorities)
```

## Parameters

- `intervals`: A 2D array where each element is `[start, end]` representing an interval
- `priorities`: An array of integers where `priorities[i]` is the priority of `intervals[i]`

## Return Value

- Returns a list of integer arrays, where each array contains `[start, end, priority]`
- The list is sorted by start position
- Non-overlapping intervals are maintained separately
- When intervals are merged, the result contains the merged range and the highest priority

## Examples

### Example 1: Basic Merging
```csharp
int[][] intervals = new int[][] { 
    new int[] { 1, 3 }, 
    new int[] { 2, 6 }, 
    new int[] { 8, 10 } 
};
int[] priorities = new int[] { 5, 3, 7 };

MergeIntervalsWithPriority(intervals, priorities)
// Returns: [[1, 6, 5], [8, 10, 7]]
// Explanation: [1,3] and [2,6] overlap, merged to [1,6] with priority 5 (max of 5 and 3)
```

### Example 2: Multiple Overlaps
```csharp
int[][] intervals = new int[][] { 
    new int[] { 1, 4 }, 
    new int[] { 4, 5 }, 
    new int[] { 5, 8 }, 
    new int[] { 10, 12 } 
};
int[] priorities = new int[] { 2, 8, 3, 1 };

MergeIntervalsWithPriority(intervals, priorities)
// Returns: [[1, 8, 8], [10, 12, 1]]
// Explanation: [1,4], [4,5], and [5,8] all overlap, merged to [1,8] with priority 8
```

### Example 3: No Overlaps
```csharp
int[][] intervals = new int[][] { 
    new int[] { 1, 2 }, 
    new int[] { 3, 4 }, 
    new int[] { 5, 6 } 
};
int[] priorities = new int[] { 1, 2, 3 };

MergeIntervalsWithPriority(intervals, priorities)
// Returns: [[1, 2, 1], [3, 4, 2], [5, 6, 3]]
// Explanation: No intervals overlap, each remains separate with its original priority
```

### Example 4: Empty Input
```csharp
int[][] intervals = new int[][] { };
int[] priorities = new int[] { };

MergeIntervalsWithPriority(intervals, priorities)
// Returns: []
// Explanation: Empty input returns empty result
```

## Constraints

- 0 ≤ intervals.length ≤ 10,000
- intervals.length == priorities.length
- For each interval: 0 ≤ start ≤ end ≤ 1,000,000
- For each priority (when intervals.length > 0): 1 ≤ priority ≤ 1,000,000
- Intervals may be provided in any order
- If input arrays are empty, return an empty list

## Notes

- Two intervals sharing exactly one endpoint (e.g., `[1, 3]` and `[3, 5]`) are considered overlapping
- The algorithm should handle intervals that completely contain other intervals
- Time complexity should be reasonable (aim for O(n log n) where n is the number of intervals)
