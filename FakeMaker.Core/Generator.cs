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
        var fields = configuration.Columns.Select(c => GenerateField(c, faker));

        var dataRow = dataTable.NewRow();
        dataRow.ItemArray = [.. fields];

        return dataRow;
    }

    private static string GenerateField(Column column, Faker faker)
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
            _ => throw new NotImplementedException(),
        };
    }
}
