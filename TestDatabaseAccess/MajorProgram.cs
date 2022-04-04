namespace TestDatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MajorProgram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MajorProgram()
        {
            Classes = new HashSet<Class>();
            SubjectPrograms = new HashSet<SubjectProgram>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int TotalSemester { get; set; }

        [StringLength(128)]
        public string Major_Id { get; set; }

        [StringLength(128)]
        public string Faculty_Id { get; set; }

        public string SchoolLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual Major Major { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectProgram> SubjectPrograms { get; set; }
    }
}
