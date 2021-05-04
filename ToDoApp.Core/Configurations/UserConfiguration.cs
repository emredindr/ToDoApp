using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoApp.Core.Entities;

namespace ToDoApp.Core.Configurations
{
    //ToDo -Emreden bekleniyor
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Surname).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(50);
            builder.Property(c => c.CreatedTime).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
        }
    }
}
