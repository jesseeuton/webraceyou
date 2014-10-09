using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBY.Domain.Models
{
    [Table("UserProfileHistory")]
    public class UserProfileHistory
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
