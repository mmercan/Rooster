using Rooster.Model.CRM;
using System.Linq;
using Microsoft.Data.Entity;

namespace Rooster.Data
{ 
    public partial class CrmEntities : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=AdventureWorks2014;Integrated Security=True;Connect Timeout=15");
            //optionsBuilder.UseSqlServer("Server=tcp:me1i2aveth.database.windows.net,1433;Database=AdventureWorks2012;User ID=mmercan@me1i2aveth;Password=Pa$$w0rd;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
            optionsBuilder.UseSqlServer(
                "Data Source=sqlcluster.fastlane-ap.com;Initial Catalog=FastLane;Persist Security Info=True;User ID=sa;Password=F@5t1@n3;MultipleActiveResultSets=True;Application Name=EntityFramework");
            base.OnConfiguring(optionsBuilder);
        }


        public virtual DbSet<Category> CategorySet { get; set; }
        public virtual DbSet<City> CitySet { get; set; }
        public virtual DbSet<Country> CountrySet { get; set; }
        public virtual DbSet<Currency> CurrencySet { get; set; }
        public virtual DbSet<DeliveryType> DeliveryTypeSet { get; set; }
        public virtual DbSet<Instructor> InstructorSet { get; set; }
        public virtual DbSet<PriceList> PriceListSet { get; set; }
        public virtual DbSet<Price> PriceSet { get; set; }
        public virtual DbSet<Product> ProductSet { get; set; }
        public virtual DbSet<Region> RegionSet { get; set; }
        public virtual DbSet<SchedulePublish> SchedulePublishSet { get; set; }
        public virtual DbSet<Schedule> ScheduleSet { get; set; }
        public virtual DbSet<ScheduleStatus> ScheduleStatusSet { get; set; }
        public virtual DbSet<ScheduleType> ScheduleTypeSet { get; set; }
        public virtual DbSet<State> StateSet { get; set; }
        public virtual DbSet<StudentFinanceStatus> StudentFinanceStatusSet { get; set; }
        public virtual DbSet<StudentOperationStatus> StudentOperationStatusSet { get; set; }
        public virtual DbSet<Student> StudentSet { get; set; }
        public virtual DbSet<Technology> TechnologySet { get; set; }
        public virtual DbSet<Unit> UnitSet { get; set; }
        public virtual DbSet<Vendor> VendorSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(ent =>
            {
                ent.ForSqlServer().Table("Categories", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<City>(ent =>
            {
                ent.ForSqlServer().Table("Cities", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<Country>(ent =>
            {
                ent.ForSqlServer().Table("Countries", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<Currency>(ent =>
            {
                ent.ForSqlServer().Table("Currencies", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<DeliveryType>(ent =>
            {
                ent.ForSqlServer().Table("DeliveryTypes", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<Instructor>(ent =>
            {
                ent.ForSqlServer().Table("Instructors", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<PriceList>(ent =>
            {
                ent.ForSqlServer().Table("PriceLists", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<Price>(ent =>
            {
                ent.ForSqlServer().Table("Prices", "CRM");
                ent.Key(p => p.ID);

                ent.Property(p => p.PriceAmount).ForSqlServer().Column("Price");
            });
            modelBuilder.Entity<Product>(ent =>
            {
                ent.ForSqlServer().Table("Products", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<Region>(ent =>
            {
                ent.ForSqlServer().Table("Regions", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<SchedulePublish>(ent =>
            {
                ent.ForSqlServer().Table("SchedulePublish", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<Schedule>(ent =>
            {
                ent.ForSqlServer().Table("Schedules", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<ScheduleStatus>(ent =>
            {
                ent.ForSqlServer().Table("ScheduleStatus", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<ScheduleType>(ent =>
            {
                ent.ForSqlServer().Table("ScheduleTypes", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<State>(ent =>
            {
                ent.ForSqlServer().Table("States", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<StudentFinanceStatus>(ent =>
            {
                ent.ForSqlServer().Table("StudentFinanceStatus", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<StudentOperationStatus>(ent =>
            {
                ent.ForSqlServer().Table("StudentOperationStatus", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<Student>(ent =>
            {
                ent.ForSqlServer().Table("Students", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<Technology>(ent =>
            {
                ent.ForSqlServer().Table("Technologies", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<Unit>(ent =>
            {
                ent.ForSqlServer().Table("Units", "CRM");
                ent.Key(p => p.ID);
            });
            modelBuilder.Entity<Vendor>(ent =>
            {
                ent.ForSqlServer().Table("Vendors", "CRM");
                ent.Key(p => p.ID);
            });



            // .Property(e => e.ExchangeRate);
            //.HasPrecision(23, 10);

            //modelBuilder.Entity<PriceList>()
            //    .Property(e => e.ExchangeRate)
            //    .HasPrecision(23, 10);

            //modelBuilder.Entity<Price>()
            //    .Property(e => e.ExchangeRate)
            //    .HasPrecision(23, 10);

            //modelBuilder.Entity<Price>()
            //    .Property(e => e.Price1)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Price>()
            //    .Property(e => e.PriceBase)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Unit>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(23, 10);
        }
    }
}
