using AuthDemo.Domain.Interfaces;
using AuthDemo.Domain.Models;
using System.Linq;

namespace AuthDemo.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAccountRepository _accountRepository;

        public AuthService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Account AuthenticateUser(string email, string password)
        {
            return _accountRepository.GetAccounts().SingleOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
