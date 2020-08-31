using System.ComponentModel.DataAnnotations;

namespace dotnet_blogger.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]

        public string Body { get; set; }
        [Required]
        public bool isPublished { get; set; }

    }

}