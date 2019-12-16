using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.Users;

namespace CJ.Project.EntityFrameworkCore
{
    public static class ProjectDbContextModelCreatingExtensions
    {
        public static void ConfigureProject(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ProjectConsts.DbTablePrefix + "YourEntities", ProjectConsts.DbSchema);

            //    //...
            //});
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}