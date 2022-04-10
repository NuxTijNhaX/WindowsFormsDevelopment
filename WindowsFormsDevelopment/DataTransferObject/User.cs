namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User.Users")]
    public partial class User
    {
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        public virtual Student Student { get; set; }

        public virtual Account Account { get; set; }
    }
}
