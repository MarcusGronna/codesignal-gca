namespace Question4.Tests;

public class SolutionTests
{
    [Fact]
    public void FindMaximum_WithMixedNumbers_ReturnsMaximum()
    {
        // Arrange
        int[] numbers = new int[] { 1, 5, 3, 9, 2 };
        
        // Act
        int result = Solution.FindMaximum(numbers);
        
        // Assert
        Assert.Equal(9, result);
    }
    
    [Fact]
    public void FindMaximum_WithNegativeNumbers_ReturnsMaximum()
    {
        // Arrange
        int[] numbers = new int[] { -10, -5, -20 };
        
        // Act
        int result = Solution.FindMaximum(numbers);
        
        // Assert
        Assert.Equal(-5, result);
    }
    
    [Fact]
    public void FindMaximum_WithSingleElement_ReturnsThatElement()
    {
        // Arrange
        int[] numbers = new int[] { 42 };
        
        // Act
        int result = Solution.FindMaximum(numbers);
        
        // Assert
        Assert.Equal(42, result);
    }
    
    [Fact]
    public void FindMaximum_WithLargeNumbers_ReturnsMaximum()
    {
        // Arrange
        int[] numbers = new int[] { 100, 200, 50, 75 };
        
        // Act
        int result = Solution.FindMaximum(numbers);
        
        // Assert
        Assert.Equal(200, result);
    }
}
