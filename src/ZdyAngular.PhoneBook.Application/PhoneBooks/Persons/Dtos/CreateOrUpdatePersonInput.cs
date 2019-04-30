

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ZdyAngular.PhoneBook.PhoneBooks.Persons;

namespace ZdyAngular.PhoneBook.PhoneBooks.Persons.Dtos
{
    public class CreateOrUpdatePersonInput
    {
        [Required]
        public PersonEditDto Person { get; set; }

    }
}