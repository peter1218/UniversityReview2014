namespace UniversityReview.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UniversityReview.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UniversityReview.Models.UniRatingDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(UniversityReview.Models.UniRatingDB context)
        {
            //  This method will be called after migrating to the latest version.

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
            context.Universities.AddOrUpdate(r => r.Name,
          new University { Name = "Flinders Uni", City = "Adelaide" },
          new University { Name = "Adelaide Uni", City = "Adelaide" },
          new University
          {
              Name = "Sydney Uni",
              City = "Sydney",

              Reviews =
                  new List<UniversityReviews> { 
                       new UniversityReviews { Rating = 9, Body="Great University", ReviewerName="peter" }
                   }
          });

            for (int i = 0; i < 1000; i++)
            {
                context.Universities.AddOrUpdate(r => r.Name,
                    new University { Name = i.ToString(), City = "Nowhere" });
            }

           // SeedMembership();


        }
    }
}
