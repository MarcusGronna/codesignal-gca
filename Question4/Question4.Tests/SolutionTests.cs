namespace Question4.Tests;

public class SolutionTests
{
    [Fact]
    public void MergeIntervalsWithPriority_BasicMerging_ReturnsMergedIntervals()
    {
        // Arrange
        int[][] intervals = new int[][] { 
            new int[] { 1, 3 }, 
            new int[] { 2, 6 }, 
            new int[] { 8, 10 } 
        };
        int[] priorities = new int[] { 5, 3, 7 };
        
        // Act
        List<int[]> result = Solution.MergeIntervalsWithPriority(intervals, priorities);
        
        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal(new int[] { 1, 6, 5 }, result[0]);
        Assert.Equal(new int[] { 8, 10, 7 }, result[1]);
    }
    
    [Fact]
    public void MergeIntervalsWithPriority_MultipleOverlaps_MergesAllOverlapping()
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
        List<int[]> result = Solution.MergeIntervalsWithPriority(intervals, priorities);
        
        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal(new int[] { 1, 8, 8 }, result[0]);
        Assert.Equal(new int[] { 10, 12, 1 }, result[1]);
    }
    
    [Fact]
    public void MergeIntervalsWithPriority_NoOverlaps_ReturnsAllSeparate()
    {
        // Arrange
        int[][] intervals = new int[][] { 
            new int[] { 1, 2 }, 
            new int[] { 3, 4 }, 
            new int[] { 5, 6 } 
        };
        int[] priorities = new int[] { 1, 2, 3 };
        
        // Act
        List<int[]> result = Solution.MergeIntervalsWithPriority(intervals, priorities);
        
        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal(new int[] { 1, 2, 1 }, result[0]);
        Assert.Equal(new int[] { 3, 4, 2 }, result[1]);
        Assert.Equal(new int[] { 5, 6, 3 }, result[2]);
    }
    
    [Fact]
    public void MergeIntervalsWithPriority_EmptyInput_ReturnsEmpty()
    {
        // Arrange
        int[][] intervals = new int[][] { };
        int[] priorities = new int[] { };
        
        // Act
        List<int[]> result = Solution.MergeIntervalsWithPriority(intervals, priorities);
        
        // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public void MergeIntervalsWithPriority_SingleInterval_ReturnsSingleWithPriority()
    {
        // Arrange
        int[][] intervals = new int[][] { new int[] { 5, 10 } };
        int[] priorities = new int[] { 42 };
        
        // Act
        List<int[]> result = Solution.MergeIntervalsWithPriority(intervals, priorities);
        
        // Assert
        Assert.Single(result);
        Assert.Equal(new int[] { 5, 10, 42 }, result[0]);
    }
    
    [Fact]
    public void MergeIntervalsWithPriority_UnsortedIntervals_HandlesCorrectly()
    {
        // Arrange
        int[][] intervals = new int[][] { 
            new int[] { 8, 10 }, 
            new int[] { 1, 3 }, 
            new int[] { 2, 6 } 
        };
        int[] priorities = new int[] { 7, 5, 3 };
        
        // Act
        List<int[]> result = Solution.MergeIntervalsWithPriority(intervals, priorities);
        
        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal(new int[] { 1, 6, 5 }, result[0]);
        Assert.Equal(new int[] { 8, 10, 7 }, result[1]);
    }
    
    [Fact]
    public void MergeIntervalsWithPriority_LargeInput_HandlesEfficiently()
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
        List<int[]> result = Solution.MergeIntervalsWithPriority(intervals, priorities);
        
        // Assert - Should have merged many intervals
        Assert.NotEmpty(result);
        Assert.True(result.Count < intervals.Length);
        
        // Verify result is sorted by start
        for (int i = 1; i < result.Count; i++)
        {
            Assert.True(result[i - 1][0] < result[i][0]);
        }
    }
}
