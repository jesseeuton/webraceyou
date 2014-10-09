using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WBY.Domain.Models
{
    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }

        
        public List<UserProfilePreference> Preferences { get; set; }
        public List<UserProfileHistory> History { get; set; } 
    }
}