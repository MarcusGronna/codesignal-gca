namespace Question1.Tests;

public class Tests
{
    private readonly Solution _solution = new();

    [Fact]
    public void SumArray_WithPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int[] numbers = [1, 2, 3, 4, 5];

        // Act
        int result = _solution.SumArray(numbers);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void SumArray_WithMixedNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int[] numbers = [10, -5, 3];

        // Act
        int result = _solution.SumArray(numbers);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void SumArray_WithAllNegativeNumbers_ReturnsNegativeSum()
    {
        // Arrange
        int[] numbers = [-1, -2, -3, -4];

        // Act
        int result = _solution.SumArray(numbers);

        // Assert
        Assert.Equal(-10, result);
    }

    [Fact]
    public void SumArray_WithEmptyArray_ReturnsZero()
    {
        // Arrange
        int[] numbers = [];

        // Act
        int result = _solution.SumArray(numbers);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void SumArray_WithSingleElement_ReturnsThatElement()
    {
        // Arrange
        int[] numbers = [42];

        // Act
        int result = _solution.SumArray(numbers);

        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void SumArray_WithZeros_ReturnsZero()
    {
        // Arrange
        int[] numbers = [0, 0, 0];

        // Act
        int result = _solution.SumArray(numbers);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void SumArray_WithLargeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int[] numbers = [1000000, -999999, 1];

        // Act
        int result = _solution.SumArray(numbers);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void SumArray_WithManyElements_ReturnsCorrectSum()
    {
        // Arrange
        int[] numbers = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1]; // 10 ones

        // Act
        int result = _solution.SumArray(numbers);

        // Assert
        Assert.Equal(10, result);
    }
}
