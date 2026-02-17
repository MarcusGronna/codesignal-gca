namespace Question1.Tests;

public class SolutionTests
{
    [Fact]
    public void ArraySum_WithPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        
        // Act
        int result = Solution.ArraySum(numbers);
        
        // Assert
        Assert.Equal(15, result);
    }
    
    [Fact]
    public void ArraySum_WithMixedNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int[] numbers = new int[] { -1, 0, 1 };
        
        // Act
        int result = Solution.ArraySum(numbers);
        
        // Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void ArraySum_WithEmptyArray_ReturnsZero()
    {
        // Arrange
        int[] numbers = new int[] { };
        
        // Act
        int result = Solution.ArraySum(numbers);
        
        // Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void ArraySum_WithSingleElement_ReturnsThatElement()
    {
        // Arrange
        int[] numbers = new int[] { 100 };
        
        // Act
        int result = Solution.ArraySum(numbers);
        
        // Assert
        Assert.Equal(100, result);
    }
}
