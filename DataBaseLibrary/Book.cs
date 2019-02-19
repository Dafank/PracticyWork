namespace DataBaseLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Libraries = new HashSet<Library>();
        }

        public int BookID { get; set; }

        [Required]
        [StringLength(100)]
        public string BookName { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        public short PageAmount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateReturn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBorrow { get; set; }

        public short Year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Library> Libraries { get; set; }
    }
}
