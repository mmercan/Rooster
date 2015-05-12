namespace Rooster.Model.CRM
{
    using System;

    // [Table("crm.Cities")]
    public partial class City
    {
        public Guid ID { get; set; }

        public Guid? CountryID { get; set; }

        public Guid? StateID { get; set; }

      //  [StringLength(50)]
        public string Name { get; set; }

      //  [StringLength(250)]
        public string Title { get; set; }
    }
}
