using System.ComponentModel.DataAnnotations.Schema;

namespace Maxim_free_task.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
        [NotMapped]
        public IFormFile ImgFile { get; set; }
    }
}
