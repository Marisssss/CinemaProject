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
        public long ID_session { get; set; }

        public long Cost { get; set; }

        public long Number_of_client { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Session_start_time { get; set; }

        public decimal Session_end_time { get; set; }

        public long ID_movie { get; set; }

        public long ID_hall { get; set; }

        public virtual HallEntity Hall { get; set; }

        public virtual MovieEntity Movie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientEntity> Client { get; set; }
    }
}
