using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecepieInfo.API.Entities
{
    public class Recepie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }    

        [MaxLength(200, ErrorMessage ="Recepie Description should be less than 200 chars")]
        public string? Description { get; set; }

        public byte[]? ImageData { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public Recepie( string name)
        {
            Name = name;
        }
    }
    
}
