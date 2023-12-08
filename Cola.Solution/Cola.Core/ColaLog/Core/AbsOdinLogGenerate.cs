using Cola.Core.Models.Core.ColaLog;
using Cola.Core.Models.Enums.Logs;

namespace Cola.Core.ColaLog.Core;

public abstract class AbsOdinLogGenerate : IColaLog
{
    protected LogConfig? Config;
    public abstract LogModel GenerateLog(EnumLogLevel logLevel, LogInfo log);
}