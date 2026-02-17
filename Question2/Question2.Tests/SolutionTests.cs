namespace Question2.Tests;

public class SolutionTests
{
    [Fact]
    public void ReverseString_WithNormalString_ReturnsReversed()
    {
        // Arrange
        string input = "hello";
        
        // Act
        string result = Solution.ReverseString(input);
        
        // Assert
        Assert.Equal("olleh", result);
    }
    
    [Fact]
    public void ReverseString_WithShortString_ReturnsReversed()
    {
        // Arrange
        string input = "abc";
        
        // Act
        string result = Solution.ReverseString(input);
        
        // Assert
        Assert.Equal("cba", result);
    }
    
    [Fact]
    public void ReverseString_WithEmptyString_ReturnsEmpty()
    {
        // Arrange
        string input = "";
        
        // Act
        string result = Solution.ReverseString(input);
        
        // Assert
        Assert.Equal("", result);
    }
    
    [Fact]
    public void ReverseString_WithSingleCharacter_ReturnsSameCharacter()
    {
        // Arrange
        string input = "A";
        
        // Act
        string result = Solution.ReverseString(input);
        
        // Assert
        Assert.Equal("A", result);
    }
}
