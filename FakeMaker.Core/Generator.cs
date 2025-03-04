namespace FakeMaker.Core;

public class Generator : IGenerator
{
    public IEnumerable<Record> Generate(int count, Configuration configuration)
    {
        for (var i = 0; i < count; ++i)
            yield return GenerateRecord(configuration);
    }

    private static Record GenerateRecord(Configuration configuration)
    {
        return new Record(Fields: []);
    }
}
