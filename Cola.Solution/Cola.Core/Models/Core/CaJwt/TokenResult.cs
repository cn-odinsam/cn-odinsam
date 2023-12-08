namespace Cola.Core.Models.Core.CaJwt;

public class TokenResult
{
    public AccessToken Token { get; set; }
    
    public RefreshToken RefreshToken { get; set; }
}