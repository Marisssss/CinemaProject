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
        [Column("ID_employee")]
        public long IdEmployee { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("Last_name_employee")]
        public string LastNameEmployee { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("Name_employee")]
        public string NameEmployee { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("Middle_name_employee")]
        public string MiddleNameEmployee { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("Date_of_birth")]
        public string DateOfBirth { get; set; }

        [StringLength(2147483647)]
        public string Floor { get; set; }

        [Column("ID_post")]
        public long IdPost { get; set; }

        public virtual PostEntity Post { get; set; }
    }
}
