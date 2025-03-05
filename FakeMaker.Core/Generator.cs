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

    private static Record GenerateRecord(Configuration configuration)
    {
        var fields = Enumerable.Repeat(string.Empty, configuration.Columns.Count);

        return new Record([.. fields]);
    }
}
