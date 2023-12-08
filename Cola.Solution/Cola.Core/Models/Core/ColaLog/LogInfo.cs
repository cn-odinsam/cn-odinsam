using Cola.Core.Models.Enums.Logs;

namespace Cola.Core.Models.Core.ColaLog;

public class LogInfo
{
    public long? LogId { get; set; } = null;
    public string LogContent { get; set; } = "";
    public string LogMark { get; set; } = "";
    public EnumLogSaveType[] LogSaveType { get; set; } = { EnumLogSaveType.File };
}