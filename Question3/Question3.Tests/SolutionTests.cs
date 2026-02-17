namespace Question3.Tests;

public class SolutionTests
{
    [Fact]
    public void CharacterFrequencyByPosition_WithSimpleInput_ReturnsCorrectDictionary()
    {
        // Arrange
        string input = "a1b2c1";
        
        // Act
        var result = Solution.CharacterFrequencyByPosition(input);
        
        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal(2, result[1]); // Position 1 has '1', which appears 2 times
        Assert.Equal(1, result[3]); // Position 3 has '2', which appears 1 time
    }
    
    [Fact]
    public void CharacterFrequencyByPosition_WithMultipleDigits_ReturnsCorrectFrequencies()
    {
        // Arrange
        string input = "hello123world321";
        
        // Act
        var result = Solution.CharacterFrequencyByPosition(input);
        
        // Assert
        Assert.Equal(6, result.Count);
        Assert.Equal(2, result[5]);  // Position 5 has '1', appears 2 times total
        Assert.Equal(2, result[6]);  // Position 6 has '2', appears 2 times total
        Assert.Equal(2, result[7]);  // Position 7 has '3', appears 2 times total
        Assert.Equal(2, result[13]); // Position 13 has '3', appears 2 times total
        Assert.Equal(2, result[14]); // Position 14 has '2', appears 2 times total
        Assert.Equal(2, result[15]); // Position 15 has '1', appears 2 times total
    }
    
    [Fact]
    public void CharacterFrequencyByPosition_WithNoDigits_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = "no digits here";
        
        // Act
        var result = Solution.CharacterFrequencyByPosition(input);
        
        // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public void CharacterFrequencyByPosition_WithEmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = "";
        
        // Act
        var result = Solution.CharacterFrequencyByPosition(input);
        
        // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public void CharacterFrequencyByPosition_WithNullString_ReturnsEmptyDictionary()
    {
        // Arrange
        string? input = null;
        
        // Act
        var result = Solution.CharacterFrequencyByPosition(input);
        
        // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public void CharacterFrequencyByPosition_WithAllSameDigit_ReturnsCorrectCounts()
    {
        // Arrange
        string input = "5a5b5c5";
        
        // Act
        var result = Solution.CharacterFrequencyByPosition(input);
        
        // Assert
        Assert.Equal(4, result.Count);
        Assert.Equal(4, result[0]); // Position 0 has '5', appears 4 times
        Assert.Equal(4, result[2]); // Position 2 has '5', appears 4 times
        Assert.Equal(4, result[4]); // Position 4 has '5', appears 4 times
        Assert.Equal(4, result[6]); // Position 6 has '5', appears 4 times
    }
}
