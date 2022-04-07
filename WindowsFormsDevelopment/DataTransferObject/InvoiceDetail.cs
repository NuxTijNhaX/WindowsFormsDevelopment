namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice.InvoiceDetails")]
    public partial class InvoiceDetail
    {
        public int Id { get; set; }

        [StringLength(15)]
        public string GradeSubjectClass_SubjectClassId { get; set; }

        [StringLength(11)]
        public string GradeSubjectClass_StudentId { get; set; }

        public Guid? InvoiceHeader_GuidInvoice { get; set; }

        public virtual GradeSubjectClass GradeSubjectClass { get; set; }

        public virtual InvoiceHeader InvoiceHeader { get; set; }
    }
}
