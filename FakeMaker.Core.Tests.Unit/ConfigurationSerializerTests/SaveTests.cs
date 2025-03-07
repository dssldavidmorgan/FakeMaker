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

    [Fact]
    public void ConfigurationHasTwoCustomDataTypes_FileContainsTwoCustomDataTypeNodes()
    {
        // Arrange
        using var stream = new MemoryStream();

        var configuration = new Configuration()
        {
            CustomDataTypes = [
                new CustomDataType()
                {
                    Name = "custom1",
                    Values = ["0", "1", "2", "3", "4"],
                },
                new CustomDataType()
                {
                    Name = "custom2",
                    Values = ["5", "6", "7", "8", "9"],
                },
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
                <customDataType name="custom1">
                    <value>0</value>
                    <value>1</value>
                    <value>2</value>
                    <value>3</value>
                    <value>4</value>
                </customDataType>
                <customDataType name="custom2">
                    <value>5</value>
                    <value>6</value>
                    <value>7</value>
                    <value>8</value>
                    <value>9</value>
                </customDataType>
            </configuration>
            """,
            result);
    }
}
