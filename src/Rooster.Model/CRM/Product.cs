namespace Rooster.Model.CRM
{
    using System;

  //  [Table("crm.Products")]
    public partial class Product
    {
        public Guid ID { get; set; }

        public Guid? VendorID { get; set; }

        public Guid? CategoryID { get; set; }

        public Guid? TechnologyID { get; set; }

        public Guid? ChildTechnologyID { get; set; }

      //  [StringLength(50)]
        public string Code { get; set; }

     //   [StringLength(50)]
        public string Version { get; set; }

    //    [StringLength(250)]
        public string Name { get; set; }

    //    [StringLength(50)]
        public string Unit { get; set; }

        public bool? Published { get; set; }

        public int? OrderBy { get; set; }
    }
}
