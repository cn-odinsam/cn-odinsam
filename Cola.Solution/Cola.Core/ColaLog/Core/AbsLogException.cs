using Cola.Core.Models.Core.ColaLog;
using Cola.Core.Models.Enums.Logs;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog.Core;

public abstract class AbsLogException : AbsColaLogException
{
    protected AbsLogException(EnumLogLevel logLevel, LogConfig config, IServiceCollection? service) : base(logLevel,
        config, service)
    {
    }

    private LogResponse? WriteLog(string logContent)
    {
        return null;
    }
}