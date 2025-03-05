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
}
