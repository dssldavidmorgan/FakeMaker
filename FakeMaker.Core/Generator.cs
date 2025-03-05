using Bogus;

namespace FakeMaker.Core;

public class Generator : IGenerator
{
    private readonly Faker faker = new();

    public IEnumerable<Record> Generate(int count, Configuration configuration)
    {
        for (var i = 0; i < count; ++i)
            yield return GenerateRecord(configuration);
    }

    private Record GenerateRecord(Configuration configuration)
    {
        var fields = configuration.Columns.Select(GenerateField);

        return new Record([.. fields]);
    }

    private string GenerateField(Column column)
    {
        return column.Type switch
        {
            DataType.FirstName => faker.Name.FirstName(),
            DataType.LastName => faker.Name.LastName(),
            DataType.EnrolmentNumber => faker.Commerce.Ean8(),
            DataType.EmailAddress => faker.Internet.Email(),
            DataType.DateRecent => faker.Date.RecentDateOnly().ToString(),
            DataType.DateSoon => faker.Date.SoonDateOnly().ToString(),
            _ => throw new NotImplementedException(),
        };
    }
}
