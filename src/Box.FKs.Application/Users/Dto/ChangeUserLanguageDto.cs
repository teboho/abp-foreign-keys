using System.ComponentModel.DataAnnotations;

namespace Box.FKs.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}