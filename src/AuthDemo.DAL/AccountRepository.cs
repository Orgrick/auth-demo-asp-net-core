using AuthDemo.Domain.Interfaces;
using AuthDemo.Domain.Models;
using System;
using System.Collections.Generic;

namespace AuthDemo.DAL
{
    public class AccountRepository : IAccountRepository
    {
        public List<Account> GetAccounts()
        {
            var Accounts = new List<Account>
             {
                    new Account()
                    {
                        id = Guid.Parse("4134280b-aa8a-45ad-aa98-53da12eabc05"),
                        Email = "user@email.com",
                        Password = "user",
                        Roles = new Role[] {Role.User}
                    },
                    new Account()
                    {
                        id = Guid.Parse("f53d58c1-ab30-4d05-b265-7a9db9efb413"),
                        Email = "user2@email.com",
                        Password = "user2",
                        Roles = new Role[] {Role.User}
                    },
                    new Account()
                    {
                        id = Guid.Parse("283aba9e-c935-4ac3-b8e6-f30c4a95e100"),
                        Email = "admin@email.com",
                        Password = "admin",
                        Roles = new Role[] {Role.Admin}
                    }
             };

            return Accounts;
        }
    }
}
