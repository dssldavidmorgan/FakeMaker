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

    [Fact]
    public void FileHasTwoCustomDataTypes_ConfigurationContainsCorrectDataTypes()
    {
        // Arrange
        using var stream = new MemoryStream();
        using var writer = new StreamWriter(stream);

        writer.Write(
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
            """);

        writer.Flush();

        stream.Seek(0, SeekOrigin.Begin);

        // Act
        var result = ConfigurationSerializer.Load(stream);

        // Assert
        Assert.Collection(
            result.CustomDataTypes,
            customDataType1 =>
            {
                Assert.Equal("custom1", customDataType1.Name);
                Assert.Collection(customDataType1.Values,
                    value1 => Assert.Equal("0", value1),
                    value2 => Assert.Equal("1", value2),
                    value3 => Assert.Equal("2", value3),
                    value4 => Assert.Equal("3", value4),
                    value5 => Assert.Equal("4", value5));
            },
            customDataType2 =>
            {
                Assert.Equal("custom2", customDataType2.Name);
                Assert.Collection(customDataType2.Values,
                    value1 => Assert.Equal("5", value1),
                    value2 => Assert.Equal("6", value2),
                    value3 => Assert.Equal("7", value3),
                    value4 => Assert.Equal("8", value4),
                    value5 => Assert.Equal("9", value5));
            });
    }
}
