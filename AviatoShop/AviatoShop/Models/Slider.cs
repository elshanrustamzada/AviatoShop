using System.ComponentModel.DataAnnotations.Schema;

namespace AviatoShop.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool IsDeactive { get; set; }
        [NotMapped]
        public IFormFile? Photo { get; set; }

    }
}
