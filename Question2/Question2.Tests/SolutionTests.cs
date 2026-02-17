namespace Question2.Tests;

public class SolutionTests
{
    [Fact]
    public void ExtractAndReverseEvens_WithMixedNumbers_ReturnsReversedEvens()
    {
        // Arrange
        int[] input = new int[] { 12, 7, 24, 9, 6 };
        
        // Act
        string result = Solution.ExtractAndReverseEvens(input);
        
        // Assert
        Assert.Equal("21,42,6", result);
    }
    
    [Fact]
    public void ExtractAndReverseEvens_WithOnlyOddNumbers_ReturnsEmpty()
    {
        // Arrange
        int[] input = new int[] { 1, 3, 5, 7, 9 };
        
        // Act
        string result = Solution.ExtractAndReverseEvens(input);
        
        // Assert
        Assert.Equal("", result);
    }
    
    [Fact]
    public void ExtractAndReverseEvens_WithEmptyArray_ReturnsEmpty()
    {
        // Arrange
        int[] input = new int[] { };
        
        // Act
        string result = Solution.ExtractAndReverseEvens(input);
        
        // Assert
        Assert.Equal("", result);
    }
    
    [Fact]
    public void ExtractAndReverseEvens_WithNullArray_ReturnsEmpty()
    {
        // Arrange
        int[]? input = null;
        
        // Act
        string result = Solution.ExtractAndReverseEvens(input);
        
        // Assert
        Assert.Equal("", result);
    }
    
    [Fact]
    public void ExtractAndReverseEvens_WithNegativeEvens_ReturnsReversedWithSign()
    {
        // Arrange
        int[] input = new int[] { -12, 24, -8, 5 };
        
        // Act
        string result = Solution.ExtractAndReverseEvens(input);
        
        // Assert
        Assert.Equal("-21,42,-8", result);
    }
}
