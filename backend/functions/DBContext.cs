// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

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
        builder.Entity<Gebruiker>().HasData(
            new Gebruiker(){ Email = "test1@email.com",Username="Jan1",Naam = "Jan1", Wachtwoord = "Test1", UserID = 1},
            new Gebruiker(){ Email = "test2@email.com",Username="Jan2",Naam = "Jan2", Wachtwoord = "Test2", UserID = 2},
            new Gebruiker(){ Email = "test3@email.com",Username="Jan3",Naam = "Jan3", Wachtwoord = "Test3", UserID = 3},
            new Gebruiker(){ Email = "test4@email.com",Username="Jan4",Naam = "Jan4", Wachtwoord = "Test4", UserID = 4},
            new Gebruiker(){ Email = "artiestmail1@email.com",Username="Artiest1",Naam = "Artiest1", Wachtwoord = "Test1", UserID = 5},
            new Gebruiker(){ Email = "artiestmail2@email.com", Username="Artiest2", Naam = "Artiest2", Wachtwoord = "Test2", UserID = 6},
            new Gebruiker(){ Email = "artiestmail3@email.com", Username="Artiest3", Naam = "Artiest3", Wachtwoord = "Test3", UserID = 7},
            new Gebruiker(){ Email = "artiestmail4@email.com", Username="Artiest4", Naam = "Artiest4", Wachtwoord = "Test4", UserID = 8},
            new Gebruiker(){ Email = "artiestmail5@email.com", Username="Artiest5", Naam = "Artiest5", Wachtwoord = "Test5", UserID = 9}
        );

        builder.Entity<Artiest>().HasData(
            new Artiest(){ artiest_naam = "Artiest1", UserID = 5},
            new Artiest(){ artiest_naam = "Artiest2", UserID = 6},
            new Artiest(){ artiest_naam = "Artiest3", UserID = 7},
            new Artiest(){ artiest_naam = "Artiest4", UserID = 8},
            new Artiest(){ artiest_naam = "Artiest5", UserID = 9}
        );

        builder.Entity<Donateur>().HasData(
            new Donateur(){ TotaleDonatie = 1000, UserID = 1}
        );
    }
}