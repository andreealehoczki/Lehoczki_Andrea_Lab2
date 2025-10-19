using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lehoczki_Andrea_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Publisher")]
        public string PublisherName { get; set; }

        public string Address { get; set; }

        // O editură are mai multe cărți
        public ICollection<Book>? Books { get; set; }
    }
}
