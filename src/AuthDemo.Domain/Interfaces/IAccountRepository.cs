using AuthDemo.Domain.Models;
using System.Collections.Generic;

namespace AuthDemo.Domain.Interfaces
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts();
    }
}
