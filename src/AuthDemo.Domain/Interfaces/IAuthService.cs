using AuthDemo.Domain.Models;

namespace AuthDemo.Domain.Interfaces
{
    public interface IAuthService
    {
        Account AuthenticateUser(string email, string password);
    }
}
