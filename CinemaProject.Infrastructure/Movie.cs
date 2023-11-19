namespace CinemaProject.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class MovieEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovieEntity()
        {
            Session = new HashSet<SessionEntity>();
        }

        [Key]
        [Column("ID_movie")]
        public long IdMovie { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("Name_movie")]
        public string NameMovie { get; set; }

        public decimal Rating { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionEntity> Session { get; set; }
    }
}
