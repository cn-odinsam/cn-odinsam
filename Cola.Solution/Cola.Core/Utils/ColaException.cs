using Cola.Core.Utils.Enums;
using Cola.Core.Utils.Extensions;

namespace Cola.Core.Utils;

public class UtilsException : System.Exception
{
    public UtilsException(EnumException enumException) : base(enumException.GetDescription())
    {
    }

    public UtilsException(EnumException enumException, string msg) : base(string.Format(enumException.GetDescription(), msg))
    {
    }

    public UtilsException(string errorMessage) : base(errorMessage)
    {
    }
}