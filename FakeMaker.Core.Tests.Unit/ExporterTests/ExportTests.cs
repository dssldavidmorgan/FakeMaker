namespace FakeMaker.Core.Tests.Unit.ExporterTests;

public class ExportTests
{
    [Fact]
    public void ConfigurationHasTwoColumns_ColumnNamesAreWrittenInHeader()
    {
        // Arrange
        using var stream = new MemoryStream();
        var configuration = new Configuration()
        {
            Columns =
            [
                new Column
                {
                    Name = "first_name",
                    Type = DataType.FirstName,
                },
                new Column
                {
                    Name = "last_name",
                    Type = DataType.LastName,
                },
            ]
        };

        var exporter = new Exporter();

        // Act
        exporter.Export(stream, records: null!, configuration);

        // Assert
        stream.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(stream);
        var result = reader.ReadToEnd();

        Assert.Equal("first_name,last_name", result);
    }
}
