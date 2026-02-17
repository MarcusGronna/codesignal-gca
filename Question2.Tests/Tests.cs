using Xunit;

namespace Question2.Tests;

public class Tests
{
    [Fact]
    public void CountVowels_NormalInput_ReturnsCorrectCount()
    {
        // Arrange
        string text = "Hello World";
        
        // Act
        int result = Solution.CountVowels(text);
        
        // Assert
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void CountVowels_EmptyString_ReturnsZero()
    {
        // Arrange
        string text = "";
        
        // Act
        int result = Solution.CountVowels(text);
        
        // Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void CountVowels_NoVowels_ReturnsZero()
    {
        // Arrange
        string text = "bcdfg";
        
        // Act
        int result = Solution.CountVowels(text);
        
        // Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void CountVowels_MixedCase_ReturnsCorrectCount()
    {
        // Arrange
        string text = "Programming";
        
        // Act
        int result = Solution.CountVowels(text);
        
        // Assert
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void CountVowels_AllVowels_ReturnsCorrectCount()
    {
        // Arrange
        string text = "AEIOUaeiou";
        
        // Act
        int result = Solution.CountVowels(text);
        
        // Assert
        Assert.Equal(10, result);
    }
}
