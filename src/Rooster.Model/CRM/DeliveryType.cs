namespace Rooster.Model.CRM
{
    using System;

    // [Table("crm.DeliveryTypes")]
    public partial class DeliveryType
    {
        public Guid ID { get; set; }

        public Guid? ScheduleID { get; set; }

        public Guid? RegionID { get; set; }

        public Guid? CountryID { get; set; }

        public Guid? StateID { get; set; }

        public Guid? CityID { get; set; }

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

        public int? TimeZone { get; set; }
    }
}
