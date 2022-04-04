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
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string SubjectClassId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string StudentId { get; set; }

        public float Grade { get; set; }

        public virtual SubjectClass SubjectClass { get; set; }

        public virtual Student Student { get; set; }
    }
}
