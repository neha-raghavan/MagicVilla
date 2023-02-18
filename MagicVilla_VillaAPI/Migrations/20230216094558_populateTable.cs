using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class populateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedAt", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Furnished\r\nCentral A/C\r\nCovered Parking\r\nKitchen Appliances\r\nSecurity\r\nShared Gym\r\nShared Pool", new DateTime(2023, 2, 16, 13, 45, 58, 360, DateTimeKind.Local).AddTicks(8639), "Green Community is a residential community located in Dubai, United Arab Emirates. It features a variety of fully furnished 1 bedroom apartments with park views available for rent. The apartments are equipped with modern amenities and are located in a peaceful and serene setting, surrounded by lush greenery and landscaped gardens.", "https://www.propertyfinder.ae/en/plp/rent/apartment-for-rent-dubai-green-community-green-community-west-southwest-apartments-9327099.html", "GREEN COMMUNITY WEST", 5, 0.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Furnished\r\nCentral A/C\r\nCovered Parking\r\nKitchen Appliances\r\nSecurity\r\nShared Gym\r\nShared Pool", new DateTime(2023, 2, 16, 13, 45, 58, 360, DateTimeKind.Local).AddTicks(8654), "The Edge is nestled within the mixed-use gated community of Ewan Residences, Dubai Investment Park. This sleek, high-quality, yet affordable, residential development offers its tenants the utmost accessibility to Dubai’s most prominent business and retail centers, including the highly anticipated Expo 2020 site.", "https://www.propertyfinder.ae/en/plp/rent/apartment-for-rent-dubai-dubai-investment-park-the-edge-9058935.html", " THE EDGE,", 4, 0.0, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Unfurnished\r\nBuilt in Wardrobes\r\nChildren's Play Area\r\nCovered Parking\r\nSecurity\r\nView of Landmark", new DateTime(2023, 2, 16, 13, 45, 58, 360, DateTimeKind.Local).AddTicks(8656), "Spacious | Modern Interior | Kitchen Equipped\r\n\r\n*Ready to move in\r\n*Open and a Fully Fitted kitchen ( Oven, refrigerator & washing machine included)\r\n*Bathroom: 2\r\n*Free 4 burner cooker\r\n*Multiple Units Available\r\n\r\nFeatures:\r\n*Low-rise building\r\n*Central air conditioning\r\n*Gymnasium\r\n*24 hrs Security\r\n*Games room and children’s play area\r\n*Maintenance Included\r\n*Near to Shops\r\n*In front of Public Transportation\r\n*In front of Park\r\n\r\nSchools near by:\r\n1. Nibras International School ( [link not available] )\r\n2. Greenfield International School ( [link not available] )\r\n3. The International School of Choueifat-DIP ( [link not available] 4. Dove Green Private School ( [link not available] )\r\n5. Bright Riders School ( [link not available]\r\nLocation:\r\n*5 Min to Sheikh Mohammed Bin Zayed road\r\n*10 Mins to Al Khail Road\r\n*12 Mins to Marina, JLT , JBR\r\n*12 Mins to Ibn Battuta Mall\r\n*12 Min to Ikea\r\n*15 Min to Dubai Hills Mall\r\n*15 Mins to Mall of the Emirates\r\n*20 Mins to Dubai Mall\r\n*25 Mins to Dubai Airport\r\n\r\nDubai Investments Park is perfect location for families with easy access to main roads in Dubai. DIP is a business park area in Dubai, United Arab Emirates, including commercial, and industrial, and residential development. It is designed to be one of the most environment-friendly developments in the region.\r\n\r\nOne Tastik Real Estate Brokerage:\r\nTalent. Drive. Innovation. Service.\r\nWe have what it takes to push real estate forward!\r\n\r\n*For more details please call our Senior Property Consultant Lucy Carmichael on whatsapp\r\nDisplay phone number", "https://www.propertyfinder.ae/en/plp/rent/apartment-for-rent-dubai-dubai-investment-park-darwish-bin-ahmed-building-9404569.html", " DARWISH BIN AHMED BUILDING,", 4, 0.0, 950, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
