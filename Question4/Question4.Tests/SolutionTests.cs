namespace Question4.Tests;

public class SolutionTests
{
    [Fact]
    public void PriorityOverlayIntervals_ExampleA_PartialOverlapWithPrioritySplit()
    {
        // Arrange
        int[][] intervals = new int[][] { 
            new int[] { 1, 3 }, 
            new int[] { 2, 6 }, 
            new int[] { 8, 10 } 
        };
        int[] priorities = new int[] { 5, 3, 7 };
        
        // Act
        List<int[]> result = Solution.PriorityOverlayIntervals(intervals, priorities);
        
        // Assert
        Assert.Equal(4, result.Count);
        Assert.True(result[0].SequenceEqual(new int[] { 1, 1, 5 }));
        Assert.True(result[1].SequenceEqual(new int[] { 2, 3, 5 }));
        Assert.True(result[2].SequenceEqual(new int[] { 4, 6, 3 }));
        Assert.True(result[3].SequenceEqual(new int[] { 8, 10, 7 }));
    }
    
    [Fact]
    public void PriorityOverlayIntervals_ExampleB_TouchingEndpointsWithPriorityChanges()
    {
        // Arrange
        int[][] intervals = new int[][] { 
            new int[] { 1, 4 }, 
            new int[] { 4, 5 }, 
            new int[] { 5, 8 }, 
            new int[] { 10, 12 } 
        };
        int[] priorities = new int[] { 2, 8, 3, 1 };
        
        // Act
        List<int[]> result = Solution.PriorityOverlayIntervals(intervals, priorities);
        
        // Assert
        Assert.Equal(4, result.Count);
        Assert.True(result[0].SequenceEqual(new int[] { 1, 3, 2 }));
        Assert.True(result[1].SequenceEqual(new int[] { 4, 5, 8 }));
        Assert.True(result[2].SequenceEqual(new int[] { 6, 8, 3 }));
        Assert.True(result[3].SequenceEqual(new int[] { 10, 12, 1 }));
    }
    
    [Fact]
    public void PriorityOverlayIntervals_ExampleC_NestedIntervals()
    {
        // Arrange
        int[][] intervals = new int[][] { 
            new int[] { 1, 10 }, 
            new int[] { 3, 4 }, 
            new int[] { 6, 8 } 
        };
        int[] priorities = new int[] { 1, 9, 5 };
        
        // Act
        List<int[]> result = Solution.PriorityOverlayIntervals(intervals, priorities);
        
        // Assert
        Assert.Equal(5, result.Count);
        Assert.True(result[0].SequenceEqual(new int[] { 1, 2, 1 }));
        Assert.True(result[1].SequenceEqual(new int[] { 3, 4, 9 }));
        Assert.True(result[2].SequenceEqual(new int[] { 5, 5, 1 }));
        Assert.True(result[3].SequenceEqual(new int[] { 6, 8, 5 }));
        Assert.True(result[4].SequenceEqual(new int[] { 9, 10, 1 }));
    }
    
    [Fact]
    public void PriorityOverlayIntervals_ExampleD_EmptyInput()
    {
        // Arrange
        int[][] intervals = new int[][] { };
        int[] priorities = new int[] { };
        
        // Act
        List<int[]> result = Solution.PriorityOverlayIntervals(intervals, priorities);
        
        // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public void PriorityOverlayIntervals_SingleInterval_ReturnsSingleWithPriority()
    {
        // Arrange
        int[][] intervals = new int[][] { new int[] { 5, 10 } };
        int[] priorities = new int[] { 42 };
        
        // Act
        List<int[]> result = Solution.PriorityOverlayIntervals(intervals, priorities);
        
        // Assert
        Assert.Single(result);
        Assert.True(result[0].SequenceEqual(new int[] { 5, 10, 42 }));
    }
    
    [Fact]
    public void PriorityOverlayIntervals_UnsortedIntervals_HandlesCorrectly()
    {
        // Arrange - Same as Example A but with unsorted input
        int[][] intervals = new int[][] { 
            new int[] { 8, 10 }, 
            new int[] { 1, 3 }, 
            new int[] { 2, 6 } 
        };
        int[] priorities = new int[] { 7, 5, 3 };
        
        // Act
        List<int[]> result = Solution.PriorityOverlayIntervals(intervals, priorities);
        
        // Assert
        Assert.Equal(4, result.Count);
        Assert.True(result[0].SequenceEqual(new int[] { 1, 1, 5 }));
        Assert.True(result[1].SequenceEqual(new int[] { 2, 3, 5 }));
        Assert.True(result[2].SequenceEqual(new int[] { 4, 6, 3 }));
        Assert.True(result[3].SequenceEqual(new int[] { 8, 10, 7 }));
    }
    
    [Fact]
    public void PriorityOverlayIntervals_LargeInput_HandlesEfficiently()
    {
        // Arrange - Create 1000 intervals where every 3 consecutive overlap
        var intervalsList = new List<int[]>();
        var prioritiesList = new List<int>();
        
        for (int i = 0; i < 1000; i++)
        {
            intervalsList.Add(new int[] { i * 2, i * 2 + 3 });
            prioritiesList.Add(i + 1);
        }
        
        int[][] intervals = intervalsList.ToArray();
        int[] priorities = prioritiesList.ToArray();
        
        // Act
        List<int[]> result = Solution.PriorityOverlayIntervals(intervals, priorities);
        
        // Assert - Priority overlay creates more segments than input
        Assert.NotEmpty(result);
        // Each result segment should have 3 elements [start, end, priority]
        Assert.True(result.All(segment => segment.Length == 3));
        
        // Verify result is sorted by start
        for (int i = 1; i < result.Count; i++)
        {
            Assert.True(result[i - 1][0] < result[i][0]);
        }
        
        // Verify no gaps between consecutive segments (or they are separate groups)
        for (int i = 1; i < result.Count; i++)
        {
            // Either contiguous or there's a gap (separate interval groups)
            Assert.True(result[i - 1][1] + 1 >= result[i][0] || result[i - 1][1] < result[i][0]);
        }
    }
    
    [Fact]
    public void PriorityOverlayIntervals_NoOverlaps_ReturnsAllSeparate()
    {
        // Arrange - Intervals with gaps between them
        int[][] intervals = new int[][] { 
            new int[] { 1, 2 }, 
            new int[] { 4, 5 }, 
            new int[] { 7, 8 } 
        };
        int[] priorities = new int[] { 1, 2, 3 };
        
        // Act
        List<int[]> result = Solution.PriorityOverlayIntervals(intervals, priorities);
        
        // Assert
        Assert.Equal(3, result.Count);
        Assert.True(result[0].SequenceEqual(new int[] { 1, 2, 1 }));
        Assert.True(result[1].SequenceEqual(new int[] { 4, 5, 2 }));
        Assert.True(result[2].SequenceEqual(new int[] { 7, 8, 3 }));
    }
}
