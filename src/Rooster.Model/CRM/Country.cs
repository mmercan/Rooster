namespace Rooster.Model.CRM
{
    using System;

    //  [Table("crm.Countries")]
    public partial class Country
    {
        public Guid ID { get; set; }

        public Guid? RegionID { get; set; }

       // [StringLength(50)]
        public string Name { get; set; }

       // [StringLength(250)]
        public string Title { get; set; }
    }
}
