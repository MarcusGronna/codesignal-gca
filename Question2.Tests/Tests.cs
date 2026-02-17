namespace Question2.Tests;

public class Tests
{
    private readonly Solution _solution = new();

    [Fact]
    public void ReverseString_WithSimpleString_ReturnsReversed()
    {
        // Arrange
        string input = "hello";

        // Act
        string result = _solution.ReverseString(input);

        // Assert
        Assert.Equal("olleh", result);
    }

    [Fact]
    public void ReverseString_WithMixedCase_ReturnsReversedWithSameCase()
    {
        // Arrange
        string input = "CodeSignal";

        // Act
        string result = _solution.ReverseString(input);

        // Assert
        Assert.Equal("langiSedoC", result);
    }

    [Fact]
    public void ReverseString_WithEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string result = _solution.ReverseString(input);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void ReverseString_WithSingleCharacter_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";

        // Act
        string result = _solution.ReverseString(input);

        // Assert
        Assert.Equal("a", result);
    }

    [Fact]
    public void ReverseString_WithNumbers_ReturnsReversedNumbers()
    {
        // Arrange
        string input = "12345";

        // Act
        string result = _solution.ReverseString(input);

        // Assert
        Assert.Equal("54321", result);
    }

    [Fact]
    public void ReverseString_WithSpecialCharacters_ReturnsReversedWithSpecialChars()
    {
        // Arrange
        string input = "hello!";

        // Act
        string result = _solution.ReverseString(input);

        // Assert
        Assert.Equal("!olleh", result);
    }

    [Fact]
    public void ReverseString_WithSpaces_ReturnsReversedWithSpaces()
    {
        // Arrange
        string input = "hello world";

        // Act
        string result = _solution.ReverseString(input);

        // Assert
        Assert.Equal("dlrow olleh", result);
    }

    [Fact]
    public void ReverseString_WithPalindrome_ReturnsSameString()
    {
        // Arrange
        string input = "racecar";

        // Act
        string result = _solution.ReverseString(input);

        // Assert
        Assert.Equal("racecar", result);
    }

    [Fact]
    public void ReverseString_WithLongString_ReturnsCorrectReverse()
    {
        // Arrange
        string input = "abcdefghijklmnopqrstuvwxyz";

        // Act
        string result = _solution.ReverseString(input);

        // Assert
        Assert.Equal("zyxwvutsrqponmlkjihgfedcba", result);
    }
}
