using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DB.Model;

namespace TMS_DB.Context
{
    public class TMS_DB_Connect : DbContext
    {
        public DbSet<ContractMarketplace> ContractMarketplaces { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Buyer> Buyers { get; set; }

        public DbSet<Planner> Planners { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Carrier> Carriers { get; set; }

        public DbSet<Trips> Trips { get; set; }

        public DbSet<RateFee> RateFees { get; set; }

        public DbSet<Route> Routes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "server=localhost;port=3306;database=TMS_DB;user=root;password=17039125Ss#";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
