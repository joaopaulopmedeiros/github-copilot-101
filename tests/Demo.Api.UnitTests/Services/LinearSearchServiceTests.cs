namespace Demo.Api.UnitTests.Services;

public class LinearSearchServiceTests
{
    [Fact]
    public void Run_ShouldReturnIndex_WhenTargetIsFound()
    {
        //Arrange
        int[] array = { 1, 2, 3, 4, 5 };
        int target = 3;
        int expected = 2;
        LinearSearchService sut = new LinearSearchService();
        //Act
        int actual = sut.Run(array, target);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Run_ShouldReturnNegativeOne_WhenTargetIsNotFound()
    {
        //Arrange
        int[] array = { 1, 2, 3, 4, 5 };
        int target = 6;
        int expected = -1;
        LinearSearchService sut = new LinearSearchService();
        //Act
        int actual = sut.Run(array, target);
        //Assert
        Assert.Equal(expected, actual);
    }
}
