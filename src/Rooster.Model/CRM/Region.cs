namespace Rooster.Model.CRM
{
    using System;

    //  [Table("crm.Regions")]
    public partial class Region
    {
        public Guid ID { get; set; }

    //    [StringLength(50)]
        public string Name { get; set; }

   //     [StringLength(250)]
        public string Title { get; set; }

        public int? OrderBy { get; set; }
    }
}
