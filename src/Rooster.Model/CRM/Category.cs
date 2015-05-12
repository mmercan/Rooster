namespace Rooster.Model.CRM
{
    using System;

    // [Table("crm.Categories")]
    public partial class Category
    {
        public Guid ID { get; set; }

        public Guid? VendorID { get; set; }

   //     [StringLength(250)]
        public string Name { get; set; }

        public int? OrderBy { get; set; }

        public string Base64LogoImage { get; set; }
    }
}
