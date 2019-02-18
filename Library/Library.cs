namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Library")]
    public partial class Library
    {
        [Key]
        public int OperationID { get; set; }

        [Required]
        public int? BookID { get; set; }
        [Required]
        public int? BookOwner { get; set; }

        public virtual Book Book { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
