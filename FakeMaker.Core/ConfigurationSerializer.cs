using System.Xml;

namespace FakeMaker.Core;

public static class ConfigurationSerializer
{
    public static void Save(Configuration configuration, Stream stream)
    {
        var newLine = Environment.NewLine;
        var indentation = new string([.. Enumerable.Repeat(' ', 4)]);

        var xmlDocument = new XmlDocument();
        var documentElement = xmlDocument.CreateElement("configuration");
        xmlDocument.AppendChild(documentElement);

        if (configuration.Columns.Count > 0)
            documentElement.AppendChild(xmlDocument.CreateWhitespace(newLine));

        foreach (var column in configuration.Columns)
        {
            var columnElement = xmlDocument.CreateElement("column");
            columnElement.SetAttribute("name", column.Name);
            columnElement.SetAttribute("type", column.Type.ToString());

            documentElement.AppendChild(xmlDocument.CreateWhitespace(indentation));
            documentElement.AppendChild(columnElement);
            documentElement.AppendChild(xmlDocument.CreateWhitespace(newLine));
        }

        xmlDocument.Save(stream);
    }
}
