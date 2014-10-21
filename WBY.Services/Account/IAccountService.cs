using WBY.Domain.Models;

namespace WBY.Services.Account
{
    public interface IAccountService
    {
        void SaveUser(UserProfile user);
        UserProfile GetUser(string userName);
        UserProfile GetUser(int userId);
    }
}