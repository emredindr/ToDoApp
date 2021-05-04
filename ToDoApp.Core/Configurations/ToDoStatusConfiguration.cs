using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.Entities;

namespace ToDoApp.Core.Configurations
{
    public class ToDoStatusConfiguration:IEntityTypeConfiguration<ToDoStatus>
    {
        public void Configure(EntityTypeBuilder<ToDoStatus> builder)
        {
            builder.ToTable("ToDoStatus");
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);


        }
    }
}
