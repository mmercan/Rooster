namespace Rooster.Model.CRM
{
    using System;

    // [Table("crm.Prices")]
    public partial class Price
    {
        public Guid ID { get; set; }

        public Guid? PriceListID { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? UnitID { get; set; }

        public Guid? CurrencyID { get; set; }

        public decimal? ExchangeRate { get; set; }

       // [Column("Price", TypeName = "money")]
        public decimal? PriceAmount { get; set; }

       // [Column(TypeName = "money")]
        public decimal? PriceBase { get; set; }
    }
}
