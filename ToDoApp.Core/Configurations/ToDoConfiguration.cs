using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoApp.Core.Entities;

namespace ToDoApp.Core.Configurations
{
    public class ToDoConfiguration: IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo>builder)
        {
            builder.ToTable("ToDo");
            builder.Property(c => c.TodoStatusId).IsRequired();
            builder.Property(c => c.Title).IsRequired().HasMaxLength(500);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(2000);
            builder.Property(c => c.EndDate).IsRequired();
        }
    }
}
