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

        public DbSet<LogEntry> LogEntries { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "server=localhost;port=3306;database=TMS_DB;user=root;password=17039125Ss#";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Admin>().HasData(
                 new Admin
                 {
                     AdminId = 1,
                     AdminName = "Admin1",
                     AdminPassword = "Password1",
                     AdminDOB = new DateTime(1990, 1, 1),
                     AdminEmail = "admin1@example.com",
                     AdminPhone = "1234567890"
                 },
        new Admin
        {
            AdminId = 2,
            AdminName = "Admin2",
            AdminPassword = "Password2",
            AdminDOB = new DateTime(1991, 2, 2),
            AdminEmail = "admin2@example.com",
            AdminPhone = "2345678901"
        },
        // Add more admins similarly...
        new Admin
        {
            AdminId = 3,
            AdminName = "Admin3",
            AdminPassword = "Password3",
            AdminDOB = new DateTime(1996, 7, 7),
            AdminEmail = "admin3@example.com",
            AdminPhone = "7890123456"
        }
    );

            modelBuilder.Entity<Buyer>().HasData(
                 new Buyer
                 {
                     BuyerId = 1,
                     BuyerName = "Buyer1",
                     BuyerPassword = "Password1",
                     BuyerDOB = new DateTime(1990, 1, 1),
                     BuyerEmail = "Buyer1@example.com",
                     BuyerPhone = "1234567890"
                 },
        new Buyer
        {
          BuyerId = 2,
            BuyerName = "Buyer2",
            BuyerPassword = "Password2",
            BuyerDOB = new DateTime(1991, 2, 2),
            BuyerEmail = "Buyer2@example.com",
            BuyerPhone = "2345678901"
        },
        // Add more Buyers similarly...
        new Buyer
        {
            BuyerId = 3,
            BuyerName = "Buyer3",
            BuyerPassword = "Password3",
            BuyerDOB = new DateTime(1996, 7, 7),
            BuyerEmail = "Buyer3@example.com",
            BuyerPhone = "7890123456"
        }
    );

            modelBuilder.Entity<Planner>().HasData(
                 new Planner
                 {
                     PlannerId = 1,
                     PlannerName = "Planner1",
                     PlannerPassword = "Password1",
                     PlannerDOB = new DateTime(1990, 1, 1),
                     PlannerEmail = "Planner1@example.com",
                     PlannerPhone = "1234567890"
                 },
        new Planner
        {
            PlannerId = 2,
            PlannerName = "Planner2",
            PlannerPassword = "Password2",
            PlannerDOB = new DateTime(1991, 2, 2),
            PlannerEmail = "Planner2@example.com",
            PlannerPhone = "2345678901"
        },
        // Add more Planners similarly...
        new Planner
        {
            PlannerId = 3,
            PlannerName = "Planner3",
            PlannerPassword = "Password3",
            PlannerDOB = new DateTime(1996, 7, 7),
            PlannerEmail = "Planner3@example.com",
            PlannerPhone = "7890123456"
        }
    );

            modelBuilder.Entity<Carrier>().HasData(
                 new Carrier
                 {
                     CarrierID = 1,
                     CarrierName = "Planet Express",
                     DepotCity = "Windsor",
                     FTLAvailability = 50,
                     LTLAvailability = 640,
                     FTLRate = 5.21,
                     LTLRate = 0.3621,
                     ReefCharge = 0.08
                 },
                new Carrier
                {
                    CarrierID = 2,
                    CarrierName = "Planet Express",
                    DepotCity = "Hamilton",
                    FTLAvailability = 50,
                    LTLAvailability = 640,
                    FTLRate = 5.21,
                    LTLRate = 0.3621,
                    ReefCharge = 0.08
                },
                new Carrier
                {
                    CarrierID = 3,
                    CarrierName = "Planet Express",
                    DepotCity = "Oshawa",
                    FTLAvailability = 50,
                    LTLAvailability = 640,
                    FTLRate = 5.21,
                    LTLRate = 0.3621,
                    ReefCharge = 0.08
                },
                new Carrier
                {

                    CarrierID = 4,
                    CarrierName = "Planet Express",
                    DepotCity = "Belleville",
                    FTLAvailability = 50,
                    LTLAvailability = 640,
                    FTLRate = 5.21,
                    LTLRate = 0.3621,
                    ReefCharge = 0.08
                },
                new Carrier
                {

                    CarrierID = 5,
                    CarrierName = "Planet Express",
                    DepotCity = "Ottawa",
                    FTLAvailability = 50,
                    LTLAvailability = 640,
                    FTLRate = 5.21,
                    LTLRate = 0.3621,
                    ReefCharge = 0.08
                },
                new Carrier
                {
                    CarrierID = 6,
                    CarrierName = "Schooner's",
                    DepotCity = "London",
                    FTLAvailability = 18,
                    LTLAvailability = 98,
                    FTLRate = 5.05,
                    LTLRate = 0.3434,
                    ReefCharge = 0.07
                },
                new Carrier
                {
                    CarrierID = 7,
                    CarrierName = "Schooner's",
                    DepotCity = "Toronto",
                    FTLAvailability = 18,
                    LTLAvailability = 98,
                    FTLRate = 5.05,
                    LTLRate = 0.3434,
                    ReefCharge = 0.07
                },
                new Carrier
                {
                    CarrierID = 8,
                    CarrierName = "Schooner's",
                    DepotCity = "Kingston",
                    FTLAvailability = 18,
                    LTLAvailability = 98,
                    FTLRate = 5.05,
                    LTLRate = 0.3434,
                    ReefCharge = 0.07
                },
                new Carrier
                {
                    CarrierID = 9,
                    CarrierName = "Tillman Transport",
                    DepotCity = "Windsor",
                    FTLAvailability = 24,
                    LTLAvailability = 35,
                    FTLRate = 5.11,
                    LTLRate = 0.3012,
                    ReefCharge = 0.09
                },
                new Carrier
                {
                    CarrierID = 10,
                    CarrierName = "Tillman Transport",
                    DepotCity = "London",
                    FTLAvailability = 18,
                    LTLAvailability = 45,
                    FTLRate = 5.11,
                    LTLRate = 0.3012,
                    ReefCharge = 0.09
                },
                new Carrier
                {
                    CarrierID = 11,
                    CarrierName = "Tillman Transport",
                    DepotCity = "Hamilton",
                    FTLAvailability = 18,
                    LTLAvailability = 45,
                    FTLRate = 5.11,
                    LTLRate = 0.3012,
                    ReefCharge = 0.09
                },
                new Carrier
                {
                    CarrierID = 12,
                    CarrierName = "We Haul",
                    DepotCity = "Ottawa",
                    FTLAvailability = 11,
                    LTLAvailability = 0,
                    FTLRate = 5.2,
                    LTLRate = 0,
                    ReefCharge = 0.065
                },
                new Carrier
                {
                    CarrierID = 13,
                    CarrierName = "We Haul",
                    DepotCity = "Toronto",
                    FTLAvailability = 11,
                    LTLAvailability = 0,
                    FTLRate = 5.2,
                    LTLRate = 0,
                    ReefCharge = 0.065
                }
            
                );
        }


        public void Log(string action, string description)
        {
            try
            {
                var logEntry = new LogEntry
                {
                    Timestamp = DateTime.Now,
                    Action = action,
                    Description = description
                };

                LogEntries.Add(logEntry);
                SaveChanges(); // Save changes to the database
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as logging to a file or displaying an error message
                Console.WriteLine($"Error while logging: {ex.Message}");
            }
        }

        public bool Backup(string path)
        {
            try
            {

                string connectionString = "server=localhost;port=3306;database=TMS_DB;user=root;password=17039125Ss#";
                string backupFileName = $"full_backup_{DateTime.Now:yyyyMMdd_HHmmss}.sql";
                string backupPath = Path.Combine(path, backupFileName);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();

                            mb.ExportToFile(backupPath);
                        }
                    }
                }

                return File.Exists(backupPath);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                return false;
            }
        }
    }
}

