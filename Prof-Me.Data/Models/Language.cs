using System.ComponentModel.DataAnnotations;

namespace Prof_Me.Data.Models
{
    public class Language
    {
        public int Id { get; set; }
        [Display(Name = "Language Name")]
        public string LanguageName { get; set; }
        public UserProfile User { get; set; }

    }
}
