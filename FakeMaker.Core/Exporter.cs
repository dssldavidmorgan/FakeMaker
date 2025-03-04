namespace FakeMaker.Core;

public class Exporter : IExporter
{
    public void Export(Stream stream, IEnumerable<Record> records, Configuration configuration)
    {
        using var writer = new StreamWriter(stream, leaveOpen: true);

        for (var i = 0; i < configuration.Columns.Count; ++i)
        {
            writer.Write(configuration.Columns[i].Name);

            if (i < configuration.Columns.Count - 1)
                writer.Write(',');
        }

        writer.Flush();
    }
}
