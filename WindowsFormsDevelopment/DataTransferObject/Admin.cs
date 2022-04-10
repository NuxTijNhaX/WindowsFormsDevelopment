namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person.Admins")]
    public partial class Admin
    {
        public string AdminId { get; set; }

        public virtual User User { get; set; }
    }
}
