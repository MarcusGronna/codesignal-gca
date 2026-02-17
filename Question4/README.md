# Question 4: Priority Overlay Intervals

## Problem Description

You are given intervals `intervals[i] = [start, end]` (inclusive) and `priorities[i]`.

For every point x, its priority is the **maximum priority** among all intervals that contain x.

Return a list of **NON-OVERLAPPING**, inclusive intervals of the form `[start, end, priority]` representing the piecewise-constant priority function.

The output must be:
- Sorted by start position
- Cover exactly the union of all input intervals
- Adjacent intervals must **NOT** be merged unless they have the same priority and are contiguous (end+1 == nextStart)

**Overlap rule**: Inclusive endpoints; `[1, 3]` and `[3, 5]` both include point 3.

## Function Signature

```csharp
public static List<int[]> PriorityOverlayIntervals(int[][] intervals, int[] priorities)
```

## Parameters

- `intervals`: A 2D array where each element is `[start, end]` representing an inclusive interval
- `priorities`: An array of integers where `priorities[i]` is the priority of `intervals[i]`

## Return Value

- Returns a list of integer arrays, where each array contains `[start, end, priority]`
- The list is sorted by start position
- Intervals represent the piecewise-constant priority function over the union of all input intervals
- At any point x, the returned priority is the maximum among all input intervals containing x

## Examples

### Example A: Partial Overlap with Priority Split
```csharp
int[][] intervals = new int[][] { 
    new int[] { 1, 3 }, 
    new int[] { 2, 6 }, 
    new int[] { 8, 10 } 
};
int[] priorities = new int[] { 5, 3, 7 };

PriorityOverlayIntervals(intervals, priorities)
// Returns: [[1, 1, 5], [2, 3, 5], [4, 6, 3], [8, 10, 7]]
// Explanation:
// - Point 1: only in [1,3], priority 5
// - Points 2-3: in both [1,3] and [2,6], max priority is 5
// - Points 4-6: only in [2,6], priority 3
// - Points 8-10: only in [8,10], priority 7
```

### Example B: Touching Endpoints with Priority Changes
```csharp
int[][] intervals = new int[][] { 
    new int[] { 1, 4 }, 
    new int[] { 4, 5 }, 
    new int[] { 5, 8 }, 
    new int[] { 10, 12 } 
};
int[] priorities = new int[] { 2, 8, 3, 1 };

PriorityOverlayIntervals(intervals, priorities)
// Returns: [[1, 3, 2], [4, 5, 8], [6, 8, 3], [10, 12, 1]]
// Explanation:
// - Points 1-3: only in [1,4], priority 2
// - Point 4: in both [1,4] and [4,5], max priority is 8
// - Point 5: in both [4,5] and [5,8], max priority is 8
// - Points 6-8: only in [5,8], priority 3
// - Points 10-12: only in [10,12], priority 1
```

### Example C: Nested Intervals
```csharp
int[][] intervals = new int[][] { 
    new int[] { 1, 10 }, 
    new int[] { 3, 4 }, 
    new int[] { 6, 8 } 
};
int[] priorities = new int[] { 1, 9, 5 };

PriorityOverlayIntervals(intervals, priorities)
// Returns: [[1, 2, 1], [3, 4, 9], [5, 5, 1], [6, 8, 5], [9, 10, 1]]
// Explanation:
// - Points 1-2: only in [1,10], priority 1
// - Points 3-4: in [1,10] and [3,4], max priority is 9
// - Point 5: only in [1,10], priority 1
// - Points 6-8: in [1,10] and [6,8], max priority is 5
// - Points 9-10: only in [1,10], priority 1
```

### Example D: Empty Input
```csharp
int[][] intervals = new int[][] { };
int[] priorities = new int[] { };

PriorityOverlayIntervals(intervals, priorities)
// Returns: []
// Explanation: Empty input returns empty result
```

## Constraints

- 0 ≤ n ≤ 10,000 (where n is the number of intervals)
- intervals.length == priorities.length
- For each interval: 0 ≤ start ≤ end ≤ 1,000,000
- For each priority (when the intervals array is not empty): 1 ≤ priority ≤ 1,000,000
- Intervals may be provided in any order
- If input arrays are empty, return an empty list

## Time Complexity

- The solution should have time complexity of approximately **O(n log n)** where n is the number of intervals
- This can be achieved by sorting intervals and using efficient merging techniques

## Notes

- Two intervals sharing exactly one endpoint (e.g., `[1, 3]` and `[3, 5]`) are both considered to contain that point
- The algorithm must handle intervals that completely contain other intervals
- The output intervals must represent the piecewise-constant priority function over the union
- Adjacent output intervals with the same priority and contiguous ranges should be merged (e.g., `[1, 3, 5]` and `[4, 6, 5]` should be merged to `[1, 6, 5]`)
- The problem is more complex than simple interval merging: it requires splitting and segmentation based on priority changes
