namespace Demo.Api.UnitTests.Services;

public class BinarySearchServiceTests
{
    [Fact]
    public void Run_ShouldReturnIndex_WhenTargetIsFound()
    {
        //Arrange
        int[] array = { 1, 2, 3, 4, 5 };
        int target = 3;
        int expected = 2;
        BinarySearchService sut = new BinarySearchService();
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
        BinarySearchService sut = new BinarySearchService();
        //Act
        int actual = sut.Run(array, target);
        //Assert
        Assert.Equal(expected, actual);
    }
}
