namespace Question4.Tests;

public class Tests
{
    private readonly Solution _solution = new();

    [Fact]
    public void FindMaximum_WithPositiveNumbers_ReturnsLargest()
    {
        // Arrange
        int[] numbers = [1, 5, 3, 9, 2];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void FindMaximum_WithAllNegativeNumbers_ReturnsLeastNegative()
    {
        // Arrange
        int[] numbers = [-10, -5, -20, -1];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(-1, result);
    }

    [Fact]
    public void FindMaximum_WithSingleElement_ReturnsThatElement()
    {
        // Arrange
        int[] numbers = [42];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void FindMaximum_WithAllEqualElements_ReturnsThatValue()
    {
        // Arrange
        int[] numbers = [5, 5, 5, 5];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void FindMaximum_WithMixedNumbers_ReturnsLargest()
    {
        // Arrange
        int[] numbers = [-5, 0, 10, -20, 3];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void FindMaximum_WithMaxAtBeginning_ReturnsFirstElement()
    {
        // Arrange
        int[] numbers = [100, 50, 25, 10];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(100, result);
    }

    [Fact]
    public void FindMaximum_WithMaxAtEnd_ReturnsLastElement()
    {
        // Arrange
        int[] numbers = [10, 25, 50, 100];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(100, result);
    }

    [Fact]
    public void FindMaximum_WithDuplicateMaxValues_ReturnsMaxValue()
    {
        // Arrange
        int[] numbers = [3, 7, 7, 2, 5];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void FindMaximum_WithLargeNumbers_ReturnsCorrectMax()
    {
        // Arrange
        int[] numbers = [1000000, 999999, -1000000];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(1000000, result);
    }

    [Fact]
    public void FindMaximum_WithZeroAndPositive_ReturnsPositive()
    {
        // Arrange
        int[] numbers = [0, 1];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void FindMaximum_WithZeroAndNegative_ReturnsZero()
    {
        // Arrange
        int[] numbers = [0, -1];

        // Act
        int result = _solution.FindMaximum(numbers);

        // Assert
        Assert.Equal(0, result);
    }
}
