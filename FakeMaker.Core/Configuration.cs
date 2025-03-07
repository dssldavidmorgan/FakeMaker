namespace FakeMaker.Core;

public class Configuration
{
    public List<Column> Columns { get; init; } = [];

    public List<CustomDataType> CustomDataTypes { get; init; } = [];
}
