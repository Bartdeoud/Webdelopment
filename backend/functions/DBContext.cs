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

    protected override void OnConfiguring(DbContextOptionsBuilder builder) => builder.UseSqlite("Data Source= ../backend/database.db");
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Gebruiker>().HasData(
            new Gebruiker(){ Email = "test1@email.com",Naam = "Jan1", Wachtwoord = "Test1", UserID = 1},
            new Gebruiker(){ Email = "test2@email.com",Naam = "Jan2", Wachtwoord = "Test2", UserID = 2},
            new Gebruiker(){ Email = "test3@email.com",Naam = "Jan3", Wachtwoord = "Test3", UserID = 3},
            new Gebruiker(){ Email = "test4@email.com",Naam = "Jan4", Wachtwoord = "Test4", UserID = 4}
            );
    }






}