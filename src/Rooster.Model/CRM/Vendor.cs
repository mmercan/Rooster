namespace Rooster.Model.CRM
{
    using System;

    // [Table("crm.Vendors")]
    public partial class Vendor
    {
        public Guid ID { get; set; }

       // [StringLength(250)]
        public string Name { get; set; }

        public int? OrderBy { get; set; }
    }
}
