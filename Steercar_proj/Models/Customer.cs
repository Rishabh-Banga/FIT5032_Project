namespace Steercar_proj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string CustEmail { get; set; }

        public int LicNo { get; set; }

        public int PhNo { get; set; }

        [Required]
        public string CustId { get; set; }
    }
}
