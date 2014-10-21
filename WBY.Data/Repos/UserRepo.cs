using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBY.Domain.Models;

namespace WBY.Data.Repos
{
    public class UserRepo : IUserRepo
    {
        public UserRepo()
        {
        }

        public UserProfile GetUser(int userId)
        {
            using (WbyContext context = new WbyContext())
            {
                return context.UserProfiles.FirstOrDefault(p => p.Id == userId);
            }
        }

        public List<UserProfile> GetUsers()
        {
            using (WbyContext context = new WbyContext())
            {
                return context.UserProfiles.ToList();
            }
        }

        public void Save(UserProfile user)
        {
            using (WbyContext context = new WbyContext())
            {
                if (user.Id < 0)
                {
                    context.UserProfiles.Add(user);
                }
                else
                {
                    UserProfile profile = context.UserProfiles.First(p => p.Id == user.Id);
                    profile.Preferences = user.Preferences;
                    profile.Substances = user.Substances;
                    profile.UserName = user.UserName;
                    profile.History = user.History;
                }

                context.SaveChanges();
            }
        }


        public UserProfile GetUser(string userName)
        {
            using (WbyContext db = new WbyContext())
            {
                return db.UserProfiles.FirstOrDefault(u => u.UserName == userName);
            }
        }
    }
}
