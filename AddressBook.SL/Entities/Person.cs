using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AddressBook.DL;

namespace AddressBook.SL.Entities
{
    public class Person : IEntity<int>
    {
        [Column("PersonId")]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; } 
    }
}
