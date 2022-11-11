using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Domain.Entities;

namespace Repository.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.CourseId);

            builder.Property(x => x.CourseType).IsRequired();
            builder.Property(x => x.CourseName).IsRequired();
            builder.Property(x => x.TrainerName).IsRequired();
            builder.Property(x => x.TrainerEmail).IsRequired();
            
            builder.ToTable("Courses");        }
    }
}
