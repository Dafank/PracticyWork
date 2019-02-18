namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutentnData")]
    public partial class AutentnData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AutentnData()
        {
            UserInfoes = new HashSet<UserInfo>();
        }

        [Key]
        public int SecureID { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInfo> UserInfoes { get; set; }
    }
}
