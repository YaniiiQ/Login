using System.ComponentModel.DataAnnotations;

namespace MovieStoreMvc.Models.Domain
{
    public class Genre
    {
        internal IFormFile ImageFile;

        public int Id { get; set; }
        [Required]
        public string? GenreName { get; set; }
    }
}