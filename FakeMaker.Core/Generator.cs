using Bogus;
using System.Data;

namespace FakeMaker.Core;

public static class Generator
{
    public static DataTable Generate(int count, Configuration configuration)
    {
        var faker = new Faker();
        var dataTable = new DataTable();

        var columns = configuration.Columns.Select(c => new DataColumn(c.Name));
        dataTable.Columns.AddRange([.. columns]);

        for (var i = 0; i < count; ++i)
        {
            var dataRow = GenerateRecord(configuration, dataTable, faker);
            dataTable.Rows.Add(dataRow);
        }

        return dataTable;
    }

    private static DataRow GenerateRecord(Configuration configuration, DataTable dataTable, Faker faker)
    {
        var fields = configuration.Columns.Select(c => GenerateField(configuration, c, faker));

        var dataRow = dataTable.NewRow();
        dataRow.ItemArray = [.. fields];

        return dataRow;
    }

    private static string GenerateField(Configuration configuration, Column column, Faker faker)
    {
        return column.Type switch
        {
            DataType.FirstName => faker.Name.FirstName(),
            DataType.LastName => faker.Name.LastName(),
            DataType.EnrolmentNumber => faker.Commerce.Ean8(),
            DataType.EmailAddress => faker.Internet.Email(),
            DataType.DateRecent => faker.Date.RecentDateOnly().ToString(),
            DataType.DateSoon => faker.Date.SoonDateOnly().ToString(),
            DataType.DateOfBirth => faker.Date.PastDateOnly(5, DateOnly.FromDateTime(DateTime.Today.AddYears(-18))).ToString(),
            DataType.Address => faker.Address.StreetAddress(),
            DataType.StreetName => faker.Address.StreetName(),
            DataType.Custom => GenerateCustomData(configuration, column),
            _ => throw new NotImplementedException(),
        };
    }

    private static string GenerateCustomData(Configuration configuration, Column column)
    {
        var customDataType = configuration.CustomDataTypes.FirstOrDefault(x => x.Name == column.CustomDataTypeName)
            ?? throw new InvalidCustomDataTypeNameException(column.CustomDataTypeName ?? string.Empty);

        var randomIndex = Random.Shared.Next(customDataType.Values.Count);
        var value = customDataType.Values.ElementAt(randomIndex);

        return value;
    }
}
