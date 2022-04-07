namespace WindowsFormsDevelopment.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice.PaymentMehods")]
    public partial class PaymentMehod
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }
    }
}
