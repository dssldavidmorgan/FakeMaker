using System.Xml;

namespace FakeMaker.Core;

public static class ConfigurationSerializer
{
    public static Configuration Load(Stream stream)
    {
        var xmlDocument = new XmlDocument();

        var configuration = new Configuration();

        try
        {
            xmlDocument.Load(stream);
        }
        catch
        {
            return configuration;
        }

        if (xmlDocument.DocumentElement is null)
            return configuration;

        var columnNodes = xmlDocument.DocumentElement.GetElementsByTagName("column").Cast<XmlNode>();

        foreach (var columnNode in columnNodes)
        {
            if (columnNode.Attributes is null)
                continue;

            var nameNode = columnNode.Attributes.GetNamedItem("name");
            var typeNode = columnNode.Attributes.GetNamedItem("type");

            if (nameNode is null || typeNode is null)
                continue;

            if (string.IsNullOrWhiteSpace(nameNode.Value))
                continue;

            if (!Enum.TryParse<DataType>(typeNode.Value, out var dataType))
                continue;

            var column = new Column()
            {
                Name = nameNode.Value,
                Type = dataType,
            };

            configuration.Columns.Add(column);
        }

        return configuration;
    }

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
