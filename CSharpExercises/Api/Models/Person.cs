using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Age")]
        public int Age { get; set; }

        [Column("Identification")]
        public string Identification { get; set; }

        [Column("Genre")]
        public string Genre { get; set; }
    }
}