using Cola.Core.Models.Core.ColaLog;
using Cola.Core.Models.Enums.Logs;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog.Core;

public abstract class AbsLogContent : AbsColaLogContent
{
    protected AbsLogContent(EnumLogLevel logLevel, LogConfig config, IServiceCollection? service) : base(logLevel,
        config, service)
    {
    }

    private LogResponse? WriteLog(Exception exception, long? logId = null)
    {
        return null;
    }
}