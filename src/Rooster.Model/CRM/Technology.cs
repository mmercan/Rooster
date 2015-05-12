namespace Rooster.Model.CRM
{
    using System;

    //  [Table("crm.Technologies")]
    public partial class Technology
    {
        public Guid ID { get; set; }

        public Guid? VendorID { get; set; }

        public Guid? CategoryID { get; set; }

        public Guid? ParentID { get; set; }

      //  [StringLength(250)]
        public string Name { get; set; }

        public int? OrderBy { get; set; }
    }
}
