using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KhumaloCraft.Entity
{
    public class CraftDetailsEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CraftName { get; set; } = string.Empty;
        public string CraftData { get; set; } = string.Empty;

        [Required]
        public double CraftCost { get; set; } = 0;

        [NotMapped]
        public IFormFile ImageFile { get; set; } 
    }
}
