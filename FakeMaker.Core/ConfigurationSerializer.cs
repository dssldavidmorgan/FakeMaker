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

        if (configuration.Columns.Count > 0 || configuration.CustomDataTypes.Count > 0)
            documentElement.AppendChild(xmlDocument.CreateWhitespace(newLine));

        SaveColumns(configuration, newLine, indentation, xmlDocument, documentElement);
        SaveCustomDataTypes(configuration, newLine, indentation, xmlDocument, documentElement);

        xmlDocument.Save(stream);
    }

    private static void SaveColumns(Configuration configuration, string newLine, string indentation, XmlDocument xmlDocument, XmlElement documentElement)
    {
        foreach (var column in configuration.Columns)
        {
            var columnElement = xmlDocument.CreateElement("column");
            columnElement.SetAttribute("name", column.Name);
            columnElement.SetAttribute("type", column.Type.ToString());

            documentElement.AppendChild(xmlDocument.CreateWhitespace(indentation));
            documentElement.AppendChild(columnElement);
            documentElement.AppendChild(xmlDocument.CreateWhitespace(newLine));
        }
    }

    private static void SaveCustomDataTypes(Configuration configuration, string newLine, string indentation, XmlDocument xmlDocument, XmlElement documentElement)
    {
        foreach (var customDataType in configuration.CustomDataTypes)
        {
            var customDataTypeElement = xmlDocument.CreateElement("customDataType");
            customDataTypeElement.SetAttribute("name", customDataType.Name);

            documentElement.AppendChild(xmlDocument.CreateWhitespace(indentation));
            documentElement.AppendChild(customDataTypeElement);
            documentElement.AppendChild(xmlDocument.CreateWhitespace(newLine));
            customDataTypeElement.AppendChild(xmlDocument.CreateWhitespace(newLine));
            customDataTypeElement.AppendChild(xmlDocument.CreateWhitespace(indentation));

            foreach (var value in customDataType.Values)
            {
                var valueElement = xmlDocument.CreateElement("value");
                valueElement.InnerText = value;

                customDataTypeElement.AppendChild(xmlDocument.CreateWhitespace(indentation));
                customDataTypeElement.AppendChild(valueElement);
                customDataTypeElement.AppendChild(xmlDocument.CreateWhitespace(newLine));
                customDataTypeElement.AppendChild(xmlDocument.CreateWhitespace(indentation));
            }
        }
    }
}
