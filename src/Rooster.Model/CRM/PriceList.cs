namespace Rooster.Model.CRM
{
    using System;

    // [Table("crm.PriceLists")]
    public partial class PriceList
    {
        public Guid ID { get; set; }

        public Guid? CurrencyID { get; set; }

      //  [StringLength(250)]
        public string Name { get; set; }

      //  [StringLength(500)]
        public string Description { get; set; }

        public DateTime? BeginDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal? ExchangeRate { get; set; }
    }
}
