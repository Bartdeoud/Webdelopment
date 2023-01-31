using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class DBContext : IdentityDbContext<Gebruiker>
{
    public DbSet<Gebruiker> gebruikers{ get; set; }
    public DbSet<Artiest> artiesten { get; set; }
    public DbSet<Band> bands { get; set; }
    public DbSet<Huren> reserveringen { get; set; }
    public DbSet<Leden> leden { get; set; }
    public DbSet<Ruimte> ruimtes { get; set; }
    public DbSet<Zaal> zalen { get; set; }
    public DbSet<Ticket> tickets { get; set; }
    public DbSet<Show> shows { get; set; }
    public DbSet<SessionId> sessionIds {get; set;}
    public DbSet<Genre> genres {get; set;}
    public DbSet<Leeftijdsgroep> leeftijdsgroepen {get; set;}
    public DbSet<Review>? Review { get; set; }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder builder) {
    builder.UseSqlServer("Server=tcp:laakentertainment.database.windows.net,1433;Initial Catalog=LaakEntertainment;Persist Security Info=False;User ID=AdminLaak;Password=LaakTheater2!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=2;");
    builder.EnableSensitiveDataLogging();
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Zaal>().HasData(
            new Zaal(){Zaalnr=1, Naam="Zaal 1", Rang1 = 120, Rang2 = 98,Rang3 = 20, invalideplaatsen = 2,},
            new Zaal(){Zaalnr=2, Naam="Zaal 2", Rang1 = 100, Rang2 = 80},
            new Zaal(){Zaalnr=3, Naam="Zaal 3", Rang1 = 30, Rang2 = 30, Rang3 = 20, Rang4 = 10},
            new Zaal(){Zaalnr=4, Naam="Zaal 4", Rang1 = 210, Rang2 = 115, Rang3 = 90, Rang4 = 20, invalideplaatsen = 5}
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

        builder.Entity<Genre>().HasData(
            new Genre(){GenreID=1, Naam="Horror"},
            new Genre(){GenreID=2, Naam="Comedy"},
            new Genre(){GenreID=3, Naam="Drama"},
            new Genre(){GenreID=4, Naam="Action"},
            new Genre(){GenreID=5, Naam="Romance"},
            new Genre(){GenreID=6, Naam="Adventure"},
            new Genre(){GenreID=7, Naam="Mystery"},
            new Genre(){GenreID=8, Naam="Family"},
            new Genre(){GenreID=9, Naam="Music"},
            new Genre(){GenreID=10, Naam="History"},
            new Genre(){GenreID=11, Naam="War"},
            new Genre(){GenreID=12, Naam="Western"},
            new Genre(){GenreID=13, Naam="Sport"}
        );

        builder.Entity<Leeftijdsgroep>().HasData(
            new Leeftijdsgroep(){LeeftijdsgroepID=1, Naam="Alle leeftijden"},
            new Leeftijdsgroep(){LeeftijdsgroepID=2, Naam="Onder de 18"},
            new Leeftijdsgroep(){LeeftijdsgroepID=3, Naam="18-65"},
            new Leeftijdsgroep(){LeeftijdsgroepID=4, Naam="65+"}
        );


        builder.Entity<Show>().HasData(
            new Show(){Shownr = 1, Naam = "Show 1", BeginTijd = DateTime.Now, EindTijd = DateTime.Now, Zaal = 1, Genre = 1, Afbeelding = "", Leeftijdsgroep = 1},
            new Show(){Shownr = 2, Naam = "Show 2", BeginTijd = DateTime.Now, EindTijd = DateTime.Now, Zaal = 2, Genre = 2, Afbeelding = "", Leeftijdsgroep = 2},
            new Show(){Shownr = 3, Naam = "Show 3", BeginTijd = DateTime.Now, EindTijd = DateTime.Now, Zaal = 3, Genre = 3, Afbeelding = "", Leeftijdsgroep = 3}  
        );
    }
}