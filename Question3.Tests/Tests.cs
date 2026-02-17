using Xunit;

namespace Question3.Tests;

public class Tests
{
    [Fact]
    public void FindMaximum_NormalInput_ReturnsMaximum()
    {
        // Arrange
        int[] numbers = [3, 7, 2, 9, 1];
        
        // Act
        int result = Solution.FindMaximum(numbers);
        
        // Assert
        Assert.Equal(9, result);
    }
    
    [Fact]
    public void FindMaximum_EmptyArray_ReturnsZero()
    {
        // Arrange
        int[] numbers = [];
        
        // Act
        int result = Solution.FindMaximum(numbers);
        
        // Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void FindMaximum_NegativeNumbers_ReturnsMaximum()
    {
        // Arrange
        int[] numbers = [-5, -2, -8, -1];
        
        // Act
        int result = Solution.FindMaximum(numbers);
        
        // Assert
        Assert.Equal(-1, result);
    }
    
    [Fact]
    public void FindMaximum_SingleElement_ReturnsThatElement()
    {
        // Arrange
        int[] numbers = [42];
        
        // Act
        int result = Solution.FindMaximum(numbers);
        
        // Assert
        Assert.Equal(42, result);
    }
    
    [Fact]
    public void FindMaximum_AllSameValue_ReturnsThatValue()
    {
        // Arrange
        int[] numbers = [5, 5, 5, 5];
        
        // Act
        int result = Solution.FindMaximum(numbers);
        
        // Assert
        Assert.Equal(5, result);
    }
}
