using System.Xml;

namespace FakeMaker.Core;

public static class ConfigurationDeserializer
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

        LoadColumns(xmlDocument, configuration);
        LoadCustomDataTypes(xmlDocument, configuration);

        return configuration;
    }

    private static void LoadColumns(XmlDocument xmlDocument, Configuration configuration)
    {
        var columnNodes = xmlDocument.DocumentElement!.GetElementsByTagName("column").Cast<XmlNode>();

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
    }

    private static void LoadCustomDataTypes(XmlDocument xmlDocument, Configuration configuration)
    {
        var customDataTypeNodes = xmlDocument.DocumentElement!.GetElementsByTagName("customDataType").Cast<XmlNode>();

        foreach (var customDataTypeNode in customDataTypeNodes)
        {
            if (customDataTypeNode.Attributes is null)
                continue;

            var nameNode = customDataTypeNode.Attributes.GetNamedItem("name");
            var valueNodes = customDataTypeNode.SelectNodes("value")?.Cast<XmlNode>();

            if (nameNode is null || valueNodes is null)
                continue;

            if (string.IsNullOrWhiteSpace(nameNode.Value))
                continue;

            var customDataType = new CustomDataType()
            {
                Name = nameNode.Value,
                Values = [.. valueNodes.Select(x => x.InnerText)],
            };

            configuration.CustomDataTypes.Add(customDataType);
        }
    }
}
