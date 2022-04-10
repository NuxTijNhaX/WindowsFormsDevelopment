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

        public Guid? InvoiceHeader_GuidInvoice { get; set; }

        [StringLength(15)]
        public string SubjectClass_Id { get; set; }

        public virtual SubjectClass SubjectClass { get; set; }

        public virtual InvoiceHeader InvoiceHeader { get; set; }
    }
}
