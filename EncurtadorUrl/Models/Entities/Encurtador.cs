using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EncurtadorUrl.Models.Entities
{
    public class Encurtador
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string link { get; set; }

        [Required]
        public string shortUrl { get; set; }

        [Required]
        public DateTime dateTime { get; set; }


    }
}
