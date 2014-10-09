using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBY.Domain.Models
{
    [Table("SubstanceVehicle")]
    public class SubstanceVehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public int SubstanceId { get; set; }
        [ForeignKey("SubstanceId")]
        public Substance Substance { get; set; }
    }
}
