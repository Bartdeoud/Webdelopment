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
            new Gebruiker(){ Email = "test4@email.com",Username="Jan4",Naam = "Jan4", Wachtwoord = "Test4", UserID = 4},
            new Gebruiker(){ Email = "artiestmail1@email.com",Username="Artiest1",Naam = "Artiest1", Wachtwoord = "Test1", UserID = 5},
            new Gebruiker(){ Email = "artiestmail2@email.com", Username="Artiest2", Naam = "Artiest2", Wachtwoord = "Test2", UserID = 6},
            new Gebruiker(){ Email = "artiestmail3@email.com", Username="Artiest3", Naam = "Artiest3", Wachtwoord = "Test3", UserID = 7},
            new Gebruiker(){ Email = "artiestmail4@email.com", Username="Artiest4", Naam = "Artiest4", Wachtwoord = "Test4", UserID = 8},
            new Gebruiker(){ Email = "artiestmail5@email.com", Username="Artiest5", Naam = "Artiest5", Wachtwoord = "Test5", UserID = 9}
        );
        builder.Entity<Stoelrij>().HasData(
            new Stoelrij(){Rangnummer=1,Aantal_stoelen=20,  rijid=11, Zaalnr=1},
            new Stoelrij(){Rangnummer=2,Aantal_stoelen=100, rijid=12, Zaalnr=1},
            new Stoelrij(){Rangnummer=3,Aantal_stoelen=120, rijid=13, Zaalnr=1},
            new Stoelrij(){Rangnummer=1,Aantal_stoelen=2,   rijid=21, Zaalnr=2},
            new Stoelrij(){Rangnummer=2,Aantal_stoelen=160, rijid=22,Zaalnr=2},
            new Stoelrij(){Rangnummer=1,Aantal_stoelen=10,  rijid=31, Zaalnr=3},
            new Stoelrij(){Rangnummer=2,Aantal_stoelen=80,  rijid=32, Zaalnr=3},
            new Stoelrij(){Rangnummer=1,Aantal_stoelen=40,  rijid=41, Zaalnr=4},
            new Stoelrij(){Rangnummer=2,Aantal_stoelen=200, rijid=42, Zaalnr=4},
            new Stoelrij(){Rangnummer=3,Aantal_stoelen=200, rijid=43, Zaalnr=4}
        );

        builder.Entity<Zaal>().HasData(
            new Zaal(){
                Zaalnr=1,
                Naam="Zaal 1",
                Aantal_stoelen=240,
            },
            new Zaal(){
                Zaalnr=2,
                Naam="Zaal 2",
                Aantal_stoelen=180,
            },
            new Zaal(){
                Zaalnr=3,
                Naam="Zaal 3",
                Aantal_stoelen=90
            },
            new Zaal(){
                Zaalnr=4,
                Naam="Zaal 4",
                Aantal_stoelen=440,
            }
        );

        builder.Entity<Ruimte>().HasData(
            new Ruimte(){RuimteNr=1 ,Naam="Ruimte 1" , Capaciteit=30},
            new Ruimte(){RuimteNr=2 ,Naam="Ruimte 2" , Capaciteit=30},
            new Ruimte(){RuimteNr=3 ,Naam="Ruimte 3" , Capaciteit=30},
            new Ruimte(){RuimteNr=4 ,Naam="Ruimte 4" , Capaciteit=30},
            new Ruimte(){RuimteNr=5 ,Naam="Ruimte 5" , Capaciteit=30},
            new Ruimte(){RuimteNr=6 ,Naam="Ruimte 6" , Capaciteit=30},
            new Ruimte(){RuimteNr=7 ,Naam="Ruimte 7" , Capaciteit=30},
            new Ruimte(){RuimteNr=8 ,Naam="Ruimte 8" , Capaciteit=30},
            new Ruimte(){RuimteNr=9 ,Naam="Ruimte 9" , Capaciteit=30},
            new Ruimte(){RuimteNr=10,Naam="Ruimte 10", Capaciteit=30}
        );
    }
}