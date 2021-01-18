


using Ecommerce.DbEntities;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Adrresses { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<ProductCategory> ProductCategories { get; set; }

    public DbSet<ProductOrder> ProductOrder { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Account> Accounts { get; set; }

    public DbSet<AccountType> AccountTypes { get; set; }

    public DbSet<AccountType> Secrets { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}