using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Soft98.Domain;

namespace Soft98.Data.Map;

public class MapUser : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasMany(x => x.UserRoles).WithOne(x => x.User).HasForeignKey(x => x.UserId);
    }
}