namespace CinemaProject.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hall")]
    public partial class HallEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HallEntity()
        {
            Session = new HashSet<SessionEntity>();
        }

        [Key]
        [Column("ID_hall")]
        public long IdHall { get; set; }

        [Column("Number_of_seats")]
        public long NumberOfSeats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionEntity> Session { get; set; }
    }
}
