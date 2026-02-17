namespace Question3.Tests;

public class SolutionTests
{
    // Helper method for deep equality comparison of 2D arrays
    private void AssertMatricesEqual(int[][] expected, int[][] actual)
    {
        Assert.NotNull(actual);
        Assert.Equal(expected.Length, actual.Length);
        
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.NotNull(actual[i]);
            Assert.Equal(expected[i].Length, actual[i].Length);
            
            for (int j = 0; j < expected[i].Length; j++)
            {
                Assert.Equal(expected[i][j], actual[i][j]);
            }
        }
    }
    
    [Fact]
    public void RotateBorderClockwise_Example1_3x3Grid()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        
        int[][] expected = new int[][]
        {
            new int[] { 4, 1, 2 },
            new int[] { 7, 5, 3 },
            new int[] { 8, 9, 6 }
        };
        
        // Act
        var result = Solution.RotateBorderClockwise(grid);
        
        // Assert
        AssertMatricesEqual(expected, result);
    }
    
    [Fact]
    public void RotateBorderClockwise_Example2_3x4Grid()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6, 7, 8 },
            new int[] { 9, 10, 11, 12 }
        };
        
        int[][] expected = new int[][]
        {
            new int[] { 5, 1, 2, 3 },
            new int[] { 9, 6, 7, 4 },
            new int[] { 10, 11, 12, 8 }
        };
        
        // Act
        var result = Solution.RotateBorderClockwise(grid);
        
        // Assert
        AssertMatricesEqual(expected, result);
    }
    
    [Fact]
    public void RotateBorderClockwise_MinimumSize_2x2Grid()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 3, 4 }
        };
        
        int[][] expected = new int[][]
        {
            new int[] { 3, 1 },
            new int[] { 4, 2 }
        };
        
        // Act
        var result = Solution.RotateBorderClockwise(grid);
        
        // Assert
        AssertMatricesEqual(expected, result);
    }
    
    [Fact]
    public void RotateBorderClockwise_NonSquare_2x5Grid()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 6, 7, 8, 9, 10 }
        };
        
        int[][] expected = new int[][]
        {
            new int[] { 6, 1, 2, 3, 4 },
            new int[] { 7, 8, 9, 10, 5 }
        };
        
        // Act
        var result = Solution.RotateBorderClockwise(grid);
        
        // Assert
        AssertMatricesEqual(expected, result);
    }
    
    [Fact]
    public void RotateBorderClockwise_LargerGrid_InnerCellsUnchanged()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 6, 7, 8, 9, 10 },
            new int[] { 11, 12, 13, 14, 15 },
            new int[] { 16, 17, 18, 19, 20 }
        };
        
        int[][] expected = new int[][]
        {
            new int[] { 6, 1, 2, 3, 4 },
            new int[] { 11, 7, 8, 9, 5 },
            new int[] { 16, 12, 13, 14, 10 },
            new int[] { 17, 18, 19, 20, 15 }
        };
        
        // Act
        var result = Solution.RotateBorderClockwise(grid);
        
        // Assert
        AssertMatricesEqual(expected, result);
        
        // Verify inner cells are unchanged
        Assert.Equal(7, result[1][1]);
        Assert.Equal(8, result[1][2]);
        Assert.Equal(9, result[1][3]);
        Assert.Equal(12, result[2][1]);
        Assert.Equal(13, result[2][2]);
        Assert.Equal(14, result[2][3]);
    }
    
    [Fact]
    public void RotateBorderClockwise_OriginalNotMutated()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        
        // Create a copy of the original to verify it doesn't change
        int[][] originalCopy = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        
        // Act
        var result = Solution.RotateBorderClockwise(grid);
        
        // Assert - verify original is unchanged
        AssertMatricesEqual(originalCopy, grid);
        
        // Also verify result is different from original
        Assert.NotEqual(grid[0][0], result[0][0]);
    }
    
    [Fact]
    public void RotateBorderClockwise_WithNegativeValues()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] { -1, -2, -3 },
            new int[] { -4, 0, -5 },
            new int[] { -6, -7, -8 }
        };
        
        int[][] expected = new int[][]
        {
            new int[] { -4, -1, -2 },
            new int[] { -6, 0, -3 },
            new int[] { -7, -8, -5 }
        };
        
        // Act
        var result = Solution.RotateBorderClockwise(grid);
        
        // Assert
        AssertMatricesEqual(expected, result);
    }
    
    [Fact]
    public void RotateBorderClockwise_TallGrid_3x2()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 3, 4 },
            new int[] { 5, 6 }
        };
        
        int[][] expected = new int[][]
        {
            new int[] { 3, 1 },
            new int[] { 5, 2 },
            new int[] { 6, 4 }
        };
        
        // Act
        var result = Solution.RotateBorderClockwise(grid);
        
        // Assert
        AssertMatricesEqual(expected, result);
    }
}
