using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WBY.Web.Models
{
    public class SecurityBasicsContext : DbContext
    {
        public SecurityBasicsContext()
            : base("name=DefaultConnection")
        {

        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserProfilePreference> UserProfilePreferences { get; set; }
        public DbSet<Substance> Substances { get; set; }
        public DbSet<SubstanceVehicle> SubstanceVehicles { get; set; }
        public DbSet<ExtraUserInformation> ExternalUsers { get; set; }
    }
}