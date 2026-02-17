namespace Question3.Tests;

public class Tests
{
    private readonly Solution _solution = new();

    [Fact]
    public void IsPalindrome_WithSimplePalindrome_ReturnsTrue()
    {
        // Arrange
        string text = "racecar";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_WithNonPalindrome_ReturnsFalse()
    {
        // Arrange
        string text = "hello";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_WithMixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        string text = "RaceCar";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_WithSpacesInPalindrome_ReturnsTrue()
    {
        // Arrange
        string text = "A man a plan a canal Panama";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_WithEmptyString_ReturnsTrue()
    {
        // Arrange
        string text = "";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_WithSingleCharacter_ReturnsTrue()
    {
        // Arrange
        string text = "a";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_WithTwoSameCharacters_ReturnsTrue()
    {
        // Arrange
        string text = "aa";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_WithTwoDifferentCharacters_ReturnsFalse()
    {
        // Arrange
        string text = "ab";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_WithOnlySpaces_ReturnsTrue()
    {
        // Arrange
        string text = "   ";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_WithMixedCaseAndSpaces_ReturnsTrue()
    {
        // Arrange
        string text = "Was it a car or a cat I saw";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_WithLongNonPalindrome_ReturnsFalse()
    {
        // Arrange
        string text = "this is not a palindrome";

        // Act
        bool result = _solution.IsPalindrome(text);

        // Assert
        Assert.False(result);
    }
}
