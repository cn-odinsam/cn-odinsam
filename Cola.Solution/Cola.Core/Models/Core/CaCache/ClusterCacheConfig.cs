namespace Cola.Core.Models.Core.CaCache;

/// <summary>
///     集群模式
/// </summary>
public class ClusterCacheConfig : RedisCacheConfig
{
    public string? Masters { get; set; }
    public string? Slaves { get; set; }
}