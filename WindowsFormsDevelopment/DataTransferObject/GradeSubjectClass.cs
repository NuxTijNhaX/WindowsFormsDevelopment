namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class.GradeSubjectClasses")]
    public partial class GradeSubjectClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GradeSubjectClass()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string SubjectClassId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string StudentId { get; set; }

        public float? Grade { get; set; }

        public virtual SubjectClass SubjectClass { get; set; }

        public virtual Student Student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
