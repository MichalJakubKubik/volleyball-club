using Bogus;
using Bogus.DataSets;
using MyApplication.Entities;

namespace MyApplication
{

    public class DataGenerator
    {

        public static void Seed(ClubDbContext context)
        {
            var locale = "pl";
            var numberOfClubsInLeague = 26;
            var numberOfPlayersInEachClub = 20;
            var numberOfCoachesInEachClub = 5;

            if (!context.Players.Any())
            {
                #region staffGenerator

                var staffAddressGenerator = new Faker<StaffAddress>(locale)
                    .RuleFor(a => a.City, f => f.Address.City())
                    .RuleFor(a => a.Street, f => f.Address.StreetName())
                    .RuleFor(a => a.PostalCode, f => f.Address.ZipCode());

                var playerGenerator = new Faker<Player>()
                    .RuleFor(a => a.FirstName, f => f.Name.FirstName(Bogus.DataSets.Name.Gender.Male))
                    .RuleFor(a => a.LastName, f => f.Name.LastName(Bogus.DataSets.Name.Gender.Male))
                    .RuleFor(a => a.ContactEmail, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                    .RuleFor(a => a.ContactNumber, f => f.Person.Phone)
                    .RuleFor(a => a.Nationality, f => f.Address.Country())
                    .RuleFor(a => a.DateOfBirth, f => f.Person.DateOfBirth)
                    .RuleFor(a => a.PlaceOfBirth, f => f.Address.City())
                    .RuleFor(a => a.ShirtNumber, f => f.Random.Int(1, 99))
                    .RuleFor(a => a.PlayerPositionId, f => f.Random.Int(1, 5))
                    .RuleFor(a => a.StaffAddress, f => staffAddressGenerator.Generate());

                var coachGenerator = new Faker<Coach>()
                    .RuleFor(a => a.FirstName, f => f.Name.FirstName(Bogus.DataSets.Name.Gender.Male))
                    .RuleFor(a => a.LastName, f => f.Name.LastName(Bogus.DataSets.Name.Gender.Male))
                    .RuleFor(a => a.ContactEmail, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                    .RuleFor(a => a.ContactNumber, f => f.Person.Phone)
                    .RuleFor(a => a.Nationality, f => f.Address.Country())
                    .RuleFor(a => a.DateOfBirth, f => f.Person.DateOfBirth)
                    .RuleFor(a => a.PlaceOfBirth, f => f.Address.Country())
                    .RuleFor(a => a.StaffAddress, f => staffAddressGenerator.Generate());

                List<int> listOfSkirtNumbers = new List<int>();

                for (int i = 0; i < numberOfClubsInLeague; i++)
                {
                    var players = playerGenerator.Generate(numberOfPlayersInEachClub);

                    if (listOfSkirtNumbers.Any())
                        listOfSkirtNumbers.RemoveRange(0, 20);

                    for (int j = 0; j < numberOfPlayersInEachClub; j++)
                    {
                        players[j].ClubId = i + 1;

                        while (listOfSkirtNumbers.Contains(players[j].ShirtNumber))
                        {
                            players[j].ShirtNumber += 1;
                            if (players[j].ShirtNumber == 100)
                                players[j].ShirtNumber = 1;
                        }

                        listOfSkirtNumbers.Add(players[j].ShirtNumber);
                    }

                    var coaches = coachGenerator.Generate(numberOfCoachesInEachClub);

                    for (int k = 0; k < numberOfCoachesInEachClub; k++)
                    {
                        coaches[k].CoachOccupationId = k + 1;
                        coaches[k].ClubId = i + 1;
                    }

                    context.AddRange(players);
                    context.AddRange(coaches);
                    context.SaveChanges();
                }

                #endregion
            }

            if (!context.ClubAddresses.Any())
            {
                #region clubAddressGenerator

                var clubAddressGenerator = new Faker<ClubAddress>(locale)
                    .RuleFor(a => a.City, f => f.Address.City())
                    .RuleFor(a => a.Street, f => f.Address.StreetName())
                    .RuleFor(a => a.PostalCode, f => f.Address.ZipCode());

                var clubAddresses = clubAddressGenerator.Generate(numberOfClubsInLeague);

                for (int i = 0; i < numberOfClubsInLeague; i++)
                {
                    clubAddresses[i].ClubId = i + 1;
                }

                context.AddRange(clubAddresses);
                context.SaveChanges();

                #endregion
            }
        }
    }
}
