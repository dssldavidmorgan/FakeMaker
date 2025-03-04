namespace FakeMaker.Core;

public interface IGenerator
{
    IEnumerable<Record> Generate(int count, Configuration configuration);
}
