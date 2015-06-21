using System.Data.Entity;
using System.Linq;

namespace GasModelWin.Models
{
    public class GasContext : DbContext
    {
        public DbSet<Gas> Gases { get; set; }
        public DbSet<GasTemperature> GasTemperatures { get; set; }
        public DbSet<AdiabaticConstant> AdiabaticConstants { get; set; }
        public DbSet<VanderWaalsCoeffs> VanderWaalsCoeffses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogins> UserLoginses { get; set; }
        public DbSet<Result> Results { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var properties = new[]
            {
                modelBuilder.Entity<Result>().Property(r => r.GasVolume),
                modelBuilder.Entity<Result>().Property(r => r.GasTemperature),
                modelBuilder.Entity<Result>().Property(r => r.EnvironmentPressure1),
                modelBuilder.Entity<Result>().Property(r => r.EnvironmentPressure2),
                modelBuilder.Entity<Result>().Property(r => r.ModelingResult),
                modelBuilder.Entity<Result>().Property(r => r.Radius),
                modelBuilder.Entity<Result>().Property(r => r.SolarRadiation),
                modelBuilder.Entity<Result>().Property(r => r.TubeWeight),
                modelBuilder.Entity<Result>().Property(r => r.HeatQuantity),
                modelBuilder.Entity<Result>().Property(r => r.MeltingTime),
                modelBuilder.Entity<GasTemperature>().Property(g => g.Temperature),
                modelBuilder.Entity<GasTemperature>().Property(g => g.Cp),
                modelBuilder.Entity<AdiabaticConstant>().Property(a => a.K),
                modelBuilder.Entity<VanderWaalsCoeffs>().Property(v => v.A),
                modelBuilder.Entity<VanderWaalsCoeffs>().Property(v => v.B)
            };

            properties.ToList().ForEach(property => property.HasPrecision(18, 4));

            base.OnModelCreating(modelBuilder);
        }
    }
}
