using System.ComponentModel.DataAnnotations;

namespace Cinema0613.Models
{
    public class Producer
    {
        [Key]

        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Fullname { get; set; }
        public string Bio { get; set; }
    }
}
