using Clase7.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clase7.EntityFrameworkCore
{
    public class TeamConfig : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Equipos");
            
            builder.HasKey(x => x.Id);

        }
    }
}