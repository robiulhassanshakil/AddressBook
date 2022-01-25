using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AddressBook.DL;

namespace AddressBook.SL.Entities
{
    public class Person : IEntity<Guid>
    {
        [Column("PersonId")]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; } 
    }
}
