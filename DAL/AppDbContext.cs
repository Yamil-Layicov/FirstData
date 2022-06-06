using BootStrap.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrap.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       
        public DbSet<Service> Services { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<FeatureItem> FeatureItems { get; set; }
        public DbSet<PlanFeature> PlanFeatures { get; set; }
    }
}
