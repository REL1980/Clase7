using System.ComponentModel.DataAnnotations;

namespace Clase7.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}