namespace FakeMaker.Core;

public class InvalidCustomDataTypeNameException : Exception
{
    public InvalidCustomDataTypeNameException(string customDataTypeName)
        : base($"The configuration has no custom data type named '{customDataTypeName}'")
    {
    }
}
