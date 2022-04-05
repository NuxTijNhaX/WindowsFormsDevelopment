namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Program.SubjectPrograms")]
    public partial class SubjectProgram
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MajorProgramId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(9)]
        public string SubjectId { get; set; }

        [Required]
        [StringLength(3)]
        public string OnScheduleSemester { get; set; }

        public string OptionGroup { get; set; }

        public virtual MajorProgram MajorProgram { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
