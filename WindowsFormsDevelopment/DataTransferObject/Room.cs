namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Facility.Rooms")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            SubjectClasses = new HashSet<SubjectClass>();
        }

        [StringLength(6)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public bool IsLab { get; set; }

        [StringLength(2)]
        public string Campus_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectClass> SubjectClasses { get; set; }

        public virtual Campus Campus { get; set; }
    }
}
