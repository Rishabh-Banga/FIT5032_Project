namespace Steercar_proj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        [Key]
        [Column(Order = 0)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 1)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 2)]
        public string CustEmail { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LicNo { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhNo { get; set; }
    }
}
