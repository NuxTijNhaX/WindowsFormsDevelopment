namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice.InvoiceHeaders")]
    public partial class InvoiceHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvoiceHeader()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        [Key]
        public Guid GuidInvoice { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        public DateTime? PaidDay { get; set; }

        public int TotalCost { get; set; }

        public int? PaymentMehod_Id { get; set; }

        [StringLength(128)]
        public string Student_StudentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public virtual PaymentMehod PaymentMehod { get; set; }

        public virtual Student Student { get; set; }
    }
}
