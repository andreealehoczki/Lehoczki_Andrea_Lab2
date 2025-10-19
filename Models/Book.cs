using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lehoczki_Andrea_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }   
        public Publisher? Publisher { get; set; }  
        
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

    }
}
