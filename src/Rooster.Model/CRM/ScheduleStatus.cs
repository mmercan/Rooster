namespace Rooster.Model.CRM
{
    //[Table("crm.ScheduleStatus")]
    public partial class ScheduleStatus
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

       // [StringLength(250)]
        public string Value { get; set; }

        public int? OrderBy { get; set; }
    }
}
