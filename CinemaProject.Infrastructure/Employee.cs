namespace CinemaProject.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class EmployeeEntity
    {
        [Key]
        public long ID_employee { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Last_name_employee { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name_employee { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Middle_name_employee { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Date_of_birth { get; set; }

        [StringLength(2147483647)]
        public string Floor { get; set; }

        public long ID_post { get; set; }

        public virtual PostEntity Post { get; set; }
    }
}
