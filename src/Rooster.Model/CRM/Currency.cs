namespace Rooster.Model.CRM
{
    using System;

    //[Table("crm.Currencies")]
    public partial class Currency
    {
        public Guid ID { get; set; }

       // [StringLength(13)]
        public string Symbol { get; set; }

      //  [StringLength(5)]
        public string Code { get; set; }

       // [StringLength(100)]
        public string Name { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? Precision { get; set; }
    }
}
