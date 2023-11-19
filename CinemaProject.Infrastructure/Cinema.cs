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
        [Column("ID_cinema")]
        public long IdCinema { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Address { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("Name_cinema")]
        public string NameCinema { get; set; }
    }
}
