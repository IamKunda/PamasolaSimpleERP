using Microsoft.EntityFrameworkCore;


namespace PamasolaSimpleERP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // public DbSet<UserModel> Tb_Users { get; set; } = null!;
        // dotnet ef migrations add Initial
        // dotnet ef database update
    }
}