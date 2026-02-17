namespace Question3.Tests;

public class SolutionTests
{
    [Fact]
    public void IsPalindrome_WithSimplePalindrome_ReturnsTrue()
    {
        // Arrange
        string input = "racecar";
        
        // Act
        bool result = Solution.IsPalindrome(input);
        
        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsPalindrome_WithNonPalindrome_ReturnsFalse()
    {
        // Arrange
        string input = "hello";
        
        // Act
        bool result = Solution.IsPalindrome(input);
        
        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsPalindrome_WithSpacesAndMixedCase_ReturnsTrue()
    {
        // Arrange
        string input = "A man a plan a canal Panama";
        
        // Act
        bool result = Solution.IsPalindrome(input);
        
        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsPalindrome_WithEmptyString_ReturnsTrue()
    {
        // Arrange
        string input = "";
        
        // Act
        bool result = Solution.IsPalindrome(input);
        
        // Assert
        Assert.True(result);
    }
}
