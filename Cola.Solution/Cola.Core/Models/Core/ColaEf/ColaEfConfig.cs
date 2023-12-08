using System.Data;
using Cola.Core.Utils.Extensions;

namespace Cola.Core.Models.Core.ColaEf;

public class ColaEfConfig
{
    public string? ConfigId { get; set; } = "1";
    public string? Domain { get; set; } = null;
    public string? DbType { get; set; }

    public string? ConnectionString { get; set; } = null;

    public bool IsAutoCloseConnection { get; set; } = true;

    public bool EnableLogAop { get; set; } = true;

    public bool EnableErrorAop { get; set; } = true;

    public bool EnableGlobalFilter { get; set; } = false;

    public DbType GetSqlSugarDbType()
    {
        if (string.IsNullOrEmpty(DbType)) throw new Exception("SqlSugar配置没有明确指定DbType");
        return DbType!.ConvertStringToEnum<DbType>();
    }
}