namespace FakeMaker.Core;

public class CustomDataType
{
    public required string Name { get; set; }

    public required HashSet<string> Values { get; set; } = [];
}
