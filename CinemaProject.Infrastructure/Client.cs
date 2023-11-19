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
        [Column("ID_client")]
        public long IdClient { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("Last_name_client")]
        public string LastNameClient { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("Name_client")]
        public string NameClient { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("Middle_name_client ")]
        public string MiddleNameClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionEntity> Session { get; set; }
    }
}
