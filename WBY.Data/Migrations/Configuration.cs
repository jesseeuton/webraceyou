using WBY.Data;
using WBY.Domain.Models;

namespace WBY.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WbyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WbyContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.UserProfiles.AddOrUpdate(
                u => u.UserName,
                new UserProfile() { UserName="Admin"});

            context.Substances.AddOrUpdate(
                s => s.Name,
                new Substance {Id = 1, Name = "Alchohol"},
                new Substance { Id = 2, Name="Nictoine"},
                new Substance { Id = 3, Name = "Caffiene" }
            );

            context.SubstanceUnits.AddOrUpdate(
                su => su.Name,
                new SubstanceUnit() {Id=1, Name="Oz"},
                new SubstanceUnit() {Id=2, Name="Bottle"},
                new SubstanceUnit() {Id=3, Name="6-Pack"},
                new SubstanceUnit() {Id=4, Name="Can"},
                new SubstanceUnit() {Id=5, Name="Case"}
            );

            context.SubstanceVehicles.AddOrUpdate(
                sv => sv.Name,
                new SubstanceVehicle() { Id = 1, Name = "Beer", SubstanceId = 1},
                new SubstanceVehicle() { Id = 2, Name = "Wine", SubstanceId = 1},
                new SubstanceVehicle() { Id = 3, Name = "Tequila", SubstanceId = 1},
                new SubstanceVehicle() { Id = 4, Name = "Vodka", SubstanceId = 1},
                new SubstanceVehicle() { Id = 5, Name = "Whiskey", SubstanceId = 1},
                new SubstanceVehicle() { Id = 6, Name = "Rum", SubstanceId = 1 },
                new SubstanceVehicle() { Id = 7, Name = "Gin", SubstanceId = 1 },
                new SubstanceVehicle() { Id = 8, Name = "Cigarettes", SubstanceId = 2 },
                new SubstanceVehicle() { Id = 9, Name = "Dip", SubstanceId = 2 },
                new SubstanceVehicle() { Id = 10, Name = "Chewing Tobacco", SubstanceId = 2 },
                new SubstanceVehicle() { Id = 11, Name = "Gum", SubstanceId = 2 },
                new SubstanceVehicle() { Id = 12, Name = "Patches", SubstanceId = 2 },
                new SubstanceVehicle() { Id = 13, Name = "Coffee", SubstanceId = 3 },
                new SubstanceVehicle() { Id = 14, Name = "Tea", SubstanceId = 3 },
                new SubstanceVehicle() { Id = 15, Name = "Energy Drink", SubstanceId = 3 },
                new SubstanceVehicle() { Id = 16, Name = "Pill", SubstanceId = 3 }
            );

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
