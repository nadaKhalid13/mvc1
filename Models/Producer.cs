using System.ComponentModel.DataAnnotations;
using System;

namespace nada1.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL  { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }
    }
}
