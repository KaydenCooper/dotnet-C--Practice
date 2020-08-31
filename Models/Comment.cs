using System.ComponentModel.DataAnnotations;

namespace dotnet_blogger.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        [Required]
        public int blogId { get; set; }

    }

}