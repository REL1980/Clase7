using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Clase7.EntityFrameworkCore
{
    public static class Clase7DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Clase7DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Clase7DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
