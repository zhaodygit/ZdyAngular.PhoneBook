using System.ComponentModel.DataAnnotations;

namespace ZdyAngular.PhoneBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}