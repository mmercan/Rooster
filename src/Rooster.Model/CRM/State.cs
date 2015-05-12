namespace Rooster.Model.CRM
{
    using System;

    //  [Table("crm.States")]
    public partial class State
    {
        public Guid ID { get; set; }

        public Guid? CountryID { get; set; }

      //  [StringLength(50)]
        public string Name { get; set; }

       // [StringLength(250)]
        public string Title { get; set; }
    }
}
