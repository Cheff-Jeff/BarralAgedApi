using System.ComponentModel.DataAnnotations;

namespace BarrelAgedApi.Models
{
    public class Beer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string beerDate { get; set; } = "";

        [Required]
        public string beerLocation { get; set; } = "";

        [Required]
        public string beerName { get; set; } = "";

        [Required]
        [MaxLength(200)]
        public string beerDescription { get; set; } = "";

        [Required]
        public int userId { get; set; }
    }
}
