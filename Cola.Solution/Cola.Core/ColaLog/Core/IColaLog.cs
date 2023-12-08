using Cola.Core.Models.Core.ColaLog;
using Cola.Core.Models.Enums.Logs;

namespace Cola.Core.ColaLog.Core;

public interface IColaLog
{
    LogModel GenerateLog(EnumLogLevel logLevel, LogInfo log);
}