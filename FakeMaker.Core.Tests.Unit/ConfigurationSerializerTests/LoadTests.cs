namespace FakeMaker.Core.Tests.Unit.ConfigurationSerializerTests;

public class LoadTests
{
    [Fact]
    public void FileIsEmpty_ReturnsEmptyConfiguration()
    {
        // Arrange
        using var stream = new MemoryStream();

        // Act
        var result = ConfigurationSerializer.Load(stream);

        // Assert
        Assert.Empty(result.Columns);
    }

    [Fact]
    public void FileHasTwoColumns_ConfigurationContainsCorrectColumns()
    {
        // Arrange
        using var stream = new MemoryStream();
        using var writer = new StreamWriter(stream);

        writer.Write(
            """
            <configuration>
                <column name="first_name" type="FirstName" />
                <column name="last_name" type="LastName" />
            </configuration>
            """);

        writer.Flush();

        stream.Seek(0, SeekOrigin.Begin);

        // Act
        var result = ConfigurationSerializer.Load(stream);

        // Assert
        Assert.Collection(
            result.Columns,
            column1 =>
            {
                Assert.Equal("first_name", column1.Name);
                Assert.Equal(DataType.FirstName, column1.Type);
            },
            column2 =>
            {
                Assert.Equal("last_name", column2.Name);
                Assert.Equal(DataType.LastName, column2.Type);
            });
    }
}
