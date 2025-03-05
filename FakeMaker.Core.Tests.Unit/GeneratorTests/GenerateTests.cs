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

        var generator = new Generator();

        // Act
        var result = generator.Generate(10, configuration);

        // Assert
        Assert.All(result, x =>
        {
            Assert.NotEmpty(x.Fields[0]);
            Assert.True(char.IsUpper(x.Fields[0][0]));
            Assert.All(x.Fields[0][1..], y => char.IsUpper(y));
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

        var generator = new Generator();

        // Act
        var result = generator.Generate(10, configuration);

        // Assert
        Assert.All(result, x =>
        {
            Assert.NotEmpty(x.Fields[0]);
            Assert.True(char.IsUpper(x.Fields[0][0]));
            Assert.All(x.Fields[0][1..], y => char.IsUpper(y));
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

        var generator = new Generator();

        // Act
        var result = generator.Generate(10, configuration);

        // Assert
        Assert.All(result, x =>
        {
            Assert.Equal(8, x.Fields[0].Length);
            Assert.All(x.Fields[0], y => char.IsDigit(y));
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

        var generator = new Generator();

        // Act
        var result = generator.Generate(10, configuration);

        // Assert
        Assert.All(result, x =>
        {
            Assert.NotEmpty(x.Fields[0]);
            Assert.Contains('@', x.Fields[0]);
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

        var generator = new Generator();

        // Act
        var result = generator.Generate(10, configuration);

        // Assert
        Assert.All(result, x =>
        {
            Assert.True(DateOnly.TryParse(x.Fields[0], out var dateRecent));
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

        var generator = new Generator();

        // Act
        var result = generator.Generate(10, configuration);

        // Assert
        Assert.All(result, x =>
        {
            Assert.True(DateOnly.TryParse(x.Fields[0], out var dateRecent));
            Assert.True(dateRecent >= DateOnly.FromDateTime(DateTime.Today));
        });
    }
}
