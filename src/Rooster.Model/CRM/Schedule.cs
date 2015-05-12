namespace Rooster.Model.CRM
{
    using System;

   // [Table("crm.Schedules")]
    public partial class Schedule
    {
        public Guid ID { get; set; }

        public Guid? RegionID { get; set; }

        public Guid? CountryID { get; set; }

        public Guid? StateID { get; set; }

        public Guid? CityID { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? VendorID { get; set; }

        public Guid? CategoryID { get; set; }

        public Guid? TechnologyID { get; set; }

        public Guid? InstructorID { get; set; }

        public int? TotalStudents { get; set; }

       // [StringLength(250)]
        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public int? StartTime { get; set; }

        public DateTime? EndDate { get; set; }

        public int? EndTime { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public int? Week { get; set; }

        public int? Day { get; set; }

        public int? Type { get; set; }

        public int? Status { get; set; }

        public int? Publish { get; set; }
    }
}
