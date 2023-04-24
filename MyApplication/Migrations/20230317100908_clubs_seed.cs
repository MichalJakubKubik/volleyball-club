using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyApplication.Migrations
{
    /// <inheritdoc />
    public partial class clubs_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "ContactEmail", "ContactNumber", "FullName", "LeagueLevelId", "ShortName" },
                values: new object[,]
                {
                    { 1, "resovia@gmail.com", "435098209", "Asseco Resovia Rzeszów", (byte)1, "Resovia Rzeszów" },
                    { 2, "jastrzebskiwegiel@gmail.com", "788763121", "Jastrzębski Węgiel", (byte)1, "Jastrzębski Węgiel" },
                    { 3, "zawiercie@gmail.com", "345989099", "Aluron CMC Warta Zawiercie", (byte)1, "Warta Zawiercie" },
                    { 4, "treflgdansk@gmail.com", "448998209", "Trefl Gdańsk", (byte)1, "Trefl Gdańsk" },
                    { 5, "projektwarszawa@gmail.com", "222432567", "Projekt Warszawa", (byte)1, "Projekt Warszawa" },
                    { 6, "zaksa@gmail.com", "989098209", "Grupa Azoty ZAKSA Kędzierzyn-Koźle", (byte)1, "ZAKSA Kędzierzyn-Koźle" },
                    { 7, "azsolsztyn@gmail.com", "443876444", "Indykpol AZS Olsztyn", (byte)1, "AZS Olsztyn" },
                    { 8, "stalnysa@gmail.com", "435034555", "PSG Stal Nysa", (byte)1, "Stal Nysa" },
                    { 9, "slepsksuwalki@gmail.com", "787788820", "Ślepsk Malow Suwałki", (byte)1, "Ślepsk Suwałki" },
                    { 10, "skrabelchatow@gmail.com", "224465780", "PGE Skra Bełchatów", (byte)1, "Skra Bełchatów" },
                    { 11, "luklublin@gmail.com", "121333987", "LUK Lublin", (byte)2, "LUK Lublin" },
                    { 12, "gkskatowice@gmail.com", "988763091", "GKS Katowice", (byte)2, "GKS Katowice" },
                    { 13, "barkomkazany@gmail.com", "345983399", "Barkom-Każany Lwów", (byte)2, "Barkom-Każany Lwów" },
                    { 14, "cuprumlubin@gmail.com", "667312287", "Cuprum Lubin", (byte)2, "Cuprum Lubin" },
                    { 15, "czarniradom@gmail.com", "889657221", "Cerrad Enea Czarni Radom", (byte)2, "Czarni Radom" },
                    { 16, "bbts@gmail.com", "332098209", "BBTS Bielsko-Biała", (byte)2, "BBTS Bielsko-Biała" },
                    { 17, "norwidczestochowa@gmail.com", "900876444", "Exact Systems Norwid Częstochowa", (byte)2, "Norwid Częstochowa" },
                    { 18, "mksbedzin@gmail.com", "435011555", "MKS Będzin", (byte)2, "MKS Będzin" },
                    { 19, "gwardiawroclaw@gmail.com", "212188820", "Chemeko-System Gwardia Wrocław", (byte)2, "Gwardia Wrocław" },
                    { 20, "mickiewiczkluczbork@gmail.com", "266665780", "Mickiewicz Kluczbork", (byte)2, "Mickiewicz Kluczbork" },
                    { 21, "bksbydgoszcz@gmail.com", "901333987", "BKS Visła Proline Bydgoszcz", (byte)3, "BKS Bydgoszcz" },
                    { 22, "aviaswidnik@gmail.com", "333763091", "PZL LEONARDO Avia Świdnik", (byte)3, "Avia Świdnik" },
                    { 23, "azsaghkrakow@gmail.com", "766432112", "AZS AGH Kraków", (byte)3, "AZS AGH Kraków" },
                    { 24, "chrobryglogow@gmail.com", "222312287", "SPS Chrobry Głogów", (byte)3, "Chrobry Głogów" },
                    { 25, "lechiatomaszow@gmail.com", "887677221", "Lechia Tomaszów Mazowiecki", (byte)3, "Lechia Tomaszów Mazowiecki" },
                    { 26, "kpssiedlce@gmail.com", "676798209", "PSG KPS Siedlce", (byte)3, "KPS Siedlce" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 26);
        }
    }
}
