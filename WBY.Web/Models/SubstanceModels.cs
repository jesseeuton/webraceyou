using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WBY.Web.Models
{
    [Table("Substance")]
    public class Substance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }

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