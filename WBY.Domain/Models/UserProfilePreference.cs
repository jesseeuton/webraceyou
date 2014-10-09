using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WBY.Domain.Models
{
    [Table("UserProfilePreference")]
    public class UserProfilePreference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserProfileId { get; set; }

        [ForeignKey("UserProfileId")]
        public UserProfile UserProfile { get; set; }
    }
}