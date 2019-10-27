namespace Steercar_proj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        public int CarId { get; set; }

        [Required]
        public string CarName { get; set; }

        [Required]
        public string CarModel { get; set; }

        [Column(TypeName = "date")]
        public DateTime CarManDate { get; set; }

        public int CarPrice { get; set; }

        public int CarMinKm { get; set; }

        public int CarNoSeat { get; set; }

        public int CarNo { get; set; }
    }
}
