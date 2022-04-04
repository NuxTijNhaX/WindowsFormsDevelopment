namespace TestDatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Room
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public bool IsLab { get; set; }

        [StringLength(128)]
        public string Campus_Id { get; set; }

        public virtual Campu Campu { get; set; }
    }
}
