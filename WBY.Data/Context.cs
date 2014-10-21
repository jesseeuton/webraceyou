using System.Data.Entity;
using WBY.Domain.Models;

namespace WBY.Data
{
    public class WbyContext : DbContext
    {
        public WbyContext()
            : base("name=DefaultConnection")
        {

        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserProfilePreference> UserProfilePreferences { get; set; }
        public DbSet<Substance> Substances { get; set; }
        public DbSet<SubstanceVehicle> SubstanceVehicles { get; set; }
        public DbSet<ExtraUserInformation> ExternalUsers { get; set; }
        public DbSet<SubstanceUnit> SubstanceUnits { get; set; }
    }
}