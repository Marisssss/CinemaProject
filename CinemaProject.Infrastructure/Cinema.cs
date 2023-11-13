namespace CinemaProject.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cinema")]
    public partial class CinemaEntity
    {
        [Key]
        public long ID_cinema { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Address { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name_cinema { get; set; }
    }
}
