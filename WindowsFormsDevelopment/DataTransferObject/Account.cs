namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User.Accounts")]
    public partial class Account
    {
        public string Id { get; set; }

        public string Password { get; set; }

        public virtual User User { get; set; }
    }
}
