using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Box.FKs.EntityFrameworkCore
{
    public static class FKsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FKsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FKsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
