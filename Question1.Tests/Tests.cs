using Xunit;

namespace Question1.Tests;

public class Tests
{
    [Fact]
    public void SumOfEvenNumbers_NormalInput_ReturnsCorrectSum()
    {
        // Arrange
        int[] numbers = [1, 2, 3, 4, 5, 6];
        
        // Act
        int result = Solution.SumOfEvenNumbers(numbers);
        
        // Assert
        Assert.Equal(12, result);
    }
    
    [Fact]
    public void SumOfEvenNumbers_EmptyArray_ReturnsZero()
    {
        // Arrange
        int[] numbers = [];
        
        // Act
        int result = Solution.SumOfEvenNumbers(numbers);
        
        // Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void SumOfEvenNumbers_NoEvenNumbers_ReturnsZero()
    {
        // Arrange
        int[] numbers = [1, 3, 5, 7];
        
        // Act
        int result = Solution.SumOfEvenNumbers(numbers);
        
        // Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void SumOfEvenNumbers_NegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int[] numbers = [-4, -2, 1, 3];
        
        // Act
        int result = Solution.SumOfEvenNumbers(numbers);
        
        // Assert
        Assert.Equal(-6, result);
    }
    
    [Fact]
    public void SumOfEvenNumbers_AllEvenNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int[] numbers = [2, 4, 6, 8];
        
        // Act
        int result = Solution.SumOfEvenNumbers(numbers);
        
        // Assert
        Assert.Equal(20, result);
    }
}
