using System;
using System.Collections.Generic;
using WBY.Data.Repos;
using WBY.Domain.Models;

namespace WBY.Services.Account
{
    public class AccountService : IAccountService
    {
        private IUserRepo _userRepo;
        public AccountService() : this(new UserRepo())
        {
            
        }

        public AccountService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public void SaveUser(UserProfile user)
        {
            _userRepo.Save(user);
        }

        public UserProfile GetUser(int userId)
        {
            return _userRepo.GetUser(userId);
        }

        public UserProfile GetUser(string userId)
        {
            return _userRepo.GetUser(userId);
        }

        public List<UserProfile> GetUsers()
        {
            return _userRepo.GetUsers();
        }
    }
}