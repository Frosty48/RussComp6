using RussComp6.Components.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;



namespace RussComp6.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Asset> Asset { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = default!;

        //public class ApplicationUser : IdentityUser
        //{
        //    // Add custom properties here if needed
        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {

        }
    }

    public class MyBlogDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source = data.db");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }


}
