using System.Data;

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

        // Act
        var result = Generator.Generate(count, configuration);

        // Assert
        Assert.Equal(count, result.Rows.Count);
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

        // Act
        var result = Generator.Generate(100, configuration);

        // Assert
        Assert.All(GetRows(result), x => Assert.Equal(columnCount, x.ItemArray.Length));
    }

    [Fact]
    public void ConfigurationHasFirstNameColumn_RecordsHaveFirstNameField()
    {
        // Arrange
        var configuration = new Configuration()
        {
            Columns =
            [
                new Column() { Name = "first_name", Type = DataType.FirstName },
            ],
        };

        // Act
        var result = Generator.Generate(10, configuration);

        // Assert
        Assert.All(GetRows(result), x =>
        {
            var fields = GetFields(x);

            Assert.NotEmpty(fields);
            Assert.True(char.IsUpper(fields[0][0]));
            Assert.All(fields[0][1..], y => char.IsUpper(y));
        });
    }

    [Fact]
    public void ConfigurationHasLastNameColumn_RecordsHaveLastNameField()
    {
        // Arrange
        var configuration = new Configuration()
        {
            Columns =
            [
                new Column() { Name = "last_name", Type = DataType.LastName },
            ],
        };

        // Act
        var result = Generator.Generate(10, configuration);

        // Assert
        Assert.All(GetRows(result), x =>
        {
            var fields = GetFields(x);

            Assert.NotEmpty(fields[0]);
            Assert.True(char.IsUpper(fields[0][0]));
            Assert.All(fields[0][1..], y => char.IsUpper(y));
        });
    }

    [Fact]
    public void ConfigurationHasEnrolmentNumberColumn_RecordsHaveEnrolmentNumberField()
    {
        // Arrange
        var configuration = new Configuration()
        {
            Columns =
            [
                new Column() { Name = "enrolment_number", Type = DataType.EnrolmentNumber },
            ],
        };

        // Act
        var result = Generator.Generate(10, configuration);

        // Assert
        Assert.All(GetRows(result), x =>
        {
            var fields = GetFields(x);

            Assert.Equal(8, fields[0].Length);
            Assert.All(fields[0], y => char.IsDigit(y));
        });
    }

    [Fact]
    public void ConfigurationHasEmailAddressColumn_RecordsHaveEmailAddressField()
    {
        // Arrange
        var configuration = new Configuration()
        {
            Columns =
            [
                new Column() { Name = "email_address", Type = DataType.EmailAddress },
            ],
        };

        // Act
        var result = Generator.Generate(10, configuration);

        // Assert
        Assert.All(GetRows(result), x =>
        {
            var fields = GetFields(x);

            Assert.NotEmpty(fields[0]);
            Assert.Contains('@', fields[0]);
        });
    }

    [Fact]
    public void ConfigurationHasDateRecentColumn_RecordsHaveDateRecentField()
    {
        // Arrange
        var configuration = new Configuration()
        {
            Columns =
            [
                new Column() { Name = "date_recent", Type = DataType.DateRecent },
            ],
        };

        // Act
        var result = Generator.Generate(10, configuration);

        // Assert
        Assert.All(GetRows(result), x =>
        {
            var fields = GetFields(x);

            Assert.True(DateOnly.TryParse(fields[0], out var dateRecent));
            Assert.True(dateRecent <= DateOnly.FromDateTime(DateTime.Today));
        });
    }

    [Fact]
    public void ConfigurationHasDateSoonColumn_RecordsHaveDateSoonField()
    {
        // Arrange
        var configuration = new Configuration()
        {
            Columns =
            [
                new Column() { Name = "date_soon", Type = DataType.DateSoon },
            ],
        };

        // Act
        var result = Generator.Generate(10, configuration);

        // Assert
        Assert.All(GetRows(result), x =>
        {
            var fields = GetFields(x);

            Assert.True(DateOnly.TryParse(fields[0], out var dateRecent));
            Assert.True(dateRecent >= DateOnly.FromDateTime(DateTime.Today));
        });
    }

    private static DataRow[] GetRows(DataTable dataTable) => [.. dataTable.Rows.Cast<DataRow>()];

    private static string[] GetFields(DataRow dataRow) => [.. dataRow.ItemArray.Cast<string>()];
}
