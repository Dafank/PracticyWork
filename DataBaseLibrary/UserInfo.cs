namespace DataBaseLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInfo")]
    public partial class UserInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserInfo()
        {
            Libraries = new HashSet<Library>();
        }

        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(30)]
        public string Lname { get; set; }

        [Required]
        [StringLength(30)]
        public string FName { get; set; }

        [Required]
        [StringLength(30)]
        public string MName { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        public int SecureID { get; set; }

        public virtual AutentnData AutentnData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Library> Libraries { get; set; }
    }
}
