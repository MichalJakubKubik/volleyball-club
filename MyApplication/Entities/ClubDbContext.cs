using Microsoft.EntityFrameworkCore;

namespace MyApplication.Entities
{
    public class ClubDbContext : DbContext
    {
        public ClubDbContext(DbContextOptions<ClubDbContext> options) : base(options)
        {

        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubAddress> ClubAddresses { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<StaffAddress> StaffAddresses { get; set; }
        public DbSet<LeagueLevel> LeagueLevels { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<CoachOccupation> CoachOccupations { get; set; }
        public DbSet<User> Users { get; set;}
        public DbSet<UserRole> UserRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>(eb =>
            {
                eb.Property(c => c.ShortName).HasMaxLength(32);
                eb.Property(c => c.FullName).HasMaxLength(128);
                eb.Property(c => c.ContactEmail).HasMaxLength(128);
                eb.Property(c => c.ContactNumber).HasMaxLength(16);
                eb.HasOne(ca => ca.ClubAddress)
                    .WithOne(c => c.Club)
                    .HasForeignKey<ClubAddress>(ca => ca.ClubId);
                eb.HasMany(c => c.Players)
                    .WithOne(t => t.Club)
                    .HasForeignKey(t => t.ClubId);
                eb.HasMany(c => c.Coaches)
                    .WithOne(t => t.Club)
                    .HasForeignKey(t => t.ClubId);
                eb.HasOne(c => c.LeagueLevel)
                    .WithMany(l => l.Clubs)
                    .HasForeignKey(l => l.LeagueLevelId);
                eb.HasData(new Club { Id = 1, ContactEmail = "resovia@gmail.com", ContactNumber = "435098209", FullName = "Asseco Resovia Rzeszów", ShortName = "Resovia Rzeszów", LeagueLevelId = 1 },
                           new Club { Id = 2, ContactEmail = "jastrzebskiwegiel@gmail.com", ContactNumber = "788763121", FullName = "Jastrzębski Węgiel", ShortName = "Jastrzębski Węgiel", LeagueLevelId = 1 },
                           new Club { Id = 3, ContactEmail = "zawiercie@gmail.com", ContactNumber = "345989099", FullName = "Aluron CMC Warta Zawiercie", ShortName = "Warta Zawiercie", LeagueLevelId = 1 },
                           new Club { Id = 4, ContactEmail = "treflgdansk@gmail.com", ContactNumber = "448998209", FullName = "Trefl Gdańsk", ShortName = "Trefl Gdańsk", LeagueLevelId = 1 },
                           new Club { Id = 5, ContactEmail = "projektwarszawa@gmail.com", ContactNumber = "222432567", FullName = "Projekt Warszawa", ShortName = "Projekt Warszawa", LeagueLevelId = 1 },
                           new Club { Id = 6, ContactEmail = "zaksa@gmail.com", ContactNumber = "989098209", FullName = "Grupa Azoty ZAKSA Kędzierzyn-Koźle", ShortName = "ZAKSA Kędzierzyn-Koźle", LeagueLevelId = 1 },
                           new Club { Id = 7, ContactEmail = "azsolsztyn@gmail.com", ContactNumber = "443876444", FullName = "Indykpol AZS Olsztyn", ShortName = "AZS Olsztyn", LeagueLevelId = 1 },
                           new Club { Id = 8, ContactEmail = "stalnysa@gmail.com", ContactNumber = "435034555", FullName = "PSG Stal Nysa", ShortName = "Stal Nysa", LeagueLevelId = 1 },
                           new Club { Id = 9, ContactEmail = "slepsksuwalki@gmail.com", ContactNumber = "787788820", FullName = "Ślepsk Malow Suwałki", ShortName = "Ślepsk Suwałki", LeagueLevelId = 1 },
                           new Club { Id = 10, ContactEmail = "skrabelchatow@gmail.com", ContactNumber = "224465780", FullName = "PGE Skra Bełchatów", ShortName = "Skra Bełchatów", LeagueLevelId = 1 },
                           new Club { Id = 11, ContactEmail = "luklublin@gmail.com", ContactNumber = "121333987", FullName = "LUK Lublin", ShortName = "LUK Lublin", LeagueLevelId = 2 },
                           new Club { Id = 12, ContactEmail = "gkskatowice@gmail.com", ContactNumber = "988763091", FullName = "GKS Katowice", ShortName = "GKS Katowice", LeagueLevelId = 2 },
                           new Club { Id = 13, ContactEmail = "barkomkazany@gmail.com", ContactNumber = "345983399", FullName = "Barkom-Każany Lwów", ShortName = "Barkom-Każany Lwów", LeagueLevelId = 2 },
                           new Club { Id = 14, ContactEmail = "cuprumlubin@gmail.com", ContactNumber = "667312287", FullName = "Cuprum Lubin", ShortName = "Cuprum Lubin", LeagueLevelId = 2 },
                           new Club { Id = 15, ContactEmail = "czarniradom@gmail.com", ContactNumber = "889657221", FullName = "Cerrad Enea Czarni Radom", ShortName = "Czarni Radom", LeagueLevelId = 2 },
                           new Club { Id = 16, ContactEmail = "bbts@gmail.com", ContactNumber = "332098209", FullName = "BBTS Bielsko-Biała", ShortName = "BBTS Bielsko-Biała", LeagueLevelId = 2 },
                           new Club { Id = 17, ContactEmail = "norwidczestochowa@gmail.com", ContactNumber = "900876444", FullName = "Exact Systems Norwid Częstochowa", ShortName = "Norwid Częstochowa", LeagueLevelId = 2 },
                           new Club { Id = 18, ContactEmail = "mksbedzin@gmail.com", ContactNumber = "435011555", FullName = "MKS Będzin", ShortName = "MKS Będzin", LeagueLevelId = 2 },
                           new Club { Id = 19, ContactEmail = "gwardiawroclaw@gmail.com", ContactNumber = "212188820", FullName = "Chemeko-System Gwardia Wrocław", ShortName = "Gwardia Wrocław", LeagueLevelId = 2 },
                           new Club { Id = 20, ContactEmail = "mickiewiczkluczbork@gmail.com", ContactNumber = "266665780", FullName = "Mickiewicz Kluczbork", ShortName = "Mickiewicz Kluczbork", LeagueLevelId = 2 },
                           new Club { Id = 21, ContactEmail = "bksbydgoszcz@gmail.com", ContactNumber = "901333987", FullName = "BKS Visła Proline Bydgoszcz", ShortName = "BKS Bydgoszcz", LeagueLevelId = 3 },
                           new Club { Id = 22, ContactEmail = "aviaswidnik@gmail.com", ContactNumber = "333763091", FullName = "PZL LEONARDO Avia Świdnik", ShortName = "Avia Świdnik", LeagueLevelId = 3 },
                           new Club { Id = 23, ContactEmail = "azsaghkrakow@gmail.com", ContactNumber = "766432112", FullName = "AZS AGH Kraków", ShortName = "AZS AGH Kraków", LeagueLevelId = 3 },
                           new Club { Id = 24, ContactEmail = "chrobryglogow@gmail.com", ContactNumber = "222312287", FullName = "SPS Chrobry Głogów", ShortName = "Chrobry Głogów", LeagueLevelId = 3 },
                           new Club { Id = 25, ContactEmail = "lechiatomaszow@gmail.com", ContactNumber = "887677221", FullName = "Lechia Tomaszów Mazowiecki", ShortName = "Lechia Tomaszów Mazowiecki", LeagueLevelId = 3 },
                           new Club { Id = 26, ContactEmail = "kpssiedlce@gmail.com", ContactNumber = "676798209", FullName = "PSG KPS Siedlce", ShortName = "KPS Siedlce", LeagueLevelId = 3 });
            });

            modelBuilder.Entity<ClubAddress>(eb =>
            {
                eb.Property(c => c.Street).HasMaxLength(64);
                eb.Property(c => c.City).HasMaxLength(64);
                eb.Property(c => c.PostalCode).HasMaxLength(32);
            });

            modelBuilder.Entity<Staff>(eb =>
            {
                eb.Property(s => s.FirstName).HasMaxLength(32);
                eb.Property(s => s.SecondName).HasMaxLength(32);
                eb.Property(s => s.LastName).HasMaxLength(32);
                eb.Property(s => s.Nationality).HasMaxLength(64);
                eb.Property(s => s.PlaceOfBirth).HasMaxLength(64);
                eb.Property(s => s.ContactEmail).HasMaxLength(128);
                eb.Property(s => s.ContactNumber).HasMaxLength(32);
                eb.Property(s => s.DateOfLeagueJoin).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<StaffAddress>(eb =>
            {
                eb.Property(s => s.Street).HasMaxLength(64);
                eb.Property(s => s.City).HasMaxLength(64);
                eb.Property(s => s.PostalCode).HasMaxLength(6);
                eb.HasMany(p => p.Staffs)
                    .WithOne(a => a.StaffAddress)
                    .HasForeignKey(a => a.StaffAddressId);
            });

            modelBuilder.Entity<LeagueLevel>(eb =>
            {
                eb.Property(l => l.LeagueName).HasMaxLength(32);
                eb.Property(l => l.LeagueLevelNumber).HasColumnType("tinyint");
                eb.HasKey(l => l.LeagueLevelNumber);
                eb.HasData(new LeagueLevel { LeagueLevelNumber = 1, LeagueName = "PlusLiga" },
                    new LeagueLevel { LeagueLevelNumber = 2, LeagueName = "Tauron 1. Liga" },
                    new LeagueLevel { LeagueLevelNumber = 3, LeagueName = "2. Liga" });
            });

            modelBuilder.Entity<Player>()
                .Property(p => p.ShirtNumber)
                .HasColumnType("tinyint");

            modelBuilder.Entity<PlayerPosition>(eb =>
            {
                eb.Property(pp => pp.PositionName).HasMaxLength(32);
                eb.HasMany(p => p.Players)
                    .WithOne(pp => pp.PlayerPosition)
                    .HasForeignKey(p => p.PlayerPositionId);
                eb.HasData(new PlayerPosition { Id = 1, PositionName = "libero" },
                    new PlayerPosition { Id = 2, PositionName = "opposite" },
                    new PlayerPosition { Id = 3, PositionName = "setter" },
                    new PlayerPosition { Id = 4, PositionName = "middle blocker" },
                    new PlayerPosition { Id = 5, PositionName = "outside hitter" });
            });

            modelBuilder.Entity<CoachOccupation>(eb =>
            {
                eb.Property(co => co.OccupationName).HasMaxLength(32);
                eb.HasMany(c => c.Coaches)
                    .WithOne(co => co.CoachOccupation)
                    .HasForeignKey(c => c.CoachOccupationId);
                eb.HasData(new CoachOccupation { Id = 1, OccupationName = "Head coach" },
                    new CoachOccupation { Id = 2, OccupationName = "Assistant coach" },
                    new CoachOccupation { Id = 3, OccupationName = "Strength and conditioning coach" },
                    new CoachOccupation { Id = 4, OccupationName = "Statistician" },
                    new CoachOccupation { Id = 5, OccupationName = "Physiotherapist" });
            });

            modelBuilder.Entity<User>(eb =>
            {
                eb.Property(u => u.FirstName).HasMaxLength(32);
                eb.Property(u => u.LastName).HasMaxLength(32);
                eb.HasOne(u => u.UserRole)
                .WithMany(u => u.Users);
            });

            modelBuilder.Entity<UserRole>(eb =>
            {
                eb.Property(u => u.Name).HasMaxLength(32);
                eb.HasData(new UserRole { Id = 1, Name = "User" },
                    new UserRole { Id = 2, Name = "Manager" },
                    new UserRole { Id = 3, Name = "Admin" });
            });
        }
    }

}
