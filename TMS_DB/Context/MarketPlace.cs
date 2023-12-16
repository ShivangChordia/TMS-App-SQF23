using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DB.Model;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.IO;

namespace TMS_DB.Context
{
    public class MarketPlace : DbContext
    {


        public DbSet<ContractMarketplace> contracts  { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "server=159.89.117.198;port=3306;database=cmp;user=DevOSHT;password=Snodgr4ss!";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

    }
}




