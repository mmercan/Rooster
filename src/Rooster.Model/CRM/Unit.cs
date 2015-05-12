namespace Rooster.Model.CRM
{
    using System;

    // [Table("crm.Units")]
    public partial class Unit
    {
        public Guid ID { get; set; }

        public Guid? BaseID { get; set; }

      //  [StringLength(100)]
        public string Name { get; set; }

        public decimal? Quantity { get; set; }
    }
}
