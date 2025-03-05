namespace FakeMaker.Core.Tests.Unit.GeneratorTests;

public class GenerateTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    [InlineData(100)]
    [InlineData(1000)]
    public void XRecordsAreRequested_XRecordsAreReturned(int count)
    {
        // Arrange
        var configuration = new Configuration();
        var generator = new Generator();

        // Act
        var result = generator.Generate(count, configuration);

        // Assert
        Assert.Equal(count, result.Count());
    }

    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    [InlineData(100)]
    public void ConfigurationHasXColumns_RecordsHaveXFields(int columnCount)
    {
        // Arrange
        var configuration = new Configuration();

        for (var i = 0; i < columnCount; ++i)
        {
            var column = new Column()
            {
                Name = $"column{i}",
                Type = DataType.FirstName,
            };

            configuration.Columns.Add(column);
        }

        var generator = new Generator();

        // Act
        var result = generator.Generate(100, configuration);

        // Assert
        Assert.All(result, x => Assert.Equal(columnCount, x.Fields.Length));
    }
}
