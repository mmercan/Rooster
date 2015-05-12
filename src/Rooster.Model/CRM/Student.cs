namespace Rooster.Model.CRM
{
    using System;

    //  [Table("crm.Students")]
    public partial class Student
    {
        public Guid ID { get; set; }

        public Guid? ScheduleID { get; set; }

      //  [StringLength(100)]
        public string Code { get; set; }

    //    [StringLength(100)]
        public string JobTitle { get; set; }

    //    [StringLength(50)]
        public string FirstName { get; set; }

    //    [StringLength(100)]
        public string Department { get; set; }

   //     [StringLength(50)]
        public string NickName { get; set; }

  //      [StringLength(50)]
        public string LastName { get; set; }

  //      [StringLength(50)]
        public string MiddleName { get; set; }

 //       [StringLength(100)]
        public string EMailAddress { get; set; }

 //       [StringLength(50)]
        public string Telephone { get; set; }

        public Guid? ContactID { get; set; }

        public Guid? ProductID { get; set; }

        public int? OperationStatus { get; set; }

        public int? FinanceStatus { get; set; }

        public bool? RegistrationAcknowledgementSent { get; set; }

        public bool? CourseConfirmationSent { get; set; }

        public Guid? SalesOrderID { get; set; }
    }
}
