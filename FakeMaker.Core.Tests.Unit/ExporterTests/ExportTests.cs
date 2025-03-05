using System.Data;

namespace FakeMaker.Core.Tests.Unit.ExporterTests;

public class ExportTests
{
    [Fact]
    public void ConfigurationHasTwoColumns_ColumnNamesAreWrittenInHeader()
    {
        // Arrange
        using var stream = new MemoryStream();
        var dataTable = new DataTable();

        dataTable.Columns.AddRange([
            new DataColumn("first_name"),
            new DataColumn("last_name"),
        ]);

        // Act
        Exporter.Export(stream, dataTable);

        // Assert
        stream.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(stream);
        var result = reader.ReadToEnd();

        Assert.Equal("first_name,last_name", result);
    }

    [Fact]
    public void TwoRecordsAreExported_ResultantStringIsCorrect()
    {
        // Arrange
        using var stream = new MemoryStream();

        var dataTable = new DataTable();

        dataTable.Columns.AddRange([
            new DataColumn("first_name"),
            new DataColumn("last_name"),
        ]);

        dataTable.Rows.Add("David", "Morgan");
        dataTable.Rows.Add("Bethan", "Smith");

        // Act
        Exporter.Export(stream, dataTable);

        // Assert
        stream.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(stream);
        var result = reader.ReadToEnd();

        Assert.Equal($"first_name,last_name{Environment.NewLine}David,Morgan{Environment.NewLine}Bethan,Smith", result);
    }
}
