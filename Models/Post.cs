using System.ComponentModel.DataAnnotations;

namespace ApiConsulting.Models
{
    public class Post
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Title { get; set; }
    }
}
