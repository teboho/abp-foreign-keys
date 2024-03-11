using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Box.FKs.Authorization.Roles;
using Box.FKs.Authorization.Users;
using Box.FKs.MultiTenancy;
using Box.FKs.Domain;

namespace Box.FKs.EntityFrameworkCore
{
    public class FKsDbContext : AbpZeroDbContext<Tenant, Role, User, FKsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> People { get; set; }
        public DbSet<Car> Cars { get; set; }
        public FKsDbContext(DbContextOptions<FKsDbContext> options)
            : base(options)
        {
        }
    }
}
