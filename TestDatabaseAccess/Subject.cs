namespace TestDatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            SubjectPrograms = new HashSet<SubjectProgram>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public int Credit { get; set; }

        [StringLength(128)]
        public string Faculty_Id { get; set; }

        public int? Lecturer_Id { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectProgram> SubjectPrograms { get; set; }
    }
}
