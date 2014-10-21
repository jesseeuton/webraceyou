using System.Collections.Generic;
using WBY.Domain.Models;

namespace WBY.Data.Repos
{
    public interface IUserRepo
    {
        UserProfile GetUser(int userId);
        UserProfile GetUser(string userName);
        List<UserProfile> GetUsers();
        void Save(UserProfile user);
    }
}
