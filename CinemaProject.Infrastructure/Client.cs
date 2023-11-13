namespace CinemaProject.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class ClientEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientEntity()
        {
            Session = new HashSet<SessionEntity>();
        }

        [Key]
        public long ID_client { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Last_name_client { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name_client { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Middle_name_client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionEntity> Session { get; set; }
    }
}
