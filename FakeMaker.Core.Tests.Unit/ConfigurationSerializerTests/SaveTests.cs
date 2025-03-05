namespace FakeMaker.Core.Tests.Unit.ConfigurationSerializerTests;

public class SaveTests
{
    [Fact]
    public void ConfigurationHasNoColumns_FileContainsRootNode()
    {
        // Arrange
        using var stream = new MemoryStream();

        var configuration = new Configuration();

        // Act
        ConfigurationSerializer.Save(configuration, stream);

        // Assert
        stream.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(stream);
        var result = reader.ReadToEnd();

        Assert.Equal(
            """
            <configuration />
            """,
            result);
    }

    [Fact]
    public void ConfigurationHasTwoColumns_FileContainsTwoColumnNodes()
    {
        // Arrange
        using var stream = new MemoryStream();

        var configuration = new Configuration()
        {
            Columns = [
                new Column() { Name = "first_name", Type = DataType.FirstName },
                new Column() { Name = "last_name", Type = DataType.LastName },
            ],
        };

        // Act
        ConfigurationSerializer.Save(configuration, stream);

        // Assert
        stream.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(stream);
        var result = reader.ReadToEnd();

        Assert.Equal(
            """
            <configuration>
                <column name="first_name" type="FirstName" />
                <column name="last_name" type="LastName" />
            </configuration>
            """,
            result);
    }
}
