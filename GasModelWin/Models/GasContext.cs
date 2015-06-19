using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
