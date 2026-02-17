using Xunit;

namespace Question4.Tests;

public class Tests
{
    [Fact]
    public void ReverseString_NormalInput_ReturnsReversedString()
    {
        // Arrange
        string text = "hello";
        
        // Act
        string result = Solution.ReverseString(text);
        
        // Assert
        Assert.Equal("olleh", result);
    }
    
    [Fact]
    public void ReverseString_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string text = "";
        
        // Act
        string result = Solution.ReverseString(text);
        
        // Assert
        Assert.Equal("", result);
    }
    
    [Fact]
    public void ReverseString_WithSpacesAndSpecialChars_ReturnsReversedString()
    {
        // Arrange
        string text = "Hello World!";
        
        // Act
        string result = Solution.ReverseString(text);
        
        // Assert
        Assert.Equal("!dlroW olleH", result);
    }
    
    [Fact]
    public void ReverseString_SingleCharacter_ReturnsSameCharacter()
    {
        // Arrange
        string text = "a";
        
        // Act
        string result = Solution.ReverseString(text);
        
        // Assert
        Assert.Equal("a", result);
    }
    
    [Fact]
    public void ReverseString_Palindrome_ReturnsSameString()
    {
        // Arrange
        string text = "racecar";
        
        // Act
        string result = Solution.ReverseString(text);
        
        // Assert
        Assert.Equal("racecar", result);
    }
}
