namespace aermovies.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using aermovies.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<aermovies.Models.aermoviesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(aermovies.Models.aermoviesContext context)
        {
            context.Movies.AddOrUpdate(x => x.Id,
                new Movie()
                {
                    Id = 1,
                    Title = "Dodgeball",
                    Category = "Comedy",
                    Details = "Comedy starring Ben Stiller",
                    imageurl = "http://www.gstatic.com/tv/thumb/v22vodart/33984/p33984_v_v8_ak.jpg",
                },
                new Movie()
                {
                    Id = 2,
                    Title = "Hot Fuzz",
                    Category = "Comedy",
                    Details = "Comedy starring Simon Pegg",
                    imageurl = "http://www.gstatic.com/tv/thumb/v22vodart/163411/p163411_v_v8_ac.jpg",
                },
                new Movie()
                {
                    Id = 3,
                    Title = "Die Hard",
                    Category = "Action",
                    Details = "Action starring Bruce Willis",
                    imageurl = "http://www.gstatic.com/tv/thumb/v22vodart/10255/p10255_v_v8_aa.jpg",
                },
                new Movie()
                {
                    Id = 4,
                    Title = "Ready Player One",
                    Category = "Action",
                    Details = "Action directed by Steven Spielberg",
                    imageurl = "http://www.gstatic.com/tv/thumb/v22vodart/12806300/p12806300_v_v8_ac.jpg",
                }
            );
        }
    }
}
