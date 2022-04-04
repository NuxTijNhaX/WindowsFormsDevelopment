namespace TestDatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubjectProgram
    {
        [Key]
        [Column(Order = 0)]
        public string MajorProgramId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string SubjectId { get; set; }

        public string Semester { get; set; }

        public int? MajorProgram_Id { get; set; }

        public virtual MajorProgram MajorProgram { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
