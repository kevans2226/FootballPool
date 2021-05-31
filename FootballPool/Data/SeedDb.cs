using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using FootballPool.Data.Db;
namespace FootballPool.Data
{
    public class SeedDb
    {
        public SeedDb()
        {
        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<WebDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            context.Database.EnsureCreated();
            if (!context.Users.Any())
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = "test@gmail.com",
                    UserName = "test",
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                userManager.CreateAsync(user, "Test@123");
            }
        }

        public static void SeedTeams(IServiceProvider serviceProvider) { 
            var context = serviceProvider.GetRequiredService<WebDbContext>(); 
            context.Database.EnsureCreated(); 

            if(!context.Teams.Any()) { 
                context.Teams.Add( new Team() { Location ="Oakland", Mascot = "Raiders", Image = "Raiders.gif",BackgroundColor="#000", Color="#C4C8CB"});
                context.Teams.Add( new Team() { Location ="New England", Mascot = "Patriots", Image = "Pats.gif",BackgroundColor="#c80815", Color="#0D254C"});
                context.Teams.Add( new Team() { Location ="Chicago", Mascot = "Bears", Image = "Bears.gif",BackgroundColor="#DD4814", Color="#051C2C"});
                context.Teams.Add( new Team() { Location ="Washington", Mascot = "Washington", Image = "skins.gif",BackgroundColor="#862633", Color="#FFCD00"});
                context.Teams.Add( new Team() { Location ="Cincinnati", Mascot = "Bengals", Image = "Bengals.gif",BackgroundColor="#FC4C02", Color="#101820"});
                context.Teams.Add( new Team() { Location ="Cleveland", Mascot = "Browns", Image = "Browns.gif",BackgroundColor="#EB3300", Color="#382F2D"});
                context.Teams.Add( new Team() { Location ="Denver", Mascot = "Broncos", Image = "Broncos.gif",BackgroundColor="#FB4F01", Color="#0C2340"});
                context.Teams.Add( new Team() { Location ="Miami", Mascot = "Dolphins", Image = "Dolphins.gif",BackgroundColor="#008E97", Color="#F58220"});
                context.Teams.Add( new Team() { Location ="Houston", Mascot = "Texans", Image = "Texans.gif",BackgroundColor="#A6192E", Color="#091F2C"});
                context.Teams.Add( new Team() { Location ="Buffalo", Mascot = "Bills", Image = "bills.gif",BackgroundColor="#C60C30", Color="#00338D"});
                context.Teams.Add( new Team() { Location ="New Orleans", Mascot = "Saints", Image = "Saints.gif",BackgroundColor="#000", Color="#D2B887"});
                context.Teams.Add( new Team() { Location ="Carolina", Mascot = "Panthers", Image = "panthers.gif",BackgroundColor="#0085CA", Color="#101820"});
                context.Teams.Add( new Team() { Location ="New York", Mascot = "Jets", Image = "Jets.gif",BackgroundColor="#0C371D", Color="#fff"});
                context.Teams.Add( new Team() { Location ="Kansas City", Mascot = "Chiefs", Image = "Chiefs.gif",BackgroundColor="#b20032", Color="#F2C800"});
                context.Teams.Add( new Team() { Location ="Seattle", Mascot = "Seahawks", Image = "Seahawks.gif",BackgroundColor="#001433", Color="#4DFF00"});
                context.Teams.Add( new Team() { Location ="Jacksonville", Mascot = "Jaguars", Image = "Jags.gif",BackgroundColor="#006778", Color="#fff"});
                context.Teams.Add( new Team() { Location ="Tampa Bay", Mascot = "Buccaneers", Image = "Bucs.gif",BackgroundColor="#D60A0B", Color="#fff"});
                context.Teams.Add( new Team() { Location ="Tennessee", Mascot = "Titans", Image = "Titans.gif",BackgroundColor="#0c2340", Color="#4B92DB"});
                context.Teams.Add( new Team() { Location ="Pittsburgh", Mascot = "Steelers", Image = "Steelers.gif",BackgroundColor="#000", Color="#FFB612"});
                context.Teams.Add( new Team() { Location ="Minnesota", Mascot = "Vikings", Image = "Vikings.gif",BackgroundColor="#3B0160", Color="#F0BF00"});
                context.Teams.Add( new Team() { Location ="Arizona", Mascot = "Cardinals", Image = "Cards.gif",BackgroundColor="#9B2743", Color="#FFCD00"});
                context.Teams.Add( new Team() { Location ="New York", Mascot = "Giants", Image = "Giants.gif",BackgroundColor="#001E62", Color="#A6192E"});
                context.Teams.Add( new Team() { Location ="Dallas", Mascot = "Cowboys", Image = "Cowboys.gif",BackgroundColor="#041E42", Color="#869397"});
                context.Teams.Add( new Team() { Location ="Los Angeles", Mascot = "Chargers", Image = "Chargers.gif",BackgroundColor="#0072CE", Color="#FFB81C"});
                context.Teams.Add( new Team() { Location ="Green Bay", Mascot = "Packers", Image = "Packers.gif",BackgroundColor="#203731", Color="#FFB81C"});
                context.Teams.Add( new Team() { Location ="Detroit", Mascot = "Lions", Image = "Lions.gif",BackgroundColor="#0069B1", Color="#A2AAAD"});
                context.Teams.Add( new Team() { Location ="Los Angeles", Mascot = "Rams", Image = "Rams.gif",BackgroundColor="#13264B", Color="#FFFFFF"});
                context.Teams.Add( new Team() { Location ="San Francisco", Mascot = "Forty Niners", Image = "Niners.gif",BackgroundColor="#9B2743", Color="#fff"});
                context.Teams.Add( new Team() { Location ="Indianapolis", Mascot = "Colts", Image = "Colts.gif",BackgroundColor="#003B7B", Color="#fff"});
                context.Teams.Add( new Team() { Location ="Baltimore", Mascot = "Ravens", Image = "Ravens.gif",BackgroundColor="#241773", Color="#D0B240"});
                context.Teams.Add( new Team() { Location ="Philadelphia", Mascot = "Eagles", Image = "Eagles.gif",BackgroundColor="#003B48", Color="#869397"});
                context.Teams.Add( new Team() { Location ="Atlanta", Mascot = "Falcons", Image = "Falcons.gif",BackgroundColor="#A6192E", Color="#101820"});

                context.SaveChanges();
            }
        }
    }
}
