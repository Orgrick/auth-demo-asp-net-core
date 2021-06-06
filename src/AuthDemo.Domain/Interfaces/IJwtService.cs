using AuthDemo.Domain.Models;

namespace AuthDemo.Domain.Interfaces
{
    public interface IJwtService
    {
        string GenerateJWT(Account account);
    }
}
