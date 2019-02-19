namespace DataBaseLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Net.Mail;

    [Table("AutentnData")]
    public partial class AutentnData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AutentnData()
        {
            UserInfoes = new HashSet<UserInfo>();
        }

        public static EventHandler<string> eror;
        private string email;

        [Key]
        public int SecureID { get; set; }

        [Required]
        [StringLength(50)]
        public string Email
        {
            set
            {
                try
                {
                    MailAddress mail = new MailAddress(value);
                }
                catch (FormatException)
                {
                    eror.Invoke(this, "email");
                }
                finally
                {
                    email = value;
                }
            }
            get
            {
                return email;
            }
        }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInfo> UserInfoes { get; set; }
    }
}
