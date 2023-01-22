// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

public class DBContext : DbContext
{
    public DbSet<Gebruiker> gebruikers{ get; set; }
    public DbSet<Artiest> artiesten { get; set; }
    public DbSet<Band> bands { get; set; }
    public DbSet<Donateur> donateurs { get; set; }
    public DbSet<Huren> reserveringen { get; set; }
    public DbSet<Leden> leden { get; set; }
    public DbSet<Ruimte> ruimtes { get; set; }
    public DbSet<Zaal> zalen { get; set; }
    public DbSet<Ticket> tickets { get; set; }
    public DbSet<Show> shows { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder) => builder.UseSqlServer("Server=tcp:laakentertainment.database.windows.net,1433;Initial Catalog=LaakEntertainment;Persist Security Info=False;User ID=AdminLaak;Password=LaakEntertainment1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=2;");
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Show>().HasMany(a => a.Artiesten).WithOne();
        builder.Entity<Gebruiker>().HasData(
            new Gebruiker(){ Email = "test1@email.com",Username="Jan1",Naam = "Jan1", Wachtwoord = "Test1", UserID = 1},
            new Gebruiker(){ Email = "test2@email.com",Username="Jan2",Naam = "Jan2", Wachtwoord = "Test2", UserID = 2},
            new Gebruiker(){ Email = "test3@email.com",Username="Jan3",Naam = "Jan3", Wachtwoord = "Test3", UserID = 3},
            new Gebruiker(){ Email = "test4@email.com",Username="Jan4",Naam = "Jan4", Wachtwoord = "Test4", UserID = 4}
            );
    }
}