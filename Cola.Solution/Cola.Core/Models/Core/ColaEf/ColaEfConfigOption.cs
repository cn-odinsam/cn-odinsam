namespace Cola.Core.Models.Core.ColaEf;

public class ColaEfConfigOption
{
    public string TenantResolutionStrategy { get; set; } = "NoTenant";
    public List<ColaEfConfig>? ColaOrmConfig { get; set; }
}