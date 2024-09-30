using Microsoft.EntityFrameworkCore;


namespace PamasolaSimpleERP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // public DbSet<UserModel> Tb_Users { get; set; } = null!;
        // // store one time pins
        // public DbSet<UserOtp> Tb_Otps { get; set; } = null!;

        // public DbSet<FoodItemModel> Tb_FoodItems { get; set; } = null!;
        // public DbSet<RestaurantModel> Tb_Restaurants { get; set; } = null!;
        // public DbSet<OrderModel> Tb_Orders { get; set; } = null!;
        // dotnet ef migrations add Initial
        // dotnet ef database update
    }
}