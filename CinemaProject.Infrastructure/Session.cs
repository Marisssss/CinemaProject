namespace CinemaProject.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Session")]
    public partial class SessionEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SessionEntity()
        {
            Client = new HashSet<ClientEntity>();
        }

        [Key]
        [Column("ID_session")]
        public long IdSession { get; set; }

        public long Cost { get; set; }

        [Column("Number_of_client")]
        public long NumberOfClient { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("Session_start_time")]
        public string SessionStartTime { get; set; }

        [Column("Session_end_time")]
        public decimal SessionEndTime { get; set; }

        [Column("ID_movie")]
        public long IdMovie { get; set; }

        [Column("ID_hall")]
        public long IdHall { get; set; }

        public virtual HallEntity Hall { get; set; }

        public virtual MovieEntity Movie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientEntity> Client { get; set; }
    }
}
