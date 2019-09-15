namespace Steercar_proj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [Key]
        public int BookId { get; set; }

        [Column(TypeName = "date")]
        public DateTime BookFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime BookTo { get; set; }
    }
}
