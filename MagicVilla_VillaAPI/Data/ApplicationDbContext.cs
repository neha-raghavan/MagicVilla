

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
       
        public DbSet<Villa> Villas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "GREEN COMMUNITY WEST",
                    Details = "Green Community is a residential community located in Dubai, United Arab Emirates. It features a variety of fully furnished 1 bedroom apartments with park views available for rent. The apartments are equipped with modern amenities and are located in a peaceful and serene setting, surrounded by lush greenery and landscaped gardens.",
                    Sqft = 900,
                    Occupancy = 5,
                    ImageUrl = "https://www.propertyfinder.ae/en/plp/rent/apartment-for-rent-dubai-green-community-green-community-west-southwest-apartments-9327099.html",
                    Amenity = "Furnished\r\nCentral A/C\r\nCovered Parking\r\nKitchen Appliances\r\nSecurity\r\nShared Gym\r\nShared Pool",
                    CreatedAt = DateTime.Now,
                },
                 new Villa
                 {
                     Id = 2,
                     Name = " THE EDGE,",
                     Details = "The Edge is nestled within the mixed-use gated community of Ewan Residences, Dubai Investment Park. This sleek, high-quality, yet affordable, residential development offers its tenants the utmost accessibility to Dubai’s most prominent business and retail centers, including the highly anticipated Expo 2020 site.",
                     Sqft = 800,
                     Occupancy = 4,
                     ImageUrl = "https://www.propertyfinder.ae/en/plp/rent/apartment-for-rent-dubai-dubai-investment-park-the-edge-9058935.html",
                     Amenity = "Furnished\r\nCentral A/C\r\nCovered Parking\r\nKitchen Appliances\r\nSecurity\r\nShared Gym\r\nShared Pool",
                     CreatedAt = DateTime.Now,
                 },
                 new Villa
                 {
                     Id = 3,
                     Name = " DARWISH BIN AHMED BUILDING,",
                     Details = "Spacious | Modern Interior | Kitchen Equipped\r\n\r\n*Ready to move in\r\n*Open and a Fully Fitted kitchen ( Oven, refrigerator & washing machine included)\r\n*Bathroom: 2\r\n*Free 4 burner cooker\r\n*Multiple Units Available\r\n\r\nFeatures:\r\n*Low-rise building\r\n*Central air conditioning\r\n*Gymnasium\r\n*24 hrs Security\r\n*Games room and children’s play area\r\n*Maintenance Included\r\n*Near to Shops\r\n*In front of Public Transportation\r\n*In front of Park\r\n\r\nSchools near by:\r\n1. Nibras International School ( [link not available] )\r\n2. Greenfield International School ( [link not available] )\r\n3. The International School of Choueifat-DIP ( [link not available] 4. Dove Green Private School ( [link not available] )\r\n5. Bright Riders School ( [link not available]\r\nLocation:\r\n*5 Min to Sheikh Mohammed Bin Zayed road\r\n*10 Mins to Al Khail Road\r\n*12 Mins to Marina, JLT , JBR\r\n*12 Mins to Ibn Battuta Mall\r\n*12 Min to Ikea\r\n*15 Min to Dubai Hills Mall\r\n*15 Mins to Mall of the Emirates\r\n*20 Mins to Dubai Mall\r\n*25 Mins to Dubai Airport\r\n\r\nDubai Investments Park is perfect location for families with easy access to main roads in Dubai. DIP is a business park area in Dubai, United Arab Emirates, including commercial, and industrial, and residential development. It is designed to be one of the most environment-friendly developments in the region.\r\n\r\nOne Tastik Real Estate Brokerage:\r\nTalent. Drive. Innovation. Service.\r\nWe have what it takes to push real estate forward!\r\n\r\n*For more details please call our Senior Property Consultant Lucy Carmichael on whatsapp\r\nDisplay phone number",
                     Sqft = 950,
                     Occupancy = 4,
                     ImageUrl = "https://www.propertyfinder.ae/en/plp/rent/apartment-for-rent-dubai-dubai-investment-park-darwish-bin-ahmed-building-9404569.html",
                     Amenity = "Unfurnished\r\nBuilt in Wardrobes\r\nChildren's Play Area\r\nCovered Parking\r\nSecurity\r\nView of Landmark",
                     CreatedAt= DateTime.Now,
                 }
                );
        }
    }
}
