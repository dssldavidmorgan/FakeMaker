namespace FakeMaker.Core.Tests.Unit.GeneratorTests;

public class GenerateTests
{
    [Fact]
    public void TenRecordsAreRequested_TenRecordsAreReturned()
    {
        // Arrange
        var generator = new Generator();

        // Act
        var result = generator.Generate(100, configuration: null!);

        // Assert
        Assert.Equal(100, result.Count());
    }
}
