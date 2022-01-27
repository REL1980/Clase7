using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Clase7.Authorization.Roles;
using Clase7.Authorization.Users;
using Clase7.MultiTenancy;
using Clase7.Domain;

namespace Clase7.EntityFrameworkCore
{
    public class Clase7DbContext : AbpZeroDbContext<Tenant, Role, User, Clase7DbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Team> Teams { get; set; }

        
        public Clase7DbContext(DbContextOptions<Clase7DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TeamConfig());
        }


    }
}
