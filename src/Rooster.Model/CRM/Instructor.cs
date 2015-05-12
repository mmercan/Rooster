namespace Rooster.Model.CRM
{
    using System;

    // [Table("crm.Instructors")]
    public partial class Instructor
    {
        public Guid ID { get; set; }

       // [StringLength(100)]
        public string Name { get; set; }

        public Guid? ContactID { get; set; }

        public Guid? RegionID { get; set; }

        public Guid? CountryID { get; set; }

        public Guid? CityID { get; set; }

        public Guid? StateID { get; set; }
    }
}
