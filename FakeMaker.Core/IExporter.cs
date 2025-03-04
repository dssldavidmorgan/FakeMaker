namespace FakeMaker.Core;

public interface IExporter
{
    void Export(Stream stream, IEnumerable<Record> records, Configuration configuration);
}
