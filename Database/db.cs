using Microsoft.EntityFrameworkCore;

public class EdriveDb : DbContext
{
    public EdriveDb(
        DbContextOptions<EdriveDb> options
    ) : base(options)
    { }

    public DbSet<t_company_info> t_company_info { get; set; }
    public DbSet<t_employee> t_employee { get; set; }
    public DbSet<t_user> t_user { get; set; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<t_company_info>().ToTable("t_company_info");
        builder.Entity<t_employee>().ToTable("t_employee");

    }
}