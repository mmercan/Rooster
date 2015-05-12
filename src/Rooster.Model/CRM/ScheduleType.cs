namespace Rooster.Model.CRM
{
    // [Table("crm.ScheduleTypes")]
    public partial class ScheduleType
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

       // [StringLength(250)]
        public string Value { get; set; }

        public int? OrderBy { get; set; }
    }
}
