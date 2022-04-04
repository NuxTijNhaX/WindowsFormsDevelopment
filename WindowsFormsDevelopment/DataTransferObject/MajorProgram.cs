namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Program.MajorPrograms")]
    public partial class MajorProgram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MajorProgram()
        {
            Classes = new HashSet<Class>();
            SubjectPrograms = new HashSet<SubjectProgram>();
        }

        [StringLength(20)]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int TotalSemester { get; set; }

        [StringLength(5)]
        public string Faculty_Id { get; set; }

        [StringLength(3)]
        public string Major_Id { get; set; }

        public int? SchoolLevel_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual Major Major { get; set; }

        public virtual SchoolLevel SchoolLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectProgram> SubjectPrograms { get; set; }
    }
}
