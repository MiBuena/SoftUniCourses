using System.Runtime.InteropServices;
using FootballBettingDatabase.Models;

namespace FootballBettingDatabase.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FootballBettingContext : DbContext
    {
        // Your context has been configured to use a 'FootballBettingContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FootballBettingDatabase.Data.FootballBettingContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FootballBettingContext' 
        // connection string in the application configuration file.
        public FootballBettingContext()
            : base("name=FootballBettingContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual IDbSet<Bet> Bets { get; set; }

        public virtual IDbSet<BetGame> BetGames { get; set; }

        public virtual IDbSet<Color> Colors { get; set; }

        public virtual IDbSet<Competition> Competitions { get; set; }

        public virtual IDbSet<CompetitionType> CompetitionTypes { get; set; }

        public virtual IDbSet<Continent> Continents { get; set; }

        public virtual IDbSet<Country> Countries { get; set; }

        public virtual IDbSet<Game> Games { get; set; }

        public virtual IDbSet<Player> Players { get; set; }

        public virtual IDbSet<PlayerStatistics> PlayerStatistics { get; set; }

        public virtual IDbSet<Position> Positions { get; set; }

        public virtual IDbSet<ResultPrediction> ResultPredictions { get; set; }

        public virtual IDbSet<Round> Rounds { get; set; }

        public virtual IDbSet<Team> Teams { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<User> Users { get; set; }












    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}