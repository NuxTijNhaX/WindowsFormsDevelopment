namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class.SubjectClasses")]
    public partial class SubjectClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubjectClass()
        {
            GradeSubjectClasses = new HashSet<GradeSubjectClass>();
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        [StringLength(15)]
        public string Id { get; set; }

        public int Year { get; set; }

        public int Semester { get; set; }

        [StringLength(3)]
        public string OffScheduleSemester { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        [StringLength(9)]
        public string Class_Id { get; set; }

        [StringLength(128)]
        public string LecturerId { get; set; }

        [StringLength(6)]
        public string Room_Id { get; set; }

        public int? Shift_Id { get; set; }

        [StringLength(9)]
        public string Subject_Id { get; set; }

        public virtual Class Class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradeSubjectClass> GradeSubjectClasses { get; set; }

        public virtual Room Room { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        public virtual Shift Shift { get; set; }

        public virtual Subject Subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
