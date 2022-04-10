namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subject.Subjects")]
    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            SubjectClasses = new HashSet<SubjectClass>();
            SubjectPrograms = new HashSet<SubjectProgram>();
        }

        [StringLength(9)]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Credit { get; set; }

        [Required]
        [StringLength(100)]
        public string PrerequisiteSubject { get; set; }

        [Required]
        [StringLength(100)]
        public string SubjectLecturer { get; set; }

        [StringLength(5)]
        public string Faculty_Id { get; set; }

        [StringLength(128)]
        public string LecturerId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectClass> SubjectClasses { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectProgram> SubjectPrograms { get; set; }
    }
}
